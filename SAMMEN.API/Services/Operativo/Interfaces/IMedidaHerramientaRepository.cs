using AuthJWT.Dtos;
using AuthJWT.Dtos.Operativo;

namespace SAMMEN.API.Services.Operativo.Interfaces
{
    public interface IMedidaHerramientaRepository
    {
        public Task<List<MedidaHerramientaDto>> GetMedidasHerramientas();
        public Task<ResponseDto> NewMedidaHerramienta(MedidaHerramientaDto medidaHerramientaDto);
        public Task<ResponseDto> UpdateMedidaHerramienta(MedidaHerramientaDto medidaHerramientaDto);
        public Task<ResponseDto> DeleteMedidaHerramienta(int id);
    }
}
