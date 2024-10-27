﻿using Microsoft.Extensions.DependencyInjection;
using RFUserEmail.IServices;
using RFUserEmail.Services;

namespace RFUserEmail
{
    public static class MvcServiceCollectionExtensions
    {
        public static void AddRFUserEmail(this IServiceCollection services)
        {
            services.AddScoped<IUserEmailService, UserEmailService>();
        }
    }
}
