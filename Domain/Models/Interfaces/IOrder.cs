using Domain.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Interfaces
{
    public interface IOrder
    {
        Task<List<OrderDto>> GetOrders();

        Task<OrderDto> GetOrderById(string orderId);
    }
}
