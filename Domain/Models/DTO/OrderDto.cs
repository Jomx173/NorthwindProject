using System;

namespace Domain.Models.DTO
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public int OrderID => OrderId;
        public string CustomerName { get; set; } = string.Empty;
        public string EmployeeName { get; set; } = string.Empty;
        public decimal Total { get; set; }
        public string CustomerId { get; set; } = string.Empty;
        public int? EmployeeId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ShipName { get; set; } = string.Empty;
        public string ShipCity { get; set; } = string.Empty;
    }
}