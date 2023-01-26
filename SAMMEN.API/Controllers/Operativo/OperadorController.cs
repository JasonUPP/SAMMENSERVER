using AuthJWT.Dtos.Operativo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SAMMEN.API.Services.Operativo.Interfaces;

namespace SAMMEN.API.Controllers.Operativo
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class OperadorController : ControllerBase
    {
        private readonly IOperador _operadorRepository;

        public OperadorController(IOperador operadorRepository)
        {
            _operadorRepository= operadorRepository;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var operadores = await _operadorRepository.Get();
                if (operadores == null) throw new Exception("Error al obtener Operadores");
                return Ok(operadores);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("New")]
        public async Task<IActionResult> New([FromBody] OperadorDto objDto)
        {
            try
            {
                var res = await _operadorRepository.New(objDto);
                if (res == null) throw new Exception("Error al agregar Operador");
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
                var res = await _operadorRepository.Delete(Id);
                if (res == null) throw new Exception("Error al eliminar Operador");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] OperadorDto objDto)
        {
            try
            {
                var res = await _operadorRepository.Update(objDto);
                if (res == null) throw new Exception("Error al actualizar Operador");
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
