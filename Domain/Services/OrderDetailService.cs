using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Interfaces;
using Domain.DTO;

namespace Domain.Services
{
    public class OrderDetailService : IOrderDetail
    {
        private readonly IOrderDetail _orderDetail;

        public OrderDetailService(IOrderDetail orderDetail)
        {
            _orderDetail = orderDetail;
        }

        public async Task<List<OrderDetailDto>> GetOrderDetails()
        {
            return await _orderDetail.GetOrderDetails();
        }

        public async Task<OrderDetailDto> GetOrderDetailById(string orderId)
        {
            return await _orderDetail.GetOrderDetailById(orderId);
        }
    }
}