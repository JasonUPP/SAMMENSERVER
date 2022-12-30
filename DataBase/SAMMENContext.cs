using DataBase.Models.Operativo;
using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    public class SAMMENContext : DbContext
    {
        public SAMMENContext(DbContextOptions<SAMMENContext> options) : base(options) {}
        public DbSet<User> Users { get; set; }
        public DbSet<Herramienta> Herramientas { get; set; }
        DbSet<MedidaHerramienta> MedidaHerramientas{ get; set; }        
        DbSet<HistorialHerramienta> HistorialHerramientas { get; set; }
        DbSet<Cursos> Cursos { get; set; }
        DbSet<Operador> Operadores { get; set; }
        DbSet<Ubicacion> Ubicaciones { get; set; }
        DbSet<MedidaHerramientaEspecial> MedidaHerramientaEspecials { get; set; }
    }
}