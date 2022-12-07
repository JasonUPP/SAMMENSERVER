using DataBase.Enums.Operativo;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase.Models.Operativo
{
    public class MedidaHerramienta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Descripcion { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public decimal RoscaCaja { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public decimal RoscaPin { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public decimal DiametroExterno { get; set; }
        public string BalinPaso { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public decimal Longitud { get; set; }
        public string NumeroSerie { get; set; }
        public EnumEstatus Estatus { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public decimal PresionMaxima { get; set; }
        public string BalinSub { get; set; }
        public string BalinDesconector { get; set; }
        public EnumTipoMedidaHerramienta Tipo { get; set; }
    }
}
