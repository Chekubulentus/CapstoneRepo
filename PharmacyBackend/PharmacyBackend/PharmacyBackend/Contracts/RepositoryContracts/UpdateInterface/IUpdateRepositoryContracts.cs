﻿using PharmacyBackend.Models;

namespace PharmacyBackend.Contracts.RepositoryContracts.UpdateInterface
{
    public interface IUpdateRepositoryContracts
    {
        public Task<bool> UpdateEmployeeAsync(Employee request);
    }
}
