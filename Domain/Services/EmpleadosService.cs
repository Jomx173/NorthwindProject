using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;

namespace Domain.Services
{
    public class EmpleadosService : IEmpleados
    {
        //todo lo privado lleva un guion bajo
        private readonly IEmpleados _empleados;

        public EmpleadosService(IEmpleados empleados)
        {
            _empleados = empleados;
        }

        public async Task<List<Models.DTO.EmpleadosDto>> GetEmpleados()
        {
            return await _empleados.GetEmpleados();
        }

        public async Task<Models.DTO.EmpleadosDto> GetEmpleadoById(int employeeId)
        {
            return await _empleados.GetEmpleadoById(employeeId);
        }
    }
}