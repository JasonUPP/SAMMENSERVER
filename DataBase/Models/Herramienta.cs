using DataBase.Enums;

namespace SAMMEN.DataBase.Models
{
    public class Herramienta
    {
        public int Id { get; set; }
        public int Num { get; set; }
        public string Descripcion { get; set; }
        public string NumeroInforme { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Dias { get; set; }
        public EnumEstatus Estatus { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int DiasCampo { get; set; }
        public string Acuse { get; set; }
        public string Firma { get; set; }
        public string Ubicacion { get; set; }
        public DateTime UltimoMtto { get; set; }
        public int DiasSinMtto { get; set; }
        public EnumTipoHerramienta Tipo { get;set; }
    }
}