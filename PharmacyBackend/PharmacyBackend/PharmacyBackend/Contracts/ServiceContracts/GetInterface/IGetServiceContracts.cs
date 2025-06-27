using PharmacyBackend.Models;

namespace PharmacyBackend.Contracts.ServiceContracts.GetInterface
{
    public interface IGetServiceContracts
    {
        public Task<List<Employee>> GetAllEmployeesAsync();
        public Task<Employee> GetEmployeeByIdAsync(int id);
    }
}
