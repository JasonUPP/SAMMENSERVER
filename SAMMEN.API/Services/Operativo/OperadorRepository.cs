using AuthJWT.Dtos;
using AuthJWT.Dtos.Operativo;
using AutoMapper;
using DataBase;
using DataBase.Models.Operativo;
using Microsoft.EntityFrameworkCore;
using SAMMEN.API.Services.Operativo.Interfaces;

namespace SAMMEN.API.Services.Operativo
{
    public class OperadorRepository : IOperador 
    {
        private readonly SAMMENContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<IHistorialHerramienta> _logger;

        public OperadorRepository(SAMMENContext context, IMapper mapper, ILogger<IHistorialHerramienta> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<List<OperadorDto>> Get()
        {
            try
            {
                var operadores = await _context.Operadores.ToListAsync();
                if(operadores == null) throw new Exception("Error al obtener Operadores");
                return operadores.ConvertAll(op => _mapper.Map<OperadorDto>(op));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Get Operador", ex.Message);
                return null;
            }
        }
        public async Task<ResponseDto> New(OperadorDto OperadorDto)
        {
            try
            {
                var operador = _mapper.Map<Operador>(OperadorDto);
                await _context.AddAsync(operador);
                await _context.SaveChangesAsync();
                return new ResponseDto(false, "Operador añadido correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Add Operador", ex.Message);
                return null;
            }            
        }

        public async Task<ResponseDto> Delete(int id)
        {
            try
            {
                var operador = await _context.Operadores.FirstOrDefaultAsync(op => op.Id == id);
                if (operador == null) throw new Exception("Operador no encontrado");
                _context.Remove(operador);
                await _context.SaveChangesAsync();
                return new ResponseDto(false, "Operador eliminado correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Delete Operador", ex.Message);
                return null;
            }            
        }


        public async Task<ResponseDto> Update(OperadorDto OperadorDto)
        {
            try
            {
                var operador = await _context.Operadores.AsNoTracking().FirstOrDefaultAsync(op => op.Id == OperadorDto.Id);
                if (operador == null) throw new Exception("Operador no encontrado");
                var operadorUpdated = _mapper.Map<Operador>(OperadorDto);
                _context.Update(operadorUpdated);
                await _context.SaveChangesAsync();
                return new ResponseDto(false, "Operador actualizado correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Update Operador", ex.Message);
                return null;
            }
        }

        public async Task<ResponseDto> UpdateEstatus(OperadorEstatusDto operadorEstatusDto)
        {
            try
            {
                var operador = await _context.Operadores.AsNoTracking().FirstOrDefaultAsync(op => op.Id == operadorEstatusDto.IdOperador);
                if (operador == null) throw new Exception("Operador no encontrado");
                operador.Estatus = operadorEstatusDto.Estatus;
                _context.Update(operador);
                await _context.SaveChangesAsync();
                return new ResponseDto(false, "Estatus de operador actualizado correctamente");
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "UpdateEstatus", ex.Message);
                return null;
            }
        }
    }
}
