using Domain.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Intefaces
{
    public interface IVentasEmpleados
    {
        Task<List<VentasEmpleadosDTO>> GetVentasEmpleados(DateTime fechaInicio, DateTime fechaFin);
    }
}
