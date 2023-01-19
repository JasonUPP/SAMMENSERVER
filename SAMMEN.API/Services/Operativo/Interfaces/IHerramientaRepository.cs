using AuthJWT.Dtos;
using AuthJWT.Dtos.Operativo;

namespace SAMMEN.API.Services.Operativo.Interfaces
{
    public interface IHerramientaRepository
    {
        public Task<List<HerramientaDto>> GetHerramientas();
        public Task<ResponseDto> NewHerramienta(HerramientaDto herramientaDto);
        public Task<ResponseDto> DeleteHerramienta(int id);
        public Task<ResponseDto> UpdateHerramienta(HerramientaDto herramientaDto);
    }
}
