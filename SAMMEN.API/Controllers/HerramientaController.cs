using Microsoft.AspNetCore.Mvc;
using SAMMEN.API.Services.Operativo.Interfaces;

namespace SAMMEN.API.Controllers
{        
    [Route("api/[controller]")]
    [ApiController]
    public class HerramientaController : ControllerBase
    {
        private readonly IHerramientaRepository _herramientaRepository;
        public HerramientaController(IHerramientaRepository herramientaRepository) 
        {
            _herramientaRepository= herramientaRepository;
        }

        [HttpGet("GetHerramientas")]
        public async Task<IActionResult> Get()
        {
            var herramientas = await _herramientaRepository.GetHerramientas();
            if (herramientas == null) return StatusCode(500);
            return Ok(herramientas);
        }
    }
}
