using AuthJWT.Dtos.Operativo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SAMMEN.API.Services.Operativo.Interfaces;

namespace SAMMEN.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class HistorialHerramientaController : ControllerBase
    {
        private readonly IHistorialHerramienta _historialRepository;
        private readonly IAuxRepository _auxRepository;
        public HistorialHerramientaController(IHistorialHerramienta historialRepository, IAuxRepository auxRepository)
        {
            _historialRepository = historialRepository;
            _auxRepository = auxRepository;
        }

        [HttpGet("GetHistorialHerramienta")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var herramientas = await _historialRepository.GetHistorialHerramienta();
                if (herramientas == null) throw new Exception("Error al obtener Historial Herramienta");
                return Ok(new { herramientas });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddHistorialHerramienta")]
        public async Task<IActionResult> AddHistorialHerramienta([FromBody] HistorialHerramientaDto historialHDto)
        {
            try
            {
                var res = await _historialRepository.AddHistorialHerramienta(historialHDto);
                if (res == null) throw new Exception("Error al agregar Historial Herramienta");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteHistorialHerramienta/{id}")]
        public async Task<IActionResult> DeleteHistorialHerramienta([FromRoute] int Id)
        {
            try
            {
                var res = await _historialRepository.DeleteHistorialHerramienta(Id);
                if (res == null) throw new Exception("Error al eliminar Historial Herramienta");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateHistorialHerramienta")]
        public async Task<IActionResult> UpdateHistorialHerramienta([FromBody] HistorialHerramientaDto historialHerramientaDto)
        {
            try
            {
                var res = await _historialRepository.UpdateHistorialHerramienta(historialHerramientaDto);
                if (res == null) throw new Exception("Error al actualizar Historial Herramienta");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
