﻿namespace PharmacyBackend.DTOs.EmployeeDTOs
{
    public class CreateEmployeeRequest
    {
        public string EmployeeCode { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
