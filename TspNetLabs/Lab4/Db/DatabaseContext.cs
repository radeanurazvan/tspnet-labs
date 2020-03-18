using Lab4.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Db
{
    internal sealed class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base(GetOptions())
        {
        }

        public DbSet<Product> Products { get; private set; }

        public DbSet<Client> Clients { get; private set; }

        public DbSet<Order> Orders { get; private set; }

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