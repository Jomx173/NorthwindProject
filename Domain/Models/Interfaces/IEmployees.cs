using Domain.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Interfaces 
{ 
    public interface IEmployees 
    { Task<List<EmployeesDto>> GetEmployees(); 
        Task<EmployeesDto> GetEmployeesById(string EmployeesId);
    } 
}