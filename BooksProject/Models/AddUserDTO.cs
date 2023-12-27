using System.ComponentModel.DataAnnotations;

namespace BooksProject.Models
{
    public class AddUserDTO
    {
        [Required]
        [StringLength(50)]
        public string EmailAddress { get; set; } = null;
        [Required]
        [StringLength(50)]
        public string Password { get; set; } = null;

    }
}