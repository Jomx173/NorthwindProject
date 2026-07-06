using Data_access.Context;
using Domain.Models.DTO;
using Domain.Models.Intefaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data_access.Repository.VentasEmpleadosRepository
{
    public class VentasEmpleadosRepository : IVentasEmpleados
    {
        private readonly NorthWindContext _context;

        public VentasEmpleadosRepository(NorthWindContext context)
        {
            _context = context;
        }

        public async Task<List<VentasEmpleadosDTO>> GetVentasEmpleados(DateTime fechaInicio, DateTime fechaFin)
        {
            DateTime inicio = fechaInicio.Date;
            DateTime fin = fechaFin.Date.AddDays(1);

            var reporte = await _context.Employees
                .AsNoTracking()
                .Select(e => new VentasEmpleadosDTO
                {
                    EmployeeID = e.EmployeeId,

                    Empleado = e.FirstName + " " + e.LastName,

                    PedidosAtendidos = e.Orders
                        .Count(o => o.OrderDate >= inicio && o.OrderDate < fin),

                    VentasRealizadas = e.Orders
                        .Where(o => o.OrderDate >= inicio && o.OrderDate < fin)
                        .SelectMany(o => o.OrderDetails)
                        .Sum(od => (decimal?)(od.UnitPrice * od.Quantity * (1 - (decimal)od.Discount))) ?? 0
                })
                .Where(x => x.PedidosAtendidos > 0)
                .OrderByDescending(x => x.VentasRealizadas)
                .ToListAsync();

            int ranking = 1;

            foreach (var item in reporte)
            {
                item.Ranking = ranking;
                ranking++;
            }

            return reporte;
        }
    }
}