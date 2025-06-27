using PharmacyBackend.Contracts.RepositoryContracts.PostInterface;
using PharmacyBackend.Contracts.ServiceContracts.PostInterface;
using PharmacyBackend.Models;

namespace PharmacyBackend.Service.PostService
{
    public class PostService : IPostServiceContracts
    {
        private readonly IPostRepositoryContracts _postRepo;

        public PostService(IPostRepositoryContracts postRepo)
        {
            _postRepo = postRepo;
        }

        public Task<bool> CreateEmployeeAsync(Employee request)
        {
            throw new NotImplementedException();
        }
    }
}
