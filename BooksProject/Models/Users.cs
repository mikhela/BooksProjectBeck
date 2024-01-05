using System.ComponentModel.DataAnnotations;


namespace BooksProject.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string EmailAddress { get; set; }
        [Required]
        [StringLength(150)]
        public string Password { get; set; }
        
    }
}
