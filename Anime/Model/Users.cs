using System.ComponentModel.DataAnnotations;

namespace Anime.Model
{
	public class Users
	{
		public int Id { get; set; }

		[Required]
		[Range(1, 30, ErrorMessage = "Accommodation invalid (1-30).")]
		public string? Login { get; set; } = null!;

		[Required]
		[Range(8, 30, ErrorMessage = "Accommodation invalid (1-30).")]
		public string? Pass { get; set; } = null!;
		public bool Root { get; set; }
	}
}
