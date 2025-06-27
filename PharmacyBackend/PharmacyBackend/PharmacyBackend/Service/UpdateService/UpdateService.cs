using PharmacyBackend.Contracts.RepositoryContracts.UpdateInterface;
using PharmacyBackend.Contracts.ServiceContracts.UpdateInterface;
using PharmacyBackend.Models;

namespace PharmacyBackend.Service.UpdateService
{
    public class UpdateService : IUpdateServiceContracts
    {
        private readonly IUpdateRepositoryContracts _updateRepo;

        public UpdateService(IUpdateRepositoryContracts updateRepo)
        {
            _updateRepo = updateRepo;
        }

        public Task<bool> UpdateEmployeeAsync(Employee request)
        {
            throw new NotImplementedException();
        }
    }
}
