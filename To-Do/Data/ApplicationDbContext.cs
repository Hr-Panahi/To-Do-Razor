using Microsoft.EntityFrameworkCore;
using To_Do.Model;
namespace To_Do.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<ToDoTask> ToDoTask { get; set; }


    }
}
 