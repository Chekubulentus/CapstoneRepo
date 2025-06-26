using Microsoft.EntityFrameworkCore;

namespace PharmacyBackend.DataContext
{
    public class PharmacyContext : DbContext
    {
        public PharmacyContext(DbContextOptions<PharmacyContext> options) : base(options) { }
    }
}
