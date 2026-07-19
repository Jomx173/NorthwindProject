using Domain.DTO;
using Domain.Interfaces;
using Domain.Models.DTO;
using Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        // Obtener todos los pedidos de un cliente
        public async Task<List<OrderDto>> GetOrdersByCustomer(string customerId)
        {
            return await _order.GetOrdersByCustomer(customerId);
        }

        // Este es el método que usa FormClientes
        public async Task<List<OrderDto>> GetOrdersByCustomerId(string customerId)
        {
            return await _order.GetOrdersByCustomer(customerId);
        }

        // Obtener un pedido específico
        public async Task<OrderDto?> GetOrderById(int orderId)
        {
            return await _order.GetOrderById(orderId);
        }

        // Registrar un nuevo pedido
        public async Task AddOrder(OrderDto order)
        {
            await _order.AddOrder(order);
        }

        // Modificar un pedido existente
        public async Task UpdateOrder(OrderDto order)
        {
            await _order.UpdateOrder(order);
        }

        // Eliminar un pedido
        public async Task DeleteOrder(int orderId)
        {
            await _order.DeleteOrder(orderId);
        }
    }
}