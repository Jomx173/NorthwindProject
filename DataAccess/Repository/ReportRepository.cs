using DataAccess.Context;
using Domain.Models.DTO;
using Domain.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    public class ReportRepository : IReport
    {
        private readonly NorthWindContext _context;

        public ReportRepository(NorthWindContext context)
        {
            _context = context;
        }

        public async Task<List<SalesByCustomerDto>> GetSalesByCustomer(DateTime desde, DateTime hasta)
        {
            var result = await (
                from c in _context.Customers
                join o in _context.Orders on c.CustomerId equals o.CustomerId
                join od in _context.OrderDetails on o.OrderId equals od.OrderId
                where o.OrderDate >= desde && o.OrderDate <= hasta
                group new { c, o, od } by new
                {
                    c.CustomerId,
                    c.CompanyName,
                    c.ContactName,
                    c.Country,
                    c.City
                }
                into g
                orderby g.Sum(x => x.od.UnitPrice * x.od.Quantity * (decimal)(1 - x.od.Discount)) descending
                select new SalesByCustomerDto
                {
                    CustomerID = g.Key.CustomerId,
                    CompanyName = g.Key.CompanyName,
                    ContactName = g.Key.ContactName,
                    Country = g.Key.Country,
                    City = g.Key.City,
                    CantidadPedidos = g.Select(x => x.o.OrderId).Distinct().Count(),
                    TotalVendido = g.Sum(x => x.od.UnitPrice * x.od.Quantity * (decimal)(1 - x.od.Discount))
                }
            ).ToListAsync();

            return result;
        }
    }
}