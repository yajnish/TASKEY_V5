using Microsoft.EntityFrameworkCore;
using TASKEYV5.Models.Domains;
namespace TASKEYV5.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Models.Domains.Task> Task { get; set; }
        public DbSet<Project> Projects { get; set; }


    }
}
