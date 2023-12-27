using System.ComponentModel.DataAnnotations;

namespace BooksProject.Models
{
    public class BooksInformation
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Title { get; set; } = null;
        [MaxLength(40)]
        [Required]
        public string AuthorName { get; set; } = null;
        [MaxLength(40)]
        [Required]
        public string AuthorSurname { get; set; } = null;
        [MaxLength(10000)]
        public string ContentOfStory { get; set; }


    }
}
