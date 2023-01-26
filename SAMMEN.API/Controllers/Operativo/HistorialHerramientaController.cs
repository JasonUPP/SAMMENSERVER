using AuthJWT.Dtos.Operativo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SAMMEN.API.Services.Operativo.Interfaces;

namespace SAMMEN.API.Controllers.Operativo
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

        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var historialHerramientas = await _historialRepository.Get();
                var operadores = await _auxRepository.GetOperadores();
                if (historialHerramientas == null) throw new Exception("Error al obtener Historial Herramienta");
                return Ok(new { historialHerramientas, operadores });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] HistorialHerramientaDto historialHDto)
        {
            try
            {
                var res = await _historialRepository.Add(historialHDto);
                if (res == null) throw new Exception("Error al agregar Historial Herramienta");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute] int Id)
        {
            try
            {
                var res = await _historialRepository.Delete(Id);
                if (res == null) throw new Exception("Error al eliminar Historial Herramienta");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] HistorialHerramientaDto historialHerramientaDto)
        {
            try
            {
                var res = await _historialRepository.Update(historialHerramientaDto);
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
