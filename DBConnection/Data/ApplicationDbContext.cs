using DBConnection.Models;
using Microsoft.EntityFrameworkCore;

namespace DBConnection.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<CompanyInfo> CompanyInfo { get; set; }
    }
}
