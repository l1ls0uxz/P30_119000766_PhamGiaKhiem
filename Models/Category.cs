using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(200)]
        [MinLength(50)]
        public string Name { get; set; } = string.Empty;
    }
}