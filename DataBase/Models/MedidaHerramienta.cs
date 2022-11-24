using DataBase.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAMMEN.DataBase.Models
{
    public class MedidaHerramienta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
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
        public EnumTipoMedidaHerramienta Tipo { get; set; }
    }
}
