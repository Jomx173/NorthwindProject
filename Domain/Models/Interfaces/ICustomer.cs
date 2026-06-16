using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.DTO;

namespace Domain.Interfaces
{
    public interface ICustomer
    {
        Task<List<CustomerDto>> GetCustomers();

        Task<CustomerDto> GetCustomerById(string customerId);
    }
}