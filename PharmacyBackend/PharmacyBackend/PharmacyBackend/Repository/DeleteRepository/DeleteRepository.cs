using PharmacyBackend.Contracts.RepositoryContracts.DeleteInterface;
using PharmacyBackend.DataContext;

namespace PharmacyBackend.Repository.DELETE
{
    public class DeleteRepository : IDeleteContracts
    {
        private readonly PharmacyContext _context;
        public DeleteRepository(PharmacyContext context)
        {
            _context = context;
        }
    }
}
