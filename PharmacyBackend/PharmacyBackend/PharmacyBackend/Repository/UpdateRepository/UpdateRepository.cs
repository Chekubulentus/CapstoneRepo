using PharmacyBackend.Contracts.RepositoryContracts.UpdateInterface;
using PharmacyBackend.DataContext;
using PharmacyBackend.Models;

namespace PharmacyBackend.Repository.UpdateRepository
{
    public class UpdateRepository : IUpdateContracts
    {
        private readonly PharmacyContext _context;
        public UpdateRepository(PharmacyContext context)
        {
            _context = context;
        }

        public Task<bool> UpdateEmployeeAsync(Employee request)
        {
            throw new NotImplementedException();
        }
    }
}
