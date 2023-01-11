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
            var herramientas = await _herramientaRepository.GetHerramientas();
            var ubicaciones = await _auxRepository.GetUbicaciones();            
            if (herramientas == null || ubicaciones == null) return StatusCode(500);
            return Ok(new
                {
                    herramientas,
                    ubicaciones
                }
            );
        }
    }
}
