using Microsoft.EntityFrameworkCore;

namespace MusicShop
{
    internal class MusicShopContext : DbContext
    {

        public MusicShopContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
