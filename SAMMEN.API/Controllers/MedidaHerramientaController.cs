using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SAMMEN.API.Services.Operativo.Interfaces;

namespace SAMMEN.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class MedidaHerramientaController : ControllerBase
    {
        private readonly IMedidaHerramientaRepository _medidaHerramientaRepository;
        public MedidaHerramientaController(IMedidaHerramientaRepository medidaHerramientaRepository) 
        {
            _medidaHerramientaRepository= medidaHerramientaRepository;
        }

        [HttpGet("GetMedidasHerramientas")]
        public async Task<IActionResult> Get()
        {
            var medidasHerramientas = await _medidaHerramientaRepository.GetMedidasHerramientas();
            if(medidasHerramientas == null) return StatusCode(500);
            return Ok(medidasHerramientas);
        }
    }
}
