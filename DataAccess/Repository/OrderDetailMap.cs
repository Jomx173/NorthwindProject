using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DTO;
using DataAccess.Models;

namespace DataAccess.Repository
{
    public class OrderDetailMap
    {
        public static OrderDetailDto ToDto(OrderDetail orderDetail)
        {
            return new OrderDetailDto
            {
                OrderID = orderDetail.OrderId,
                ProductName = orderDetail.Product?.ProductName ?? "",
                UnitPrice = orderDetail.UnitPrice,
                Quantity = orderDetail.Quantity,
                SubTotal = orderDetail.UnitPrice * orderDetail.Quantity
            };
        }
    }
}
