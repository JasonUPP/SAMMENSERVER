using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DataBase.Enums.Operativo;

namespace DataBase.Models.Operativo
{
    public class MedidaHerramientaEspecial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Descripcion { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public decimal RoscaGIR { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public decimal RoscaCaja { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public decimal DiametroExterno { get; set; }
        public string BalinPaso { get; set; }
        [Column(TypeName = "decimal(10,4)")]
        public decimal Longitud { get; set; }
        public string NumeroSerie { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public decimal TensionMaxima { get; set; }
        public int IdUbicacion { get; set; }
        public string NumeroInforme { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Dias { get; set; }
        public EnumEstatus Estatus { get; set; }
        public string Acuse { get; set; }
        public string Firma { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int DiasEnCampo { get; set; }
        public EnumTipoMedidaHerramienta Tipo { get; set; }
    }
}
