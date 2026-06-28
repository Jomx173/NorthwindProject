using Domain.Models.DTO;
using Domain.Models.Intefaces;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class EmployeesServices
    {
        private readonly IEmployees _employees;

        public EmployeesServices(IEmployees employees)
        {
            _employees = employees;
        }

        
        public async Task<List<EmployeesDto>> GetEmployees()
        {
            return await _employees.GetEmployees();
        }

        
        public async Task<EmployeesDto> GetEmployeesById(string employesID)
        {
            return await _employees.GetEmployeesById(employesID);
        }

        
        public async Task<List<OrderDto>> GetOrdersByEmployee(string employeeId)
        {
            if (string.IsNullOrEmpty(employeeId))
            {
                return new List<OrderDto>();
            }

            if (int.TryParse(employeeId, out int id))
            {
                return await _employees.GetOrdersByEmployee(id);
            }

            return new List<OrderDto>();
        }
        public async Task<bool> AddEmployee(EmployeesDto employeeDto)
        {
           
            if (string.IsNullOrWhiteSpace(employeeDto.FirstName) || string.IsNullOrWhiteSpace(employeeDto.LastName))
            {
                throw new Exception("El Nombre y el Apellido son campos obligatorios.");
            }

            
            var patronLetras = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ\s]+$");

            if (!patronLetras.IsMatch(employeeDto.FirstName))
            {
                throw new Exception("El campo 'Nombre' solo puede contener letras y espacios.");
            }

            if (!patronLetras.IsMatch(employeeDto.LastName))
            {
                throw new Exception("El campo 'Apellido' solo puede contener letras y espacios.");
            }

            bool yaExiste = await _employees.ExistsByName(employeeDto.FirstName.Trim(), employeeDto.LastName.Trim());

            if (yaExiste)
            {
                
                throw new Exception($"Ya existe un empleado registrado con el nombre '{employeeDto.FirstName} {employeeDto.LastName}'.");
            }

            return await _employees.AddEmployee(employeeDto);
        }

        public async Task<bool> UpdateEmployee(EmployeesDto employeeDto)
        {
            if (string.IsNullOrWhiteSpace(employeeDto.EmployeesID))
            {
                throw new Exception("No se puede modificar un empleado sin su ID.");
            }

            if (string.IsNullOrWhiteSpace(employeeDto.FirstName) || string.IsNullOrWhiteSpace(employeeDto.LastName))
            {
                throw new Exception("El Nombre y el Apellido no pueden quedar vacíos al modificar.");
            }

            
            var patronLetras = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ\s]+$");

            if (!patronLetras.IsMatch(employeeDto.FirstName))
            {
                throw new Exception("El campo 'Nombre' solo puede contener letras y espacios.");
            }

            if (!patronLetras.IsMatch(employeeDto.LastName))
            {
                throw new Exception("El campo 'Apellido' solo puede contener letras y espacios.");
            }

            return await _employees.UpdateEmployee(employeeDto);
        }
    }
}
