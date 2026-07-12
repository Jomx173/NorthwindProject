using Domain.Models.DTO;
using Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class EmployeeService : IEmployee
    {
        private readonly IEmployee _employee;

        public EmployeeService(IEmployee employee)
        {
            _employee = employee;
        }

        public async Task<List<EmployeeDto>> GetEmployeeDtos()
        {
            return await _employee.GetEmployeeDtos();
        }

        public async Task<EmployeeDto> GetEmployeeById(String EmployeeId)
        {
            return await _employee.GetEmployeeById(EmployeeId);
        }
    }
}
