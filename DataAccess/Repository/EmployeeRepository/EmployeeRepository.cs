using DataAccess.Context;
using DataAccess.Models;
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
    

 
public async Task<bool> AddEmployee(EmployeesDto employeeDto)
        {
            try
            {
              
                var nuevoEmpleado = new Employee
                {
                    FirstName = employeeDto.FirstName,
                    LastName = employeeDto.LastName,
                    HomePhone = employeeDto.HomePhone,
                    Address = employeeDto.Address
                };

                await _context.Employees.AddAsync(nuevoEmpleado);
                var guardado = await _context.SaveChangesAsync();

                return guardado > 0;
            }
            catch (Exception)
            {
                throw; 
            }
        }

        
        public async Task<bool> UpdateEmployee(EmployeesDto employeeDto)
        {
            try
            {
                if (int.TryParse(employeeDto.EmployeesID, out int id))
                {
                    var empleadoDb = await _context.Employees.FindAsync(id);
                    if (empleadoDb == null) return false;

                   
                    empleadoDb.FirstName = employeeDto.FirstName;
                    empleadoDb.LastName = employeeDto.LastName;
                    empleadoDb.HomePhone = employeeDto.HomePhone;
                    empleadoDb.Address = employeeDto.Address;

                    _context.Employees.Update(empleadoDb);
                    var actualizado = await _context.SaveChangesAsync();

                    return actualizado > 0;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> ExistsByName(string firstName, string lastName)
        {
           
            return await _context.Employees
                .AnyAsync(e => e.FirstName.ToLower() == firstName.ToLower()
                            && e.LastName.ToLower() == lastName.ToLower());
        }
    }
}