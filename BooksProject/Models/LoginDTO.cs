using System.ComponentModel.DataAnnotations;

namespace BooksProject.Models
{
    public class LoginDTO
    {

        [Required]
        [StringLength(50)]
        public string EmailAddress { get; set; } 

        [Required]
        [StringLength(50)]
        public string Password { get; set; } 
    }
}
