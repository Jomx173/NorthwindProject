using Domain.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Intefaces
{
    public interface IEmployees
    {
        Task<List<EmployeesDto>> GetEmployees();

        Task<EmployeesDto> GetEmployeesById(string EmployesID);
        Task<List<OrderDto>> GetOrdersByEmployee(int employeeId);
        Task<bool> AddEmployee(EmployeesDto employee);
        Task<bool> UpdateEmployee(EmployeesDto employee);

    }
}
