using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.DTO;
using DataAccess.Models;

namespace DataAccess.Repository
{
    public class EmployeeMap
    {
        public static EmployeesDto ToDto(Employee employee)
        {
            return new EmployeesDto
            {
                Id = employee.EmployeeId.ToString(),
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Country = employee.Country,
                Address = employee.Address
            };
        }
    }
}
