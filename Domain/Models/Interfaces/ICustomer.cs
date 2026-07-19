using Domain.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Models.Interfaces
{
    public interface ICustomer
    {
        // Consultar todos los clientes
        Task<List<CustomerDto>> GetCustomers();

        // Buscar cliente por ID
        Task<CustomerDto?> GetCustomerById(string customerId);

        // Buscar por empresa, ciudad o país
        Task<List<CustomerDto>> SearchCustomers(string texto);

        // Registrar un nuevo cliente
        Task AddCustomer(CustomerDto customer);

        // Modificar cliente existente
        Task UpdateCustomer(CustomerDto customer);

        // Eliminar cliente
        Task DeleteCustomer(string customerId);
    }
}