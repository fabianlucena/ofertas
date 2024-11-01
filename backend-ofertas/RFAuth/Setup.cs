﻿using RFAuth.Entities;
using Microsoft.Extensions.DependencyInjection;
using RFAuth.IServices;

namespace RFAuth
{
    public static class Setup
    {
        public static void ConfigureRFAuth(IServiceProvider services)
        {
            ConfigureRFAuthAsync(services).Wait();
        }

        public static async Task ConfigureRFAuthAsync(IServiceProvider services)
        {
            var userTypeService = services.GetService<IUserTypeService>() ??
                throw new Exception("Can't get IUserTypeService");
            var userType = await userTypeService.GetOrCreateAsync(new UserType
                {
                    Name = "user",
                    Title = "User",
                    IsTranslatable = true,
                });

            var userService = services.GetService<IUserService>() ??
                throw new Exception("Can't get IUserService");
            var user = await userService.GetOrCreateAsync(new User
                {
                    TypeId = userType.Id,
                    Username = "admin",
                    FullName = "Administrador",
                });

            var passwordService = services.GetService<IPasswordService>() ??
                throw new Exception("Can't get IPasswordService");
            await passwordService.CreateIfNotExistsAsync(new Password
            {
                UserId = user.Id,
                Hash = "$2a$11$fRe./FCGyNjS9Vao3IIBlOiVCx3C05NRBNFrHhVk32Qdw75Ia.Y5S",
            });
        }
    }
}
