using DataBase.Models.Operativo;
using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    public class SAMMENContext : DbContext
    {
        public SAMMENContext(DbContextOptions<SAMMENContext> options) : base(options) {}
        public DbSet<User> Users { get; set; }
        public DbSet<Herramienta> Herramientas { get; set; }
        public DbSet<MedidaHerramienta> MedidaHerramientas{ get; set; }        
        public DbSet<HistorialHerramienta> HistorialHerramientas { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Operador> Operadores { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<MedidaHerramientaEspecial> MedidaHerramientaEspecials { get; set; }
        public DbSet<OperadorCurso> OperadorCursos { get; set; }
    }
}