using Microsoft.EntityFrameworkCore;

namespace Lab10.Service.EntityFramework
{
    internal sealed class PostCommentContext : DbContext
    {
        public PostCommentContext() 
            : base(GetOptions())
        {
            
        }

        public DbSet<Post> Posts { get; set; }

        private static DbContextOptions GetOptions()
        {
            return new DbContextOptionsBuilder()
                .UseSqlServer("Server=sqlserver,1433;Database=Lab10TspNet;User=sa;Password=Pass4Dev1!;Connect Timeout=300;")
                .Options;
        }
    }
}