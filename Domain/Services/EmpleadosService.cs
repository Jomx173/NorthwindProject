using Domain.Models.DTO;
using Domain.Models.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class EmpleadosService
    {
        private readonly IEmployee _empleados;

        public EmpleadosService(IEmployee empleados)
        {
            _empleados = empleados;
        }

        public async Task<List<EmpleadosDto>> GetEmpleados()
        {
            return await _empleados.GetEmpleados();
        }

        public async Task<EmpleadosDto> GetEmpleadoById(int employeeId)
        {
            return await _empleados.GetEmpleadoById(employeeId);
        }

        public async Task<List<EmpleadosDto>> GetEmployeeDtos()
        {
            return await _empleados.GetEmployeeDtos();
        }

        public async Task<EmpleadosDto> GetEmployeeById(string employeeId)
        {
            return await _empleados.GetEmployeeById(employeeId);
        }

        public async Task<List<EmpleadosDto>> GetEmployees()
        {
            return await _empleados.GetEmployees();
        }

        public async Task<EmpleadosDto> GetEmployeesById(string employeesID)
        {
            return await _empleados.GetEmployeesById(employeesID);
        }

        public async Task<List<OrderDto>> GetOrdersByEmployee(int employeeId)
        {
            return await _empleados.GetOrdersByEmployee(employeeId);
        }

        public async Task<bool> AddEmployee(EmpleadosDto employee)
        {
            return await _empleados.AddEmployee(employee);
        }

        public async Task<bool> UpdateEmployee(EmpleadosDto employee)
        {
            return await _empleados.UpdateEmployee(employee);
        }
    }
}