using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DataBase.Enums;

namespace DataBase.Models
{
    public class Cursos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public EnumReferencia Referencia { get; set; }
        public string Nombre { get; set; }
        public DateTime Vigencia { get; set; }
        public EnumIngeHerramientasJr IngenieroHerramientas { get; set; }//enum
    }
}
