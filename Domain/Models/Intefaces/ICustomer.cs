using Domain.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Intefaces
{
    public interface ICustomer
    {
        Task<List<CustomerDTO>> GetCustomers();

        Task<CustomerDTO> GetCustomerById(string CustomerId);



    }
}
