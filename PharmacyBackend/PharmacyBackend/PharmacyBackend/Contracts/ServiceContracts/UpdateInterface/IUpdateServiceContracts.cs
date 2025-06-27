using PharmacyBackend.Models;

namespace PharmacyBackend.Contracts.ServiceContracts.UpdateInterface
{
    public interface IUpdateServiceContracts
    {
        public Task<bool> UpdateEmployeeAsync(Employee request);
    }
}
