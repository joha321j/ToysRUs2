using Microsoft.EntityFrameworkCore;
using ToysRUs2.Models;

namespace ToysRUs2.Persistency
{
    public class ClothesDatabaseContext : DbContext
    {
        public DbSet<Colour> Colours { get; set; }
        public DbSet<Sex> Sexes { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<ClothingImage> ClothingImages { get; set; }
        public DbSet<Clothes> ClothingSet { get; set; }
        
        public ClothesDatabaseContext(DbContextOptions<ClothesDatabaseContext> options) : base (options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Colour>().ToTable("Colours");
            modelBuilder.Entity<Sex>().ToTable("Sexes");
            modelBuilder.Entity<Size>().ToTable("Sizes");
            modelBuilder.Entity<Type>().ToTable("Types");
            modelBuilder.Entity<ClothingImage>().ToTable("ClothingImages");
            modelBuilder.Entity<Clothes>().ToTable("ClothingSet");
        }
    }
}