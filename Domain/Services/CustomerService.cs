using Domain.Models.DTO;
using Domain.Models.Interfaces;
using System.Collections.Generic;
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

        public async Task<CustomerDto?> GetCustomerById(string customerId)
        {
            return await _customer.GetCustomerById(customerId);
        }

        public async Task<List<CustomerDto>> SearchCustomers(string texto)
        {
            return await _customer.SearchCustomers(texto);
        }

        public async Task AddCustomer(CustomerDto customer)
        {
            await _customer.AddCustomer(customer);
        }

        public async Task UpdateCustomer(CustomerDto customer)
        {
            await _customer.UpdateCustomer(customer);
        }

        public async Task DeleteCustomer(string customerId)
        {
            await _customer.DeleteCustomer(customerId);
        }
    }
}