using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;

namespace Domain.Services
{
    public class CustomerService
    {
        private readonly ICustomer _customer;

        public CustomerService(ICustomer customer)
        {
            _customer = customer;
        }

        public Task<List<Models.DTO.CustomerDto>> GetCustomers()
            => _customer.GetCustomers();

        public Task<Models.DTO.CustomerDto> GetCustomerById(string customerId)
            => _customer.GetCustomerById(customerId);
    }
}