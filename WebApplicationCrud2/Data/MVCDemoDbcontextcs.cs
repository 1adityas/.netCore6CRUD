using Microsoft.EntityFrameworkCore;
using WebApplicationCrud2.Models.Domain;

namespace WebApplicationCrud2.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

    }
}
