using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models.DTO;

namespace Domain.Interfaces
{
    public interface IOrder
    {
        // Obtener todos los pedidos de un cliente
        Task<List<OrderDto>> GetOrdersByCustomer(string customerId);

        // Obtener pedidos por CustomerID (para el formulario de clientes)
        Task<List<OrderDto>> GetOrdersByCustomerId(string customerId);

        // Obtener un pedido específico por su ID
        Task<OrderDto?> GetOrderById(int orderId);

        // Registrar un nuevo pedido
        Task AddOrder(OrderDto order);

        // Modificar un pedido existente
        Task UpdateOrder(OrderDto order);

        // Eliminar un pedido
        Task DeleteOrder(int orderId);
    }
}