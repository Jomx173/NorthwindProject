using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DTO;
using Domain.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using DataAccess.Context;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrder
    {
        private readonly NorthwindContext _context;

        public OrderRepository(NorthwindContext context)
        {
            _context = context;
        }

        public async Task<OrderDto> GetOrderById(string orderId)
        {
            var order = await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Employee)
                .Include(o => o.OrderDetails)
                .AsNoTracking()
                .FirstOrDefaultAsync(o => o.OrderId.ToString() == orderId);

            return order is null ? null : OrderMap.ToDto(order);
        }

        public async Task<List<OrderDto>> GetOrders()
        {
            var orders = await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Employee)
                .Include(o => o.OrderDetails)
                .AsNoTracking()
                .ToListAsync();

            return orders.Select(o => OrderMap.ToDto(o)).ToList();
        }


    }
}