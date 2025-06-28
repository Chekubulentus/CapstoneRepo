﻿using PharmacyBackend.DTOs.EmployeeDTOs;
using PharmacyBackend.Models;

namespace PharmacyBackend.Contracts.ServiceContracts.UpdateInterface
{
    public interface IUpdateServiceContracts
    {
        public Task<bool> UpdateEmployeeAsync(UpdateEmployeeRequest request);
    }
}
