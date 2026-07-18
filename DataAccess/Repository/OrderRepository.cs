using DataAccess.Context;
using DataAccess.Models;
using Domain.Models.DTO;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrder
    {
        private readonly NorthWindContext _context;

        public OrderRepository(NorthWindContext context)
        {
            _context = context;
        }

        public async Task<List<OrderDto>> GetOrdersByCustomer(string customerId)
        {
            var orders = await _context.Orders
                .AsNoTracking()
                .Where(o => o.CustomerId == customerId)
                .Select(o => new OrderDto
                {
                    OrderId = o.OrderId,
                    CustomerId = o.CustomerId ?? string.Empty,
                    OrderDate = o.OrderDate ?? DateTime.MinValue,
                    ShipCity = o.ShipCity ?? string.Empty
                })
                .ToListAsync();

            return orders;
        }

        public async Task<List<OrderDto>> GetOrdersByCustomerId(string customerId)
        {
            return await GetOrdersByCustomer(customerId);
        }

        public async Task<OrderDto?> GetOrderById(int orderId)
        {
            var order = await _context.Orders
                .AsNoTracking()
                .FirstOrDefaultAsync(o => o.OrderId == orderId);

            return order == null ? null : new OrderDto
            {
                OrderId = order.OrderId,
                CustomerId = order.CustomerId ?? string.Empty,
                OrderDate = order.OrderDate ?? DateTime.MinValue,
                ShipCity = order.ShipCity ?? string.Empty
            };
        }

        public async Task AddOrder(OrderDto orderDto)
        {
            var order = new Order
            {
                CustomerId = orderDto.CustomerId,
                OrderDate = orderDto.OrderDate,
                ShipCity = orderDto.ShipCity
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateOrder(OrderDto orderDto)
        {
            var order = await _context.Orders.FindAsync(orderDto.OrderId);

            if (order != null)
            {
                order.OrderDate = orderDto.OrderDate;
                order.ShipCity = orderDto.ShipCity;
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteOrder(int orderId)
        {
            var order = await _context.Orders.FindAsync(orderId);

            if (order != null)
            {
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
            }
        }
    }
}