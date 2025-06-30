using PharmacyBackend.DataContext;
using PharmacyBackend.DTOs.EmployeeDTOs;
using PharmacyBackend.Models;

namespace PharmacyBackend.Helper
{
    public static class EmployeeValidation
    {
        public static string EmployeeCodeChecker(List<Employee> request, PharmacyContext context)
        {
            // kapag okay naman laaht walang duplicate return null
            return "Duplicate employee code";
        }
    }
}
