using Domain.Models.DTO;
using Domain.Models.Intefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public class CustomerServices
    {
        private readonly ICustomer _customer;//todo lo private llleva _(guion bajo)

        public CustomerServices(ICustomer customer)
        {

            _customer = customer;

        }
        public async Task<List<CustomerDTO>> GetCustomers()
        {
            return await _customer.GetCustomers();
        }
        public async Task<CustomerDTO>GetCustomersById(string CustomerID)
        {
            return await _customer.GetCustomerById(CustomerID);
        }
    }
}
