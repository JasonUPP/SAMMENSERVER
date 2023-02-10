using AuthJWT.Dtos.Operativo;
using DataBase;
using DataBase.Models.Operativo;
using Microsoft.EntityFrameworkCore;
using SAMMEN.API.Services.Operativo.Interfaces;

namespace SAMMEN.API.Services.Operativo
{
    public class CursosRepository : ICursosRepository
    {
        private readonly SAMMENContext _context;
        private readonly ILogger<IAuxRepository> _logger;

        public CursosRepository (SAMMENContext context, ILogger<IAuxRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<List<Cursos>> GetCursos()
        {
            try
            {
                var cursos = await _context.Cursos.ToListAsync();
                if (cursos == null) throw new Exception("Cursos no encontrados");
                return cursos;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetCursos", ex.Message);
                return null;
            }
        }

        public async Task<List<OperadorCurso>> GetOperadorCursoRelation()
        {
            try
            {
                var operCurso = await _context.OperadorCursos.ToListAsync();
                if (operCurso == null) throw new Exception("Relacion Operador Curso no encontrada");
                return operCurso;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetOperadorCursoRelation", ex.Message);
                return null;
            }
        }

        public async Task<List<CursosDto>> GetCursosByOperador(int operadorId)
        {
            try
            {
                var cursos = await _context.Cursos.ToListAsync();
                if (cursos == null) throw new Exception("Cursos no encontrados");
                var operCurso = await _context.OperadorCursos.ToListAsync();
                if (operCurso == null) throw new Exception("Relacion Operador Curso no encontrada");
                var cursosDtoList = new List<CursosDto>();
                if(operCurso.Count == 0) return cursosDtoList;                
                var operCursoFiltered = operCurso.Where(w => w.IdOperador == operadorId);//VER QUE HACER CUANDO NO HAY NADA

                cursos.ForEach(curso =>
                {
                    OperadorCurso operCursoActual = operCursoFiltered.Where(w => w.IdCurso == curso.Id).FirstOrDefault();
                    DateTime vigenciaCurso = operCursoActual.Vigencia;
                    int estatus = operCursoActual.Estatus;

                    var cursoDto = new CursosDto()
                    {
                        Item = curso.Item,
                        Nombre = curso.Nombre,
                        Requerido = curso.Requerido,
                        Vigencia = vigenciaCurso,
                        Estatus = estatus
                    };

                    cursosDtoList.Add(cursoDto);
                });
                return cursosDtoList;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetCursosByOperador", ex.Message);
                return null;
            }
        }
    }
}
