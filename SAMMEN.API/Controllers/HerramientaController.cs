﻿using AuthJWT.Dtos.Operativo;
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

        [HttpPost("NewHerramienta")]
        public async Task<IActionResult> NewHerramienta([FromBody] HerramientaDto herramientaDto)
        {
            var x = await _herramientaRepository.NewHerramienta(herramientaDto);
            return Ok();
        }

        [HttpDelete("DeleteHerramienta/{id}")]
        public async Task<IActionResult> DeleteHerramienta([FromBody] int Id)
        {
            var x = await _herramientaRepository.DeleteHerramienta(Id);
            return Ok();
        }

        [HttpPut("UpdateHerramienta/{data}")]
        public async Task<IActionResult> UpdateHerramienta([FromBody] HerramientaDto herramientaDto)
        {
            var x = await _herramientaRepository.UpdateHerramienta(herramientaDto);
            return Ok();
        }

    }
}
