using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAMMEN.DataBase.Models
{
    public class User
    {
        [Key]//primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//auto increment
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }        
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}
