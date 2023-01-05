using AuthJWT.Dtos.Operativo;
using AutoMapper;
using DataBase;
using Microsoft.EntityFrameworkCore;
using SAMMEN.API.Services.Operativo.Interfaces;

namespace SAMMEN.API.Services.Operativo
{
    public class MedidaHerramientaRepository : IMedidaHerramientaRepository
    {
        private readonly SAMMENContext _context;
        private readonly IMapper _mapper;

        public MedidaHerramientaRepository(SAMMENContext context, IMapper mapper) 
        {
            _context= context;
            _mapper= mapper;
        }
        public async Task<List<MedidaHerramientaDto>> GetMedidasHerramientas()
        {
            var medidasHerramientasc = await _context.MedidaHerramientas.ToListAsync();
            if (medidasHerramientasc == null) return null;
            var medidasHerramientasList = new List<MedidaHerramientaDto>();
            medidasHerramientasc.ForEach(
                medidaHerramienta => medidasHerramientasList.Add(
                    _mapper.Map<MedidaHerramientaDto>(medidaHerramienta)));
            return medidasHerramientasList;            
        }
    }
}
