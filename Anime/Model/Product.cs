using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Anime.Model
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [Range(5, 30, ErrorMessage = "Accommodation invalid (1-255).")]
        public string Name { get; set; } = null!;

        public int Price { get; set; }

        [Required]
        [Range(5, 255, ErrorMessage = "Accommodation invalid (1-255).")]
        public string Image { get; set; } = null!;

        [Required]
        [Range(5, 255, ErrorMessage = "Accommodation invalid (1-255).")]
        public string Description { get; set; }

        //[ForeignKey("Categories")]
        public int Categoryid { get; set; } 

    }
}
