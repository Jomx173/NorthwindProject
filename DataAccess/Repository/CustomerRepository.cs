using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using Domain.Interfaces;
using Domain.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    internal class CustomerRepository : ICustomer
    {
        private readonly NorthWindContext _context;
        public CustomerRepository (NorthWindContext context)
        {
            _context = context;
        }
        public async Task<CustomerDto> GetCustomerById(string CustomerId)
        {
            var customer = await _context.Customers.AsNoTracking().
                FirstOrDefaultAsync(c => c.CustomerId == CustomerId);
            return customer is null ? null : CustomerMap.ToDto(customer);
            
        }

        public Task<List<CustomerDto>> GetCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
