using AuthJWT.Dtos;
using AuthJWT.Dtos.Operativo;
using AutoMapper;
using DataBase;
using DataBase.Models.Operativo;
using Microsoft.EntityFrameworkCore;
using SAMMEN.API.Services.Operativo.Interfaces;

namespace SAMMEN.API.Services.Operativo
{
    public class HerramientaRepository : IHerramientaRepository
    {
        private readonly SAMMENContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<IHerramientaRepository> _logger;
        public HerramientaRepository(SAMMENContext context, IMapper mapper, ILogger<IHerramientaRepository> logger) 
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<List<HerramientaDto>> GetHerramientas()
        {
            try
            {
                var herramientas = await _context.Herramientas.ToListAsync();
                if (herramientas == null) return null;
                var herraientaList = new List<HerramientaDto>();
                return herramientas.ConvertAll(hr => _mapper.Map<HerramientaDto>(hr));
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "GetHerramientas", ex.Message);
                return null;
            }
            
        }

        public async Task<ResponseDto> NewHerramienta(HerramientaDto herramientaDto)
        {
            try
            {
                var herramienta = _mapper.Map<Herramienta>(herramientaDto);
                await _context.AddAsync(herramienta);
                await _context.SaveChangesAsync();
                return new ResponseDto(false, "Herramienta añadida correctamente");
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "NewHerramienta", ex.Message);
                return null;
            }
        }

        public async Task<ResponseDto> DeleteHerramienta(int id)
        {
            try
            {
                var herramienta = await _context.Herramientas.Where(w => w.Id == id).FirstOrDefaultAsync();
                if (herramienta == null) throw new Exception("Herramienta no encontrada");
                _context.Remove(herramienta);
                await _context.SaveChangesAsync();
                return new ResponseDto(false, "Herramienta eliminada correctamente");
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "DeleteHerramienta", ex.Message);
                return null;
            }
        }

        public async Task<ResponseDto> UpdateHerramienta(HerramientaDto herramientaDto)
        {
            try
            {
                var herramienta = await _context.Herramientas.AsNoTracking().Where(w => w.Id == herramientaDto.Id).FirstOrDefaultAsync();
                if (herramienta == null) throw new Exception("Herramienta no encontrada");
                var herramientaUpdated = _mapper.Map<Herramienta>(herramientaDto);
                _context.Update(herramientaUpdated);
                await _context.SaveChangesAsync();
                return new ResponseDto(false, "Herramienta actualizada correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UpdateHerramienta", ex.Message);
                return null;
            }
        }
    }
}
