namespace PharmacyBackend.Contracts.RepositoryContracts.DeleteInterface
{
    public interface IDeleteContracts
    {
        public Task<bool> DeleteEmployeeByIdAsync(int id);
    }
}
