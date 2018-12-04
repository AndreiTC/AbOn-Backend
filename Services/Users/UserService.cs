using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Entities.Interfaces.Repository;
using Entities.Interfaces.Services;
using Entities.Models.UserAggregate;
using Microsoft.IdentityModel.Tokens;
using Services.Common;

namespace Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly SecurePassword _securePassword;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _securePassword = new SecurePassword();
        }

        public User AddUser(User user)
        {
            var newPassword = _securePassword.GeneratePassword(user.Password);
            user.Password = newPassword.Hash;
            user.Salt = newPassword.Salt;
            return _userRepository.AddUser(user);
        }

        public User Authenticate(string name, string password, string secret)
        {
            var user = _userRepository.Authenticate(name);

            if (user == null)
                return null;

            if (!_securePassword.CheckUserNameAndPassword(user, password))
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            user.Password = null;
            
            return user;
        }
    }
}
