using Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    internal class EmployeesService : IEmployees

    {
        //todo lo privado lleva un guion bajo
        private readonly IEmployees _employees;

        public EmployeesService(IEmployees employees)
        {
            _employees = employees;
        }

        public async Task<List<Models.DTO.EmployeesDto>> GetEmployees()
        {
            return await _employees.GetEmployees();
        }

        public async Task<Models.DTO.EmployeesDto> GetEmployeesById(string EmployeesId)
        {
            return await _employees.GetEmployeesById(EmployeesId);
        }

    }
}
