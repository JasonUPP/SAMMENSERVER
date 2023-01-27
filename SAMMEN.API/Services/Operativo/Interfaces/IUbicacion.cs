using AuthJWT.Dtos.Operativo;
using AuthJWT.Dtos;

namespace SAMMEN.API.Services.Operativo.Interfaces
{
    public interface IUbicacion
    {
        public Task<List<UbicacionDto>> Get();
        public Task<ResponseDto> New(UbicacionDto UbicacionDto);
        public Task<ResponseDto> Delete(int id);
        public Task<ResponseDto> Update(UbicacionDto UbicacionDto);
    }
}
