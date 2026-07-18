using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Interfaces;
using Domain.Models.DTO;

namespace Domain.Services
{
    public class OrderService : IOrder
    {
        private readonly IOrder _order;

        public OrderService(IOrder order)
        {
            _order = order;
        }

        public async Task<List<OrderDto>> GetOrders()
        {
            return await _order.GetOrders();
        }

        public async Task<OrderDto> GetOrderById(string orderId)
        {
            return await _order.GetOrderById(orderId);
        }
    }
}