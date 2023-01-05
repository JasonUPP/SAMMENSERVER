using AuthJWT.Dtos.Operativo;

namespace SAMMEN.API.Services.Operativo.Interfaces
{
    public interface IMedidaHerramientaRepository
    {
        public Task<List<MedidaHerramientaDto>> GetMedidasHerramientas();
    }
}
