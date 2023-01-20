using AuthJWT.Dtos;
using AuthJWT.Dtos.Operativo;
using AutoMapper;
using DataBase;
using DataBase.Models.Operativo;
using Microsoft.EntityFrameworkCore;
using SAMMEN.API.Services.Operativo.Interfaces;

namespace SAMMEN.API.Services.Operativo
{
    public class MedidaHerramientaRepository : IMedidaHerramientaRepository
    {
        private readonly SAMMENContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<IMedidaHerramientaRepository> _logger;

        public MedidaHerramientaRepository(SAMMENContext context, IMapper mapper, ILogger<IMedidaHerramientaRepository> logger) 
        {
            _context= context;
            _mapper= mapper;
            _logger= logger;
        }


        public async Task<List<MedidaHerramientaDto>> GetMedidasHerramientas()
        {
            try
            {
                var medidasHerramientas = await _context.MedidaHerramientas.ToListAsync();
                if (medidasHerramientas == null) throw new Exception("Error al obtener medidas de herramientas");
                return medidasHerramientas.ConvertAll(mhr => _mapper.Map<MedidaHerramientaDto>(mhr));
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "GetMedidasHerramientas", ex.Message);
                return null;
            }
            //var medidasHerramientasList = new List<MedidaHerramientaDto>();
            //medidasHerramientas.ForEach(
            //    medidaHerramienta => medidasHerramientasList.Add(
            //        _mapper.Map<MedidaHerramientaDto>(medidaHerramienta)));
            //return medidasHerramientasList;            
        }
        public async Task<ResponseDto> DeleteMedidaHerramienta(int id)
        {
            try
            {
                var medidaHerramienta = await _context.MedidaHerramientas.AsNoTracking().Where(w => w.Id == id).FirstOrDefaultAsync();
                if (medidaHerramienta == null) throw new Exception("Medida Herramienta no encontrada");
                _context.Remove(medidaHerramienta);
                await _context.SaveChangesAsync();
                return new ResponseDto(false, "Medida Herramienta eliminada correctamente");

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "DeleteMedidaHerramienta", ex.Message);
                return null;
            }            
        }

        public async Task<ResponseDto> NewMedidaHerramienta(MedidaHerramientaDto medidaHerramientaDto)
        {
            try
            {
                var medidaHerramienta = _mapper.Map<MedidaHerramienta>(medidaHerramientaDto);
                await _context.AddAsync(medidaHerramienta);
                await _context.SaveChangesAsync();
                return new ResponseDto(false, "Medida Herramienta añadida correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "NewMedidaHerramienta", ex.Message);
                return null;
            }            
        }

        public async Task<ResponseDto> UpdateMedidaHerramienta(MedidaHerramientaDto medidaHerramientaDto)
        {
            try
            {
                var medidaHerramienta = await _context.MedidaHerramientas.AsNoTracking().Where(w => w.Id == medidaHerramientaDto.Id).FirstOrDefaultAsync();
                if (medidaHerramienta == null) throw new Exception("Medida Herramienta no encontrada");
                var mhupdated = _mapper.Map<MedidaHerramienta>(medidaHerramientaDto);
                _context.Update(mhupdated);
                await _context.SaveChangesAsync();
                return new ResponseDto(false, "Medida Herramienta actualizada correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UpdateMedidaHerramienta", ex.Message);
                return null;
            }            
        }
    }
}
