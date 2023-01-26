using AuthJWT.Dtos.Operativo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SAMMEN.API.Services.Operativo.Interfaces;

namespace SAMMEN.API.Controllers.Operativo
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class MedidaHerramientaController : ControllerBase
    {
        private readonly IMedidaHerramientaRepository _medidaHerramientaRepository;
        public MedidaHerramientaController(IMedidaHerramientaRepository medidaHerramientaRepository)
        {
            _medidaHerramientaRepository = medidaHerramientaRepository;
        }

        [HttpGet("GetMedidasHerramientas")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var medidasHerramientas = await _medidaHerramientaRepository.GetMedidasHerramientas();
                if (medidasHerramientas == null) throw new Exception("Error al obtener Medidas de Herramientas");
                return Ok(medidasHerramientas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("NewMedidaHerramienta")]
        public async Task<IActionResult> NewMedidaHerramienta([FromBody] MedidaHerramientaDto medidaHerramientaDto)
        {
            try
            {
                var res = await _medidaHerramientaRepository.NewMedidaHerramienta(medidaHerramientaDto);
                if (res == null) throw new Exception("Error al agregar Medida Herramienta");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateMedidaHerramienta")]
        public async Task<IActionResult> UpdateMedidaHerramienta([FromBody] MedidaHerramientaDto medidaHerramientaDto)
        {
            try
            {
                var res = await _medidaHerramientaRepository.UpdateMedidaHerramienta(medidaHerramientaDto);
                if (res == null) throw new Exception("Error al actualizar Medida Herramienta");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteMedidaHerramienta/{id}")]
        public async Task<IActionResult> DeleteMedidaHerramienta([FromRoute] int id)
        {
            try
            {
                var res = await _medidaHerramientaRepository.DeleteMedidaHerramienta(id);
                if (res == null) throw new Exception("Error al eliminar Medida Herramienta");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
