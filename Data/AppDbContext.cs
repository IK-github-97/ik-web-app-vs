using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ik_web_app_vs.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Person> Persons { get; set; }
    }
}
