using PharmacyBackend.Contracts.RepositoryContracts.DeleteInterface;
using PharmacyBackend.Contracts.RepositoryContracts.GetInterface;
using PharmacyBackend.Contracts.ServiceContracts;
using PharmacyBackend.Contracts.ServiceContracts.DeleteInterface;
using PharmacyBackend.Repository.DELETE;

namespace PharmacyBackend.Service.DeleteService
{
    public class DeleteService : IDeleteServiceContracts
    {
        private readonly IDeleteRepositoryContracts _deleteRepo;

        public DeleteService(IDeleteRepositoryContracts deleteRepo)
        {
            _deleteRepo = deleteRepo;
        }

        public Task<bool> DeleteEmployeeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
