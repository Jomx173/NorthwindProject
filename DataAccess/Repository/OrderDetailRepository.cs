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
    public class OrderDetailRepository : IOrderDetail
    {
        private readonly NorthwindContext _context;

        public OrderDetailRepository(NorthwindContext context)
        {
            _context = context;
        }

        public async Task<OrderDetailDto> GetOrderDetailById(string orderId)
        {
            var orderDetail = await _context.OrderDetails
                .Include(od => od.Product)
                .AsNoTracking()
                .FirstOrDefaultAsync(od => od.OrderId.ToString() == orderId);

            return orderDetail is null ? null : OrderDetailMap.ToDto(orderDetail);
        }

        public async Task<List<OrderDetailDto>> GetOrderDetails()
        {
            var orderDetails = await _context.OrderDetails
                .Include(od => od.Product)
                .AsNoTracking()
                .ToListAsync();

            return orderDetails.Select(od => OrderDetailMap.ToDto(od)).ToList();
        }
    }
}
