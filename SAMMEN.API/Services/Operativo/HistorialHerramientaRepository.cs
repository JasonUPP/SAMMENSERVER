using AuthJWT.Dtos;
using AuthJWT.Dtos.Operativo;
using AutoMapper;
using DataBase;
using DataBase.Models.Operativo;
using Microsoft.EntityFrameworkCore;
using SAMMEN.API.Services.Operativo.Interfaces;

namespace SAMMEN.API.Services.Operativo
{
    public class HistorialHerramientaRepository : IHistorialHerramienta
    {
        private readonly SAMMENContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<IHistorialHerramienta> _logger;

        public HistorialHerramientaRepository(SAMMENContext context, IMapper mapper, ILogger<IHistorialHerramienta> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<List<HistorialHerramientaDto>> Get()
        {
            try
            {
                var historialH = await _context.HistorialHerramientas.ToListAsync();
                if (historialH == null) throw new Exception("Error al obtener Historial de Herramienta");
                return historialH.ConvertAll(histH => _mapper.Map<HistorialHerramientaDto>(histH));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetHistorialHerramienta", ex.Message);
                return null;
            }
        }

        public async Task<ResponseDto> Add(HistorialHerramientaDto historialHDto)
        {
            try
            {
                var historialH = _mapper.Map<HistorialHerramienta>(historialHDto);
                await _context.AddAsync(historialH);
                await _context.SaveChangesAsync();
                return new ResponseDto(false, "Historial Herramienta añadido correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "AddHistorialHerramienta", ex.Message);
                return null;
            }
        }

        public async Task<ResponseDto> Delete(int id)
        {
            try
            {
                var historialH = await _context.HistorialHerramientas.Where(w => w.Id == id).FirstOrDefaultAsync();
                if (historialH == null) throw new Exception("Historial Herramienta no encontrado");
                _context.Remove(historialH);
                await _context.SaveChangesAsync();
                return new ResponseDto(false, "Historial Herramienta eliminado correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "DeleteHistorialHerramienta", ex.Message);
                return null;
            }
        }

        public async Task<ResponseDto> Update(HistorialHerramientaDto historialHerramientaDto)
        {
            try
            {
                var historialH = await _context.HistorialHerramientas.AsNoTracking().Where(w => w.Id == historialHerramientaDto.Id).FirstOrDefaultAsync();
                if (historialH == null) throw new Exception("Historial Herramienta no encontrado");
                var historialUpdated = _mapper.Map<HistorialHerramienta>(historialHerramientaDto);
                _context.Update(historialUpdated);
                await _context.SaveChangesAsync();
                return new ResponseDto(false, "Historial Herramienta actualizado correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UpdateHistorialHerramienta", ex.Message);
                return null;
            }
        }
    }
}
