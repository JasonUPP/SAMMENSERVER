using AuthJWT.Dtos.Operativo;
using AuthJWT.Dtos;

namespace SAMMEN.API.Services.Operativo.Interfaces
{
    public interface IHistorialHerramienta
    {
        public Task<List<HistorialHerramientaDto>> GetHistorialHerramienta();
        public Task<ResponseDto> AddHistorialHerramienta(HistorialHerramientaDto historialHerramientaDto);
        public Task<ResponseDto> DeleteHistorialHerramienta(int id);
        public Task<ResponseDto> UpdateHistorialHerramienta(HistorialHerramientaDto historialHerramientaDto);

    }
}
