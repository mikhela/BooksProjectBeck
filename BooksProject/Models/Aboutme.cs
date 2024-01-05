using System.ComponentModel.DataAnnotations;

namespace BooksProject.Models
{
    public class Aboutme
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Surname { get; set; }
        [Required]
        [MaxLength(1500)]
        public string aboutmyself { get; set; }

    }
}
