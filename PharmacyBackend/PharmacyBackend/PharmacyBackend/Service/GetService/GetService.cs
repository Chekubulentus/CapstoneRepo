using PharmacyBackend.Contracts.RepositoryContracts.GetInterface;
using PharmacyBackend.Contracts.ServiceContracts.GetInterface;
using PharmacyBackend.Models;

namespace PharmacyBackend.Service.GetService
{
    public class GetService : IGetServiceContracts
    {
        private readonly IGetRepositoryContracts _getRepo;

        public GetService(IGetRepositoryContracts getRepo)
        {
            _getRepo = getRepo;
        }

        public Task<List<Employee>> GetAllEmployeesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
