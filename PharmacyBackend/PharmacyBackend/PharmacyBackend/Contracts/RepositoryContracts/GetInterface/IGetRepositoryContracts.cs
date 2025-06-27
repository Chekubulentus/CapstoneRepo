using PharmacyBackend.Models;

namespace PharmacyBackend.Contracts.RepositoryContracts.GetInterface
{
    public interface IGetRepositoryContracts
    {
        public Task<List<Employee>> GetAllEmployeesAsync();
        public Task<Employee> GetEmployeeByIdAsync(int id);
    }
}
