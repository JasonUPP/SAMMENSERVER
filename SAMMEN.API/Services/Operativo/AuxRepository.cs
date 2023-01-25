using AuthJWT.Dtos;
using AutoMapper;
using DataBase;
using Microsoft.EntityFrameworkCore;
using SAMMEN.API.Services.Operativo.Interfaces;

namespace SAMMEN.API.Services.Operativo
{
    public class AuxRepository : IAuxRepository
    {
        private readonly SAMMENContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<IAuxRepository> _logger;

        public AuxRepository (SAMMENContext context, IMapper mapper, ILogger<IAuxRepository> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<List<JsonDto>> GetUbicaciones()
        {
            try
            {
                var ubicaciones = await _context.Ubicaciones.ToListAsync();           
                if (ubicaciones == null) throw new Exception("Ubicaciones no encontradas");
                return ubicaciones.ConvertAll(ubicacion => _mapper.Map<JsonDto>(ubicacion));
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "GetUbicaciones", ex.Message);
                return null;
            }
        }
        public async Task<List<JsonDto>> GetOperadores()
        {
            try
            {
                var operadores = await _context.Operadores.ToListAsync();
                if (operadores == null) throw new Exception("Operadores no encontrados");
                return operadores.ConvertAll(operador => _mapper.Map<JsonDto>(operador));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetOperadores", ex.Message);
                return null;
            }
        }
    }
}
