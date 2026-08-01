using Domain.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Models.Interfaces
{
    public interface IEmployee
    {
        // Métodos de EmpleadosService
        Task<List<EmpleadosDto>> GetEmpleados();

        Task<EmpleadosDto> GetEmpleadoById(int employeeId);

        // Métodos que ya tenía
        Task<List<EmpleadosDto>> GetEmployeeDtos();

        Task<EmpleadosDto> GetEmployeeById(string EmployeeId);

        // Métodos de EmployeesServices
        Task<List<EmpleadosDto>> GetEmployees();

        Task<EmpleadosDto> GetEmployeesById(string EmployeesID);

        Task<List<OrderDto>> GetOrdersByEmployee(int employeeId);

        Task<bool> AddEmployee(EmpleadosDto employee);

        Task<bool> UpdateEmployee(EmpleadosDto employee);

        Task<bool> ExistsByName(string firstName, string lastName);
    }
}