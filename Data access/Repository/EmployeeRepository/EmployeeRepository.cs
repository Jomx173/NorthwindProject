using Data_access.Context;
using Data_access.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_access.Repository.EmployeeRepository
{
    public class EmployeeRepository
    {

        private readonly NorthWindContext _context;

        // El constructor recibe el contexto de la base de datos
        public EmployeeRepository(NorthWindContext context)
        {
            _context = context;
        }

        // 1. Método para obtener todos los empleados (Consultar)
        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        // 2. Método para registrar un nuevo empleado
        public bool AddEmployee(Employee employee)
        {
            try
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // 3. Método para modificar un empleado existente
        public bool UpdateEmployee(Employee employee)
        {
            try
            {
                _context.Employees.Update(employee);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        
        public List<Order> GetOrdersByEmployee(int employeeId)
        {
            
            return _context.Orders.Where(o => o.EmployeeId == employeeId).ToList();
        }

    }
}
