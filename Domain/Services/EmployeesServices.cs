using Domain.Models.DTO;
using Domain.Models.Intefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public class EmployeesServices
    {
        private readonly IEmployees _employees;

        
        public EmployeesServices(IEmployees employees)
        {
            _employees = employees;
        }

        
        public async Task<List<EmployeesDto>> GetEmployees()
        {
            return await _employees.GetEmployees();
        }

        
        public async Task<EmployeesDto> GetEmployeesById(string EmployeesID)
        {
            return await _employees.GetEmployeesById(EmployeesID);
        }

    }
}
