using DataAccess.Context;
using DataAccess.Models;
using Domain.Models.DTO;
using Domain.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Repository.EmployeeRepository
{
    public class EmployeeRepository : IEmployee
    {
        private readonly NorthWindContext _context;

        public EmployeeRepository(NorthWindContext context)
        {
            _context = context;
        }

        public async Task<List<EmpleadosDto>> GetEmployees()
        {
            var lista = await _context.Employees
                .AsNoTracking()
                .ToListAsync();

            return lista.Select(e => new EmpleadosDto
            {
                EmployeeId = e.EmployeeId,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Title = e.Title,
                City = e.City,
                Phone = e.HomePhone,
                Country = e.Country,
                Address = e.Address
            }).ToList();
        }

        public async Task<EmpleadosDto> GetEmployeesById(string employeeId)
        {
            if (!int.TryParse(employeeId, out int id))
            {
                return null;
            }

            var empleado = await _context.Employees
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.EmployeeId == id);

            if (empleado == null)
            {
                return null;
            }

            return new EmpleadosDto
            {
                EmployeeId = empleado.EmployeeId,
                FirstName = empleado.FirstName,
                LastName = empleado.LastName,
                Title = empleado.Title,
                City = empleado.City,
                Phone = empleado.HomePhone,
                Country = empleado.Country,
                Address = empleado.Address
            };
        }

        public async Task<List<OrderDto>> GetOrdersByEmployee(int employeeId)
        {
            var pedidos = await _context.Orders
                .Where(o => o.EmployeeId == employeeId)
                .AsNoTracking()
                .ToListAsync();

            return pedidos.Select(o => new OrderDto
            {
                OrderId = o.OrderId,
                CustomerId = o.CustomerId,
                EmployeeId = o.EmployeeId,
                OrderDate = o.OrderDate,
                ShipName = o.ShipName,
                ShipCity = o.ShipCity
            }).ToList();
        }

        public async Task<bool> AddEmployee(EmpleadosDto employeeDto)
        {
            var nuevoEmpleado = new Employee
            {
                FirstName = employeeDto.FirstName,
                LastName = employeeDto.LastName,
                Title = employeeDto.Title,
                City = employeeDto.City,
                HomePhone = employeeDto.Phone,
                Country = employeeDto.Country,
                Address = employeeDto.Address
            };

            await _context.Employees.AddAsync(nuevoEmpleado);

            var guardado = await _context.SaveChangesAsync();

            return guardado > 0;
        }

        public async Task<bool> UpdateEmployee(EmpleadosDto employeeDto)
        {
            var empleadoDb = await _context.Employees
                .FindAsync(employeeDto.EmployeeId);

            if (empleadoDb == null)
            {
                return false;
            }

            empleadoDb.FirstName = employeeDto.FirstName;
            empleadoDb.LastName = employeeDto.LastName;
            empleadoDb.Title = employeeDto.Title;
            empleadoDb.City = employeeDto.City;
            empleadoDb.HomePhone = employeeDto.Phone;
            empleadoDb.Country = employeeDto.Country;
            empleadoDb.Address = employeeDto.Address;

            _context.Employees.Update(empleadoDb);

            var actualizado = await _context.SaveChangesAsync();

            return actualizado > 0;
        }

        public async Task<bool> ExistsByName(
            string firstName,
            string lastName)
        {
            return await _context.Employees.AnyAsync(e =>
                e.FirstName.ToLower() == firstName.ToLower() &&
                e.LastName.ToLower() == lastName.ToLower());
        }

        public async Task<DashboardSummaryDto> GetDashboardSummary()
        {
            return new DashboardSummaryDto
            {
                TotalClientes = await _context.Customers.CountAsync(),
                TotalEmpleados = await _context.Employees.CountAsync(),
                TotalProductos = await _context.Products.CountAsync(),
                TotalOrdenes = await _context.Orders.CountAsync(),

                TotalVentas = await _context.OrderDetails
                    .SumAsync(x => x.UnitPrice * x.Quantity)
            };
        }

        public async Task<List<(string Empleado, decimal TotalVentas)>>
            GetVentasPorEmpleado()
        {
            return await _context.Orders
                .Include(o => o.Employee)
                .Include(o => o.OrderDetails)
                .GroupBy(o =>
                    o.Employee.FirstName + " " +
                    o.Employee.LastName)
                .Select(g => new ValueTuple<string, decimal>(
                    g.Key,
                    g.SelectMany(o => o.OrderDetails)
                        .Sum(od => od.UnitPrice * od.Quantity)
                ))
                .ToListAsync();
        }

        public async Task<List<(string Producto, int Cantidad)>>
            GetProductosMasVendidos()
        {
            var datos = await _context.OrderDetails
                .Include(od => od.Product)
                .GroupBy(od => od.Product.ProductName)
                .Select(g => new
                {
                    Producto = g.Key,
                    Cantidad = g.Sum(od => od.Quantity)
                })
                .OrderByDescending(x => x.Cantidad)
                .Take(5)
                .ToListAsync();

            return datos
                .Select(x => (x.Producto, x.Cantidad))
                .ToList();
        }

        public async Task<List<EmpleadosDto>> GetEmpleados()
        {
            return await GetEmployees();
        }

        public async Task<EmpleadosDto> GetEmpleadoById(int employeeId)
        {
            return await GetEmployeesById(employeeId.ToString());
        }

        public Task<List<EmpleadosDto>> GetEmployeeDtos()
        {
            throw new NotImplementedException();
        }

        public Task<EmpleadosDto> GetEmployeeById(string employeeId)
        {
            throw new NotImplementedException();
        }
    }
}