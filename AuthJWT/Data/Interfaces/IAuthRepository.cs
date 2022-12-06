using SAMMEN.DataBase.Models;

namespace AuthJWT.Data.Interfaces
{
    public interface IAuthRepository
    {
        Task<User> SignUp(User user, string password);
        Task<User> Login(string email, string password);
        Task<bool> UserExist(string email);
    }
}
