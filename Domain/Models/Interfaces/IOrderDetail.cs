using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Models.Interfaces
{
    public interface IOrderDetail
    {
        Task<List<OrderDetailDto>> GetOrderDetails();

        Task<OrderDetailDto> GetOrderDetailById(string orderId);
    }
}