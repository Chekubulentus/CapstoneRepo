using PharmacyBackend.Contracts.RepositoryContracts.PostInterface;
using PharmacyBackend.DataContext;
using PharmacyBackend.Models;

namespace PharmacyBackend.Repository.POST
{
    public class PostRepository : IPostContracts
    {
        private readonly PharmacyContext _context;
        public PostRepository(PharmacyContext context)
        {
            _context = context;
        }

        public Task<bool> CreateEmployeeAsync(Employee request)
        {
            throw new NotImplementedException();
        }
    }
}
