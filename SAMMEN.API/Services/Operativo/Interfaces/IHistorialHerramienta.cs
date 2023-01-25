using AuthJWT.Dtos.Operativo;
using AuthJWT.Dtos;

namespace SAMMEN.API.Services.Operativo.Interfaces
{
    public interface IHistorialHerramienta
    {
        public Task<List<HistorialHerramientaDto>> Get();
        public Task<ResponseDto> Add(HistorialHerramientaDto historialHerramientaDto);
        public Task<ResponseDto> Delete(int id);
        public Task<ResponseDto> Update(HistorialHerramientaDto historialHerramientaDto);

    }
}
