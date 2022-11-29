using DataBase.Models;
using Microsoft.EntityFrameworkCore;
using SAMMEN.DataBase.Models;

namespace DataBase
{
    public class SAMMENContext : DbContext
    {
        public SAMMENContext(DbContextOptions<SAMMENContext> options) : base(options) {}
        public DbSet<User> Users { get; set; }
        DbSet<Herramienta> Herramientas { get; set; }
        DbSet<MedidaHerramienta> MedidaHerramientas{ get; set; }
        DbSet<MotorFondo> MotorFondos { get; set; }
        DbSet<HistorialHerramienta> HistorialMotorFondos { get; set; }

    }
}