using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataBase.Models
{
    public class MotorFondo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NumSerie { get; set; }
        public virtual ICollection<HistorialHerramienta> Historial { get; set; }
    }
}
