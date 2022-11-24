using SAMMEN.DataBase.Models;

namespace AuthJWT.Data.Interfaces
{
    public interface IAuthRepository
    {
        Task<User> SignUp(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExist(string username);
    }
}
