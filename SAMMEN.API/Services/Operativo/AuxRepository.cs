using AuthJWT.Dtos;
using AutoMapper;
using DataBase;
using DataBase.Models.Operativo;
using Microsoft.EntityFrameworkCore;
using SAMMEN.API.Services.Operativo.Interfaces;

namespace SAMMEN.API.Services.Operativo
{
    public class AuxRepository : IAuxRepository
    {
        private readonly SAMMENContext _context;
        private readonly IMapper _mapper;

        public AuxRepository (SAMMENContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<JsonDto>> GetUbicaciones()
        {
            var ubicaciones = await _context.Ubicaciones.ToListAsync();           
            if (ubicaciones == null) return null;
            return ubicaciones.ConvertAll(ubicacion => _mapper.Map<JsonDto>(ubicacion));          
        }
    }
}
