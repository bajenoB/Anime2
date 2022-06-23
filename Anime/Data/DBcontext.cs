using Microsoft.EntityFrameworkCore;
using Anime.Model;



namespace Anime.Data
{
    public class DBContext : DbContext
    {
        public DbSet<Categories> Categories { get; set; } = null!;
        public DbSet<Product> Product { get; set; } = null!;

        public DbSet<Users> Users { get; set; } = null!;

        public DBContext()   
        {
            Database.EnsureCreated();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SQL8002.site4now.net;Initial Catalog=db_a88bc2_animebaza;User Id=db_a88bc2_animebaza_admin;Password=Savelstan123;Encrypt=True;TrustServerCertificate=True;");
        }
    }
}
