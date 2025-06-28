using PharmacyBackend.DTOs.EmployeeDTOs;
using PharmacyBackend.Models;

namespace PharmacyBackend.Contracts.ServiceContracts.PostInterface
{
    public interface IPostServiceContracts
    {
        public Task<bool> CreateEmployeeAsync(CreateEmployeeRequest request);
    }
}
