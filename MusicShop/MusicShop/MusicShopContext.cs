using Microsoft.EntityFrameworkCore;

namespace MusicShop
{
    internal class MusicShopContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public MusicShopContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
        }
    }
}
