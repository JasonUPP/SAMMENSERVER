using DataBase;
using DataBase.Models.Operativo;
using Microsoft.EntityFrameworkCore;
using SAMMEN.API.Services.Operativo.Interfaces;

namespace SAMMEN.API.Services.Operativo
{
    public class HerramientaRepository : IHerramientaRepository
    {
        private readonly SAMMENContext _context;
        public HerramientaRepository(SAMMENContext context) 
        {
            _context = context;
        }
        public async Task<List<Herramienta>> GetHerramientas()
        {
            var herramientas = await _context.Herramientas.ToListAsync();           
            if (herramientas == null) return null;
            return herramientas;
        }
    }
}
