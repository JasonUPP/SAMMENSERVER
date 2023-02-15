using AuthJWT.Dtos.Operativo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SAMMEN.API.Services.Operativo;
using SAMMEN.API.Services.Operativo.Interfaces;

namespace SAMMEN.API.Controllers.Operativo
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CursosController : ControllerBase
    {
        private readonly ICursosRepository _cursosRepository;

        public CursosController(ICursosRepository cursosRepository)
        {
            _cursosRepository = cursosRepository;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var cursos = await _cursosRepository.GetCursos();
                if (cursos == null) throw new Exception("Error al obtener Cursos");
                return Ok(cursos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetRelacion")]
        public async Task<IActionResult> GetRelaciones()
        {
            try
            {
                var relaciones = await _cursosRepository.GetOperadorCursoRelation();
                if (relaciones == null) throw new Exception("Error al obtener relaciones");
                return Ok(relaciones);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetCursosPorOperador/{id}")]
        public async Task<IActionResult> CursosPorOperador([FromRoute] int id)
        {
            try
            {
                var cursosPoroperador = await _cursosRepository.GetCursosByOperador(id);
                if (cursosPoroperador == null) throw new Exception("Error al obtener cursos por operador");
                return Ok(cursosPoroperador);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("NewCursosPorOperador")]
        public async Task<IActionResult> NewCursosPorOperador([FromBody] NewCursosDto body)
        {
            try
            {
                var res = await _cursosRepository.NewCursosPorOperador(body);
                if (res == null) throw new Exception("Error al agregar cursos");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
