using Data_access.Context;
using Domain.Models.DTO;
using Domain.Models.Intefaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            var lista = await _context.Employees.ToListAsync();

            return lista.Select(e => new EmployeesDto
            {
                EmployeesID = e.EmployeeId.ToString(),
                LastName = e.LastName,
                FirstName = e.FirstName,
                HomePhone = e.HomePhone,
                Address = e.Address
            }).ToList();
        }

       
        public async Task<EmployeesDto> GetEmployeesById(string EmployesID)
        {
            if (int.TryParse(EmployesID, out int id))
            {
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
            return null;
        }

        
        public async Task<List<OrderDto>> GetOrdersByEmployee(int id)
        {
           
            var pedidosDb = await _context.Orders
                                          .Where(o => o.EmployeeId == id)
                                          .ToListAsync();

            
            return pedidosDb.Select(o => new OrderDto
            {
                OrderId = o.OrderId,
                CustomerId = o.CustomerId,
                EmployeeId = o.EmployeeId,
                OrderDate = o.OrderDate,
                ShipName = o.ShipName,
                ShipCity = o.ShipCity
            }).ToList();
        }
    }
}