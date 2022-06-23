using Anime.Data;

namespace Anime.Model
{
    public class Cart
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public int Price { get; set; }
        public string Image { get; set; } = null!;

        public string Description { get; set; }

        //[ForeignKey("Categories")]
        public int Categoryid { get; set; }


    }
}
