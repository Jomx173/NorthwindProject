using Domain.Models.DTO;
using Domain.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;


namespace DataAccess.Repository
{
    public class DashboardRepository : IDashboard
    {
        private readonly NorthwindContext _context;

        public DashboardRepository(NorthwindContext context)
        {
            _context = context;
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

        public async Task<List<(string Empleado, decimal TotalVentas)>> GetVentasPorEmpleado()
        {
            return await _context.Orders
                .Include(o => o.Employee)
                .Include(o => o.OrderDetails)
                .GroupBy(o => o.Employee.FirstName + " " + o.Employee.LastName)
                .Select(g => new ValueTuple<string, decimal>(
                    g.Key,
                    g.SelectMany(o => o.OrderDetails)
                     .Sum(od => od.UnitPrice * od.Quantity)
                ))
                .ToListAsync();
        }
    }
}