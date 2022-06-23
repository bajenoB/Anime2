using System.ComponentModel.DataAnnotations;

namespace Anime.Model
{
    public class Categories
    {
        public int Id { get; set; }

        [Required]
        [Range(1, 30, ErrorMessage = "Accommodation invalid (1-30).")]
        public string Name { get; set; }
    }
}
