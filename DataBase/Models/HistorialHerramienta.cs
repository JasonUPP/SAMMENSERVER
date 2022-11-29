using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataBase.Models
{
    public class HistorialHerramienta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }        
        public int IdMotorFondo { get; set; }

        [ForeignKey("IdMotorFondo")]
        public virtual MotorFondo MotorFondo { get; set; }
        public DateTime Fecha { get; set; }
        public string Pozo { get; set; }
        public string TipoOperacion { get; set; }//posible enum
        public string Unidad { get; set; }
        public string Operador { get; set; } //posible relacion a nueva clase operador
        public int ProfundidadMax { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public decimal OD { get; set; }
        //posible decimal hasta comporbar con cliente
        public int MaxWHP { get; set; }
        public int TemperaturaMaxima { get; set; }
        public int MaxCircPressure { get; set; }
        public int Diesel { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public int Solvente { get; set; }
        public int Acido { get; set; }
        public int Divergente { get; set; }
        public int Nitrogeno { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public decimal GelLineal { get; set; }
        public int Agua { get; set; }

        public int HorasOperativas { get; set; }
        public int HorasEfectivas { get; set; }
        public string Notas { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public decimal Total { get; set; }





    }
}
