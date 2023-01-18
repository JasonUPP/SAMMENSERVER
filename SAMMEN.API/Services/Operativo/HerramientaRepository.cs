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

        public async Task<object> NewHerramienta(HerramientaDto herramientaDto)//cambiar el tipo de task
        {
            try
            {
                var herramienta = _mapper.Map<Herramienta>(herramientaDto);
                await _context.AddAsync(herramienta);
                await _context.SaveChangesAsync();
                //saber que regresar si todo sale bien y cuando no
            }
            catch(Exception ex)
            {
                var x = ex.InnerException;
            }
            return null;
        }

        public async Task<object> DeleteHerramienta(int id)
        {
            try
            {
                var herramienta = await _context.Herramientas.Where(w => w.Id == id).FirstOrDefaultAsync();
                if (herramienta == null) throw new Exception("Herramienta no encontrada");
                _context.Remove(herramienta);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {

            }
            return null;
        }

        public async Task<object> UpdateHerramienta(HerramientaDto herramientaDto)
        {
            try
            {
                var herramienta = await _context.Herramientas.Where(w => w.Id == herramientaDto.Id).FirstOrDefaultAsync();
                if (herramienta == null) throw new Exception("Herramienta no encontrada");
                //falta mapear de dto a herramienta
                _context.Update(herramienta);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

            }
            return null;
        }
    }
}
