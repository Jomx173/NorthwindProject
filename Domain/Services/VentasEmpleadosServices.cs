using Domain.Models.DTO;
using Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

using Domain.Models.DTO;
using Domain.Models.Interfaces;

namespace Domain.Services
{
    public class VentasEmpleadosServices
    {
        private readonly IVentasEmpleados _ventasEmpleados;

        public VentasEmpleadosServices(IVentasEmpleados ventasEmpleados)
        {
            _ventasEmpleados = ventasEmpleados;
        }

        public async Task<List<VentasEmpleadosDTO>> GetVentasEmpleados(DateTime fechaInicio, DateTime fechaFin)
        {
            return await _ventasEmpleados.GetVentasEmpleados(fechaInicio, fechaFin);
        }
    }
}