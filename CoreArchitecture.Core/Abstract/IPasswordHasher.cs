namespace CoreArchitecture.Core.Abstract
{
    public interface IPasswordHasher
    {
        string HashPassword(string password);
    }
}
