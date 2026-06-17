using Data_access.Context;
using Data_access.Models;
using Domain.Models.DTO;
using Domain.Models.Intefaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository.EmployeeRepository
{
    public class EmployeeRepository : IEmployees
    {
        private readonly NorthWindContext _context;

        public EmployeeRepository(NorthWindContext context)
        {
            _context = context;
        }

        
        public async Task<List<EmployeesDto>> GetEmployees()
        {
            
            var listaEmpleados = await _context.Employees.ToListAsync();

            
            return listaEmpleados.Select(e => new EmployeesDto
            {
                EmployeesID = e.EmployeeId.ToString(),
                LastName = e.LastName,
                FirstName = e.FirstName,
                HomePhone = e.HomePhone,
                Address = e.Address
            }).ToList();
        }

        
        public async Task<EmployeesDto> GetEmployeesById(string EmployeesID)
        {
            int id = int.Parse(EmployeesID);
            var e = await _context.Employees.FindAsync(id);

            if (e == null) return null;

            return new EmployeesDto
            {
                EmployeesID = e.EmployeeId.ToString(),
                LastName = e.LastName,
                FirstName = e.FirstName,
                HomePhone = e.HomePhone,
                Address = e.Address
            };
        }

        
        public async Task<List<Order>> GetOrdersByEmployee(int employeeId)
        {
            return await _context.Orders
                .Where(o => o.EmployeeId == employeeId)
                .ToListAsync();
        }
    }
}