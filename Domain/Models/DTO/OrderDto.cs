using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.DTO
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public int? EmployeeId { get; set; } // El "?" corrige el error CS0266 de la línea 70
        public DateTime? OrderDate { get; set; }
        public string ShipName { get; set; } // Añadido para corregir el error de la línea 72
        public string ShipCity { get; set; }
    }
    }
