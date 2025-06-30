using Microsoft.EntityFrameworkCore;
using PharmacyBackend.Contracts.RepositoryContracts.PostInterface;
using PharmacyBackend.DataContext;
using PharmacyBackend.DTOs.EmployeeDTOs;
using PharmacyBackend.Helper;
using PharmacyBackend.Models;

namespace PharmacyBackend.Repository.POST
{
    public class PostRepository : IPostRepositoryContracts
    {
        private readonly PharmacyContext _context;
        public PostRepository(PharmacyContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateEmployeeAsync(Employee request)
        {
            await _context.Employees.AddAsync(request);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
