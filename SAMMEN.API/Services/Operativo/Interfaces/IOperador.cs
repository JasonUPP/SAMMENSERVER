using AuthJWT.Dtos.Operativo;
using AuthJWT.Dtos;

namespace SAMMEN.API.Services.Operativo.Interfaces
{
    public interface IOperador
    {
        public Task<List<OperadorDto>> Get();
        public Task<ResponseDto> New(OperadorDto OperadorDto);
        public Task<ResponseDto> Delete(int id);
        public Task<ResponseDto> Update(OperadorDto OperadorDto);
    }
}
