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

        // Obtener todos los clientes
        public async Task<List<CustomerDto>> GetCustomers()
        {
            return await _customer.GetCustomers();
        }

        // Buscar cliente por ID
        public async Task<CustomerDto?> GetCustomerById(string customerId)
        {
            return await _customer.GetCustomerById(customerId);
        }

        // Buscar por empresa, ciudad o país
        public async Task<List<CustomerDto>> SearchCustomers(string texto)
        {
            return await _customer.SearchCustomers(texto);
        }

        // Registrar un nuevo cliente
        public async Task AddCustomer(CustomerDto customer)
        {
            await _customer.AddCustomer(customer);
        }

        // Modificar cliente existente
        public async Task UpdateCustomer(CustomerDto customer)
        {
            await _customer.UpdateCustomer(customer);
        }

        // Eliminar cliente
        public async Task DeleteCustomer(string customerId)
        {
            await _customer.DeleteCustomer(customerId);
        }
    }
}
