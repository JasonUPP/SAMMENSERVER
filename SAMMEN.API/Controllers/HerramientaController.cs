using AuthJWT.Dtos.Operativo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SAMMEN.API.Services.Operativo.Interfaces;

namespace SAMMEN.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class HerramientaController : ControllerBase
    {
        private readonly IHerramientaRepository _herramientaRepository;
        private readonly IAuxRepository _auxRepository;
        public HerramientaController(IHerramientaRepository herramientaRepository, IAuxRepository auxRepository) 
        {
            _herramientaRepository= herramientaRepository;
            _auxRepository= auxRepository;
        }

        [HttpGet("GetHerramientas")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var herramientas = await _herramientaRepository.GetHerramientas();
                var ubicaciones = await _auxRepository.GetUbicaciones();            
                if (herramientas == null || ubicaciones == null) throw new Exception("Error al obtener Herramientas");
                return Ok(new { herramientas, ubicaciones });
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("NewHerramienta")]
        public async Task<IActionResult> NewHerramienta([FromBody] HerramientaDto herramientaDto)
        {
            try
            {
                var res = await _herramientaRepository.NewHerramienta(herramientaDto);
                if (res == null) throw new Exception("Error al agregar Herramienta");
                return Ok(res);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteHerramienta/{id}")]
        public async Task<IActionResult> DeleteHerramienta([FromRoute] int Id)
        {
            try
            {
                var res = await _herramientaRepository.DeleteHerramienta(Id);
                if (res == null) throw new Exception("Error al eliminar Herramienta");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateHerramienta")]
        public async Task<IActionResult> UpdateHerramienta([FromBody] HerramientaDto herramientaDto)
        {
            try
            {
                var res = await _herramientaRepository.UpdateHerramienta(herramientaDto);
                if (res == null) throw new Exception("Error al actualizar Herramienta");                
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
