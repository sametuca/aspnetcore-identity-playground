using CoreArchitecture.API.Controllers.Base;
using CoreArchitecture.API.JWT.Models;
using CoreArchitecture.API.JWT.Models.Response;
using CoreArchitecture.API.JWT.Request;
using CoreArchitecture.API.JWT.Services.UserRepositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreArchitecture.Core.Abstract;

namespace CoreArchitecture.API.Controllers
{
    public class AuthenticationController : BaseController
    {
        private readonly IUserRepository repository;
        private readonly IPasswordHasher hasher;

        public AuthenticationController(IUserRepository repository, IPasswordHasher hasher)
        {
            this.repository = repository;
            this.hasher = hasher;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest registerRequest)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<string> errorMessages =
                    ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage));

                return BadRequest(new ErrorResponse(errorMessages));

            }

            if (registerRequest.Password != registerRequest.ConfirmPassword)
            {
                return Conflict(new ErrorResponse("Password does not match confirm password"));
            }

            var existingUserByEmail = await repository.GetByEmail(registerRequest.Email);
            if (existingUserByEmail != null)
            {
                return Conflict(new ErrorResponse("Email already exist"));
            }
            var existingUserUserName = await repository.GetByUsername(registerRequest.Username);
            if (existingUserUserName != null)
            {
                return Conflict(new ErrorResponse("Username already exist"));
            }

            string passwordHash = hasher.HashPassword(registerRequest.Password);
            User registrationUser = new User()
            {
                Email = registerRequest.Email,
                Username = registerRequest.Username,
                PasswordHash = passwordHash
            };
            await repository.Create(registrationUser);
            return Ok();
        }
    }
}
