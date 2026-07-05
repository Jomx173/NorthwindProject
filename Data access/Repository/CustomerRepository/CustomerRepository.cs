using Data_access.Context;
using Domain.Models.DTO;
using Domain.Models.Intefaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Data_access.Repository.CustomerRepository
{
    public class CustomerRepository : ICustomer
    {
        public readonly NorthWindContext _context;
        public CustomerRepository(NorthWindContext context) {

            _context = context;


                }
        public async Task<CustomerDTO> GetCustomerById(string CustomerId)
        {
            var mapper = new CustomerMap();
            var customer = await _context.Customers
                .AsTracking()
                .FirstOrDefaultAsync(c=> c.CustomerId == CustomerId);

            return customer is null? null: CustomerMap.ToDto(customer);
        }

        public Task<List<CustomerDTO>> GetCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
