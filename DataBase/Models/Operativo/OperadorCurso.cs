using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataBase.Models.Operativo
{
    public class OperadorCurso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdOperador { get; set; }
        public int IdCurso { get; set; }
        public DateTime Vigencia { get; set; }
        public int Estatus { get; set; }
    }
}
