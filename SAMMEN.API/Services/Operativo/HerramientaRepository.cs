using AuthJWT.Dtos;
using AuthJWT.Dtos.Operativo;
using AutoMapper;
using DataBase;
using Microsoft.EntityFrameworkCore;
using SAMMEN.API.Services.Operativo.Interfaces;

namespace SAMMEN.API.Services.Operativo
{
    public class HerramientaRepository : IHerramientaRepository
    {
        private readonly SAMMENContext _context;
        private readonly IMapper _mapper;
        public HerramientaRepository(SAMMENContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<HerramientaDto>> GetHerramientas()
        {
            var herramientas = await _context.Herramientas.ToListAsync();
            if (herramientas == null) return null;
            var herraientaList = new List<HerramientaDto>();
            return herramientas.ConvertAll(hr => _mapper.Map<HerramientaDto>(hr));
        }
    }
}
