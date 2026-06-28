using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Models.DTO;
using Domain.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using DataAccess.Context;

namespace DataAccess.Repository
{
    public class EmployeeRepository : IEmployees
    {
        private readonly NorthwindContext _context;

        public EmployeeRepository(NorthwindContext context)
        {
            _context = context;
        }

        public async Task<EmployeesDto> GetEmployeesById(string EmployeesId)
        {
            var employee = await _context.Employees
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.EmployeeId.ToString() == EmployeesId);

            return employee is null ? null : EmployeeMap.ToDto(employee);
        }

        public async Task<List<EmployeesDto>> GetEmployees()
        {
            var employees = await _context.Employees
                .AsNoTracking()
                .ToListAsync();

            return employees.Select(e => EmployeeMap.ToDto(e)).ToList();
        }
    }
}
