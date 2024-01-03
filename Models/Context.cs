using Microsoft.EntityFrameworkCore;

namespace server_side.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {
        }
        public DbSet<Product> productss { get; set; }

        public DbSet<Users> Userss  { get; set; }
        
    }
}