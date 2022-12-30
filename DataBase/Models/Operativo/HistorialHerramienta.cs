using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DataBase.Enums.Operativo;

namespace DataBase.Models.Operativo
{
    public class HistorialHerramienta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Pozo { get; set; }
        public string Estructura { get; set; }
        public EnumTipoOperacion TipoOperacion { get; set; }//2
        public EnumUnidad Unidad { get; set; }
        public int IdOperador { get; set; }
        [ForeignKey("IdOperador")]
        public virtual Operador Operador { get; set; }
        public int ProfundidadMax { get; set; } //5

        [Column(TypeName = "decimal(10,4)")]
        public decimal OD { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public decimal MaxWHP { get; set; }

        [Column(TypeName = "decimal(10,4)")] //8
        public decimal TemperaturaMaxima { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public decimal MaxCircPressure { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public decimal Diesel { get; set; }

        [Column(TypeName = "decimal(10,4)")] //11
        public decimal Solvente { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public decimal Acido { get; set; }

        [Column(TypeName = "decimal(10,4)")]

        public decimal Divergente { get; set; }

        [Column(TypeName = "decimal(10,4)")] //14
        public decimal Nitrogeno { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public decimal GelLineal { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public decimal Agua { get; set; }
        public int HorasOperativas { get; set; }
        public int HorasEfectivas { get; set; }
        public string Notas { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public decimal Total { get; set; }
    }
}
