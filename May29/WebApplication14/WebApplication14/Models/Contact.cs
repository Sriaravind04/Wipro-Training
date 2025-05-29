using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication14.Models
{
    [Table("Contacts")]
    public class Contact
    {

        public string name { get; set; }
        public string email { get; set; }
        [Key]
        public string phone { get; set; }
        public string message { get; set; }
    }
}
