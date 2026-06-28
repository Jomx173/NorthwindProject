using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.DTO
{
    public class DashboardSummaryDto
    {
        public decimal TotalVentas { get; set; }
        public int TotalClientes { get; set; }
        public int TotalEmpleados { get; set; }
        public int TotalProductos { get; set; }
        public int TotalOrdenes { get; set; }
    }
}