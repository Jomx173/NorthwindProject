using System;
using System.Linq;
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
                OrderDate = order.OrderDate,
                Total = order.OrderDetails.Sum(d => d.UnitPrice * d.Quantity)
            };
        }
    }
}