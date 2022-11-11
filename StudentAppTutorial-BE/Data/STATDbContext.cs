using Microsoft.EntityFrameworkCore;
using StudentAppTutorial_BE.Model;


namespace StudentAppTutorial_BE.Data
{
    public class STATDbContext : DbContext 
    {
        public STATDbContext(DbContextOptions options) : base (options)
        {

        }
        public DbSet<Register> Palette { get; set; }
    }
}
