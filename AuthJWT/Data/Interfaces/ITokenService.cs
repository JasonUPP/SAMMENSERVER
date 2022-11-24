using SAMMEN.DataBase.Models;

namespace AuthJWT.Data.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
