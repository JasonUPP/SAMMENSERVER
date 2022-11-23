using DataBase.Enums;

namespace SAMMEN.DataBase.Models
{
    public class MedidaHerramienta
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal RoscaCaja { get; set; }
        public decimal RoscaPin { get; set; }
        public decimal DiametroExterno { get; set; }
        public string BalinPaso { get; set; }
        public decimal Longitud { get; set; }
        public string NumeroSerie { get; set; }
        public EnumEstatus Estatus { get; set; }
        public EnumTipoMedidaHerramienta Tipo { get; set; }
    }
}
