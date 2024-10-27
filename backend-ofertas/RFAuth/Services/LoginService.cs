﻿using RFAuth.DTO;
using RFAuth.Exceptions;
using RFAuth.IServices;

namespace RFAuth.Services
{
    public class LoginService(IUserService userService, IPasswordService passwordService, IDeviceService deviceService, ISessionService sessionService) : ILoginService
    {
        private readonly IUserService _userService = userService;
        private readonly IPasswordService _passwordService = passwordService;
        private readonly IDeviceService _deviceService = deviceService;
        private readonly ISessionService _sessionService = sessionService;

        public async Task<AuthorizationData> LoginAsync(LoginData loginData)
        {
            if (string.IsNullOrWhiteSpace(loginData.Username)) {
                throw new ArgumentNullException(nameof(loginData.Username));
            }
            var user = await _userService.GetSingleForUsernameAsync(loginData.Username);

            if (string.IsNullOrWhiteSpace(loginData.Password)) {
                throw new ArgumentNullException(nameof(loginData.Password));
            }

            var password = await _passwordService.GetSingleForUserAsync(user);
            var check = _passwordService.Verify(loginData.Password, password);
            if (!check) {
                throw new BadPasswordException();
            }

            var device = await _deviceService.GetSingleForTokenOrCreateAsync(loginData?.DeviceToken);
            var session = await _sessionService.CreateForUserAndDeviceAsync(user, device);

            return new AuthorizationData
            {
                AuthorizationToken = session.Token,
                AutoLoginToken = session.AutoLoginToken,
                DeviceToken = device.Token,
            }; ;
        }
    }
}
