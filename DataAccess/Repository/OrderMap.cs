using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.DTO;
using DataAccess.Models;

namespace DataAccess.Repository
{
    public class OrderMap
    {
        public static OrderDto ToDto(Order order)
        {
            return new OrderDto
            {
                OrderId = order.OrderId,
                CustomerName = order.Customer?.CompanyName ?? "",
                EmployeeName = order.Employee != null
                    ? order.Employee.FirstName + " " + order.Employee.LastName
                    : "",
                OrderDate = order.OrderDate ?? DateTime.MinValue,
                Total = order.OrderDetails
                    .Sum(d => d.UnitPrice * d.Quantity)
            };
        }
    }
}