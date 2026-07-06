using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.DTO;

namespace Domain.Interfaces
{
    public interface IEmpleados
    {
        Task<List<EmpleadosDto>> GetEmpleados();

        Task<EmpleadosDto> GetEmpleadoById(int employeeId);
    }
}