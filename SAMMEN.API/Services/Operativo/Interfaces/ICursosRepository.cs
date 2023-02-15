using AuthJWT.Dtos;
using AuthJWT.Dtos.Operativo;
using DataBase.Models.Operativo;

namespace SAMMEN.API.Services.Operativo.Interfaces
{
    public interface ICursosRepository
    {
        public Task<List<Cursos>> GetCursos();
        public Task<List<OperadorCurso>> GetOperadorCursoRelation();
        public Task<List<CursosDto>> GetCursosByOperador(int operadorId);
        public Task<ResponseDto> NewCursosPorOperador(NewCursosDto body);
    }
}
