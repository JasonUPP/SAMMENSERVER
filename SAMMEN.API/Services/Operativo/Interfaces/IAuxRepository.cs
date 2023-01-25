using AuthJWT.Dtos;

namespace SAMMEN.API.Services.Operativo.Interfaces
{
    public interface IAuxRepository
    {
        public Task<List<JsonDto>> GetUbicaciones();
        public Task<List<JsonDto>> GetOperadores();
    }
}
