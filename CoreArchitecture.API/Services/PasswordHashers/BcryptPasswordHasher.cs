﻿using CoreArchitecture.Core.Abstract;

namespace CoreArchitecture.API.Services.PasswordHashers
{
    public class BcryptPasswordHasher : IPasswordHasher
    {
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}
