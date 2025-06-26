using Microsoft.EntityFrameworkCore;
using PharmacyBackend.Models;

namespace PharmacyBackend.DataContext
{
    public class PharmacyContext : DbContext
    {
        public PharmacyContext(DbContextOptions<PharmacyContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
