using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Interfaces;

namespace Domain.Services
{
  public class CustomerService : ICustomer
    {
        //todo lo privado lleva un guion bajo
        private readonly ICustomer _customer;
        
        public CustomerService(ICustomer customer)
        {
            _customer = customer;
        }

        public async Task<List<Models.DTO.CustomerDto>> GetCustomers()
        {
            return await _customer.GetCustomers();
        }

        public async Task<Models.DTO.CustomerDto> GetCustomerById(string customerId)
        {
            return await _customer.GetCustomerById(customerId);
        }

    }
}
