using Domain.Models.DTO;
using Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class CustomerService : ICustomer
    {
        private readonly ICustomer _customer;

        public CustomerService(ICustomer customer)
        {
            _customer = customer;
        }

        public async Task<List<CustomerDto>> GetCustomers()
        {
            return await _customer.GetCustomers();
        }

        public async Task<CustomerDto> GetCustomerById(string customerId)
        {
            return await _customer.GetCustomerById(customerId);
        }
    }
}