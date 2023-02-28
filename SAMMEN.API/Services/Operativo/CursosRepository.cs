using AuthJWT.Dtos;
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

                var relaciones = await _context.OperadorCursos.ToListAsync();
                if (relaciones == null) throw new Exception("Relacion Operador Curso no encontrada");

                var cursosDtoList = new List<CursosDto>();
                if(relaciones.Count == 0) return cursosDtoList;                
                var operCursoFiltered = relaciones.Where(w => w.IdOperador == operadorId).ToList();
                if (operCursoFiltered.Count() == 0) return cursosDtoList;

                var cursos = await _context.Cursos.ToListAsync();
                if (cursos == null) throw new Exception("Cursos no encontrados");
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

        public async Task<ResponseDto> NewCursosPorOperador(BodyCursosDto body)
        {
            try
            {
                var relacionList = new List<OperadorCurso>();
                body.CursosDtos.ForEach(curso =>
                {
                    var relacion = new OperadorCurso()
                    {
                        IdOperador = body.IdOperador,
                        IdCurso = curso.Item,
                        Vigencia= curso.Vigencia,
                        Estatus= curso.Estatus,
                    };
                    relacionList.Add(relacion);
                });

                await _context.AddRangeAsync(relacionList);
                await _context.SaveChangesAsync();
                return new ResponseDto(false, "Cursos añadidos correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "NewCursosPorOperador", ex.Message);
                return null;
            }
        }

        public async Task<ResponseDto> UpdateCursosPorOperador(BodyCursosDto body)
        {
            try
            {
                var relaciones = await _context.OperadorCursos.ToListAsync();
                if (relaciones == null) throw new Exception("Relaciones Operador curso no encontradas");
                var relacionesFiltered = relaciones.Where(w => w.IdOperador == body.IdOperador).ToList();
                if (relacionesFiltered.Count == 0) throw new Exception("Este operador no cuenta con nigun curso actualmente");
                
                var relacionesUpdatedList = new List<OperadorCurso>();

                body.CursosDtos.ForEach(curso =>
                {
                    var relacion = relacionesFiltered.FirstOrDefault(f=> f.IdCurso == curso.Item);
                    relacion.Vigencia = curso.Vigencia;
                    relacion.Estatus = curso.Estatus;
                    relacionesUpdatedList.Add(relacion);
                });

                _context.UpdateRange(relacionesUpdatedList);
                await _context.SaveChangesAsync();
                return new ResponseDto(false, "Cursos actualizados correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UpdateCursosPorOperador", ex.Message);
                return null;
            }
        }

    }
}
