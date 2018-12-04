using System;
using System.Security.Cryptography;
using Entities.Models.UserAggregate;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;


namespace Services.Common
{
    public class SecurePassword
    {
        private byte[] Salt()
        {
            byte[] salt = new byte[128 / 8];

            using (var range = RandomNumberGenerator.Create())
            {
                range.GetBytes(salt);
            }
            return salt;
        }

        protected string Hash(string password, byte[] salt)
        {
            string hash = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            return hash;
        }

        public Password GeneratePassword(string password)
        {
            Byte[] salt = Salt();

            Password newPassword = new Password
            {
                Salt = salt,
                Hash = Hash(password, salt)
            };

            return newPassword;
        }

        public bool CheckUserNameAndPassword(User user, string password)
        {
            var expectedHash = user.Password;

            var currentHash = Hash(password, user.Salt);

            return expectedHash.Equals(currentHash);
        }
    }
}
