using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.DTO;
using Domain.Models.Interfaces;

namespace Domain.Services
{
    public class DashboardService
    {
        private readonly IDashboard _dashboardRepository;

        public DashboardService(IDashboard dashboardRepository)
        {
            _dashboardRepository = dashboardRepository;
        }

        public async Task<DashboardSummaryDto> GetDashboardSummary()
        {
            return await _dashboardRepository.GetDashboardSummary();
        }

        public async Task<List<(string Empleado, decimal TotalVentas)>> GetVentasPorEmpleado()
        {
            return await _dashboardRepository.GetVentasPorEmpleado();
        }

        public async Task<List<(string Producto, int Cantidad)>> GetProductosMasVendidos()
        {
            return await _dashboardRepository.GetProductosMasVendidos();
        }
    }
}
