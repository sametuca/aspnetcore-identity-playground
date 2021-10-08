using CoreArchitecture.API.JWT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreArchitecture.API.JWT.Services.UserRepositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        private readonly List<User> users = new List<User>();
        public Task<User> GetByEmail(string email)
        {
            return Task.FromResult(users.FirstOrDefault(u => u.Email == email));
        }

        public Task<User> GetByUsername(string username)
        {
            return Task.FromResult(users.FirstOrDefault(u => u.Username == username));
        }

        public Task<User> Create(User user)
        {
            user.Id = Guid.NewGuid();
            users.Add(user);
            return Task.FromResult(user);
        }
    }
}
