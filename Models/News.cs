using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class News
    {
        public int ID { get; set; }
         [Required]
        [MaxLength(200)]
        [MinLength(50)]
        public string Title { get; set; } = string.Empty;
         [Required]
        

        public string ImageUrl { get; set; } = string.Empty;
        [Required]
        [MaxLength(500)]
        [MinLength(100)]
        public string Content { get; set; }= string.Empty;
         [Required]
        public string Author {get; set;} = string.Empty;
         [Required]
        public string CreatedAt { get; set; } = string.Empty;

    }
}