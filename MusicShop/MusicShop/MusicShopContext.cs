using MusicShop.Configuration;
using MusicShop.Models;
using Microsoft.EntityFrameworkCore;

namespace MusicShop
{
    public class MusicShopContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Edition> Editions { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Plate> Plates { get; set; }
        public DbSet<UserOrder> UserOrders { get; set; }
        public MusicShopContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Shop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new EditionConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new UserOrderConfiguration());
            modelBuilder.ApplyConfiguration(new PlateConfiguration());
        }
    }
}
