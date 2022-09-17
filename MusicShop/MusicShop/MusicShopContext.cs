using MusicShop.Configuration;
using MusicShop.Models;
using Microsoft.EntityFrameworkCore;
using MusicShop.Models;

namespace MusicShop
{
    public class MusicShopContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Edition> Editions { get; set; }
        public MusicShopContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new EditionConfiguration());
        }
    }
}
