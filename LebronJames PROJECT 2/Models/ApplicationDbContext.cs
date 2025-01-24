using Microsoft.EntityFrameworkCore;

namespace LebronJames_PROJECT_2.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        
        public DbSet<Comment> Comments { get; set; }
    }
}