using AuthJWT.Dtos;
using AuthJWT.Dtos.Operativo;
using AutoMapper;
using DataBase;
using DataBase.Models.Operativo;
using Microsoft.EntityFrameworkCore;
using SAMMEN.API.Services.Operativo.Interfaces;

namespace SAMMEN.API.Services.Operativo
{
    public class UbicacionRepository : IUbicacion
    {
        private readonly SAMMENContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<IUbicacion> _logger;

        public UbicacionRepository(SAMMENContext context, IMapper mapper, ILogger<IUbicacion> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ResponseDto> Delete(int id)
        {
            try
            {
                var ubicacion = await _context.Ubicaciones.FirstOrDefaultAsync(op => op.Id == id);
                if (ubicacion == null) throw new Exception("Ubicacion no encontrada");
                _context.Remove(ubicacion);
                await _context.SaveChangesAsync();
                return new ResponseDto(false, "Ubicacion eliminada correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Delete Ubicacion", ex.Message);
                return null;
            }
        }

        public async Task<List<UbicacionDto>> Get()
        {
            try
            {
                var ubicaciones = await _context.Ubicaciones.ToListAsync();
                if (ubicaciones == null) throw new Exception("Error al obtener Ubicaciones");
                return ubicaciones.ConvertAll(op => _mapper.Map<UbicacionDto>(op));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Get Ubicacion", ex.Message);
                return null;
            }
        }

        public async Task<ResponseDto> New(UbicacionDto UbicacionDto)
        {
            try
            {
                var ubicacion = _mapper.Map<Ubicacion>(UbicacionDto);
                await _context.AddAsync(ubicacion);
                await _context.SaveChangesAsync();
                return new ResponseDto(false, "Ubicacion añadida correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "New Ubicacion", ex.Message);
                return null;
            }
        }

        public async Task<ResponseDto> Update(UbicacionDto UbicacionDto)
        {
            try
            {
                var ubicacion = await _context.Ubicaciones.AsNoTracking().FirstOrDefaultAsync(op => op.Id == UbicacionDto.Id);
                if (ubicacion == null) throw new Exception("Ubicacion no encontrada");
                var ubicacionUpdated = _mapper.Map<Ubicacion>(UbicacionDto);
                _context.Update(ubicacionUpdated);
                await _context.SaveChangesAsync();
                return new ResponseDto(false, "Ubicacion actualizada correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Update Ubicacion", ex.Message);
                return null;
            }
        }
    }
}
