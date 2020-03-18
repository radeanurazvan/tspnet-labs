using Lab5.InheritanceSharedTable;
using Lab5.SharedTable;
using Lab5.TablePerInheritance;
using Microsoft.EntityFrameworkCore;

namespace Lab5
{
    public sealed class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base(GetOptions())
        {
        }

        public DbSet<SelfReference.SelfReference> SelfReferences { get; set; }

        public DbSet<Photo> Photos { get; set; }

        public DbSet<PhotoFullImage> PhotoFullImages { get; set; }
        
        public DbSet<Business> Businesses { get; set; }
        
        public DbSet<Retail> Retails { get; set; }
        
        public DbSet<Ecommerce> Ecommerces { get; set; }

        public DbSet<Employee> Employees { get; set; }

        private static DbContextOptions GetOptions()
        {
            return new DbContextOptionsBuilder()
                .UseSqlServer("Server=sqlserver,1433;Database=Lab4TspNet;User=sa;Password=Pass4Dev1!;Connect Timeout=300;")
                .Options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
        }
    }
}