using DataBase.Models.Operativo;

namespace AuthJWT.Data.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
