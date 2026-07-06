using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.DTO
{
    public class VentasEmpleadosDTO
    {
        public int EmployeeID { get; set; }

        public string Empleado { get; set; }

        public int PedidosAtendidos { get; set; }

        public decimal VentasRealizadas { get; set; }

        public int Ranking { get; set; }
    }
}
