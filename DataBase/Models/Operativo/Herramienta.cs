using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DataBase.Enums.Operativo;

namespace DataBase.Models.Operativo
{
    public class Herramienta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Num { get; set; }
        public string Descripcion { get; set; }
        public string NumeroSerie { get; set; }
        public string NumeroInforme { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Dias { get; set; }
        public EnumEstatus Estatus { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int DiasCampo { get; set; }
        public int Acuse { get; set; }
        public string Firma { get; set; }
        public int IdUbicacion { get; set; }
        [ForeignKey("IdUbicacion")]
        public virtual Ubicacion Ubicacion { get; set; }
        public DateTime UltimoMtto { get; set; }
        public int DiasSinMtto { get; set; }
        public string Observaciones { get; set; }
        public EnumTipoHerramienta Tipo { get; set; }
    }
}