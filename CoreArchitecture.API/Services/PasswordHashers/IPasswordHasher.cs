namespace CoreArchitecture.API.JWT.Services.PasswordHashers
{
    public interface IPasswordHasher
    {
        string HashPassword(string password);
    }
}
