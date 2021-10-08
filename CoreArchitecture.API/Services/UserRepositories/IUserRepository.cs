using CoreArchitecture.API.JWT.Models;
using System.Threading.Tasks;

namespace CoreArchitecture.API.JWT.Services.UserRepositories
{
    public interface IUserRepository
    {
        Task<User> GetByEmail(string email);
        Task<User> GetByUsername(string username);
        Task<User> Create(User user);
    }
}
