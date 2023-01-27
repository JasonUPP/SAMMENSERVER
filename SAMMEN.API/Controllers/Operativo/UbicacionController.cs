using AuthJWT.Dtos.Operativo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SAMMEN.API.Services.Operativo.Interfaces;

namespace SAMMEN.API.Controllers.Operativo
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UbicacionController : ControllerBase
    {
        private readonly IUbicacion _ubicacionRepository;

        public UbicacionController(IUbicacion ubicacionrepository) 
        {
            _ubicacionRepository = ubicacionrepository;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var operadores = await _ubicacionRepository.Get();
                if (operadores == null) throw new Exception("Error al obtener Ubicaciones");
                return Ok(operadores);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("New")]
        public async Task<IActionResult> New([FromBody] UbicacionDto objDto)
        {
            try
            {
                var res = await _ubicacionRepository.New(objDto);
                if (res == null) throw new Exception("Error al agregar Ubicacion");
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
                var res = await _ubicacionRepository.Delete(Id);
                if (res == null) throw new Exception("Error al eliminar Ubicacion");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UbicacionDto objDto)
        {
            try
            {
                var res = await _ubicacionRepository.Update(objDto);
                if (res == null) throw new Exception("Error al actualizar Ubicacion");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
