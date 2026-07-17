using Domain.Models.DTO;
<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
=======
using System.Collections.Generic;
>>>>>>> origin/gestion-clientes
using System.Threading.Tasks;

namespace Domain.Models.Interfaces
{
    public interface ICustomer
    {
<<<<<<< HEAD
        Task<List<CustomerDto>> GetCustomers();

        Task<CustomerDto> GetCustomerById(string customerId);
    }
}
=======
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
>>>>>>> origin/gestion-clientes
