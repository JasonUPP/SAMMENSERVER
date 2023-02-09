using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataBase.Models.Operativo
{
    public class Cursos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Item { get; set; }
        //public EnumReferencia Referencia { get; set; }
        public string Nombre { get; set; }
        public int Requerido { get; set; }
        //public EnumIngeHerramientasJr IngenieroHerramientas { get; set; }//enum
    }
}
