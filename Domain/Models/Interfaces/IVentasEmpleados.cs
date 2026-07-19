using Domain.Models.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Models.Interfaces
{
    public interface IVentasEmpleados
    {
        Task<List<VentasEmpleadosDTO>> GetVentasEmpleados(
            DateTime fechaInicio,
            DateTime fechaFin);
    }
}