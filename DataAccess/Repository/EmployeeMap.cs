using Domain.Models.DTO;
using DataAccess.Models;

namespace DataAccess.Repository
{
    public class EmployeeMap
    {
        public static EmpleadosDto ToDto(Employee employee)
        {
            return new EmpleadosDto
            {
                EmployeeId = employee.EmployeeId,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Country = employee.Country,
                Address = employee.Address
            };
        }
    }
}