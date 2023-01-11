using AuthJWT.Dtos.Operativo;

namespace SAMMEN.API.Services.Operativo.Interfaces
{
    public interface IHerramientaRepository
    {
        public Task<List<HerramientaDto>> GetHerramientas();
    }
}
