﻿using PharmacyBackend.Models;

namespace PharmacyBackend.Contracts.RepositoryContracts.PostInterface
{
    public interface IPostRepositoryContracts
    {
        public Task<bool> CreateEmployeeAsync(Employee request);
    }
}
