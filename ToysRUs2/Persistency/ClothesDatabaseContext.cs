using Microsoft.EntityFrameworkCore;
using ToysRUs2.Models;

namespace ToysRUs2.Persistency
{
    public class ClothesDatabaseContext : DbContext
    {
        public ClothesDatabaseContext(DbContextOptions<ClothesDatabaseContext> options) : base (options)
        {
        }

        public DbSet<Colour> Colours { get; set; }
        public DbSet<Sex> Sexes { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Type> Types { get; set; }
    }
}