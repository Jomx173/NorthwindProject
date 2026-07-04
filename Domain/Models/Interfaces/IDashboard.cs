using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Models.Interfaces
{
    public interface IDashboard
    {
        Task<DashboardSummaryDto> GetDashboardSummary();
        Task<List<(string Empleado, decimal TotalVentas)>> GetVentasPorEmpleado();

        Task<List<(string Producto, int Cantidad)>> GetProductosMasVendidos();
    }
}