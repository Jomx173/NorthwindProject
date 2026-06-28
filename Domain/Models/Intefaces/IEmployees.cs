using Domain.Models.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Models.Intefaces
{
    public interface IEmployees
    {
       
        Task<List<EmployeesDto>> GetEmployees();

   
        Task<EmployeesDto> GetEmployeesById(string EmployesID);

        
        Task<List<OrderDto>> GetOrdersByEmployee(int id);

        Task<bool> AddEmployee(EmployeesDto employeeDto);

     
        Task<bool> UpdateEmployee(EmployeesDto employeeDto);

       
        Task<bool> ExistsByName(string firstName, string lastName);
    }
}