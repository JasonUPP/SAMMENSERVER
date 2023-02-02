using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataBase.Models.Operativo
{
    public class Ubicacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
        public string Direccion { get; set; }
        public string NumeroCelular { get; set; }
        public int CantidadUTF { get; set; }
        public string Caja { get; set; }
    }
}
