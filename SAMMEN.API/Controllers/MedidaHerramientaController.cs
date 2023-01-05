using Microsoft.AspNetCore.Mvc;

namespace SAMMEN.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedidaHerramientaController : ControllerBase
    {
        public MedidaHerramientaController() { }

        [HttpGet("GetMedidasHerramientas")]
        public async Task<IActionResult> Get()
        {
            return StatusCode(500);
        }
    }
}
