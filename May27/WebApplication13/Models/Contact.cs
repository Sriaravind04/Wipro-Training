using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace WebApplication13.Models
{
    public class Contact
    {
        [Required]
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Phn no should be  10 digits.")]
        public string Phone { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "Message too long.")]
        public string Subject { get; set; }

        [Required]
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}