using DataAccess.Context;
using DataAccess.Models;
using Domain.Models.DTO;
using Domain.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    public class CustomerRepository : ICustomer
    {
        private readonly NorthWindContext _context;

        public CustomerRepository(NorthWindContext context)
        {
            _context = context;
        }

        public async Task<List<CustomerDto>> GetCustomers()
        {
            return await _context.Customers
                .Select(c => new CustomerDto
                {
                    CustomerId = c.CustomerId,
                    CompanyName = c.CompanyName,
                    ContactName = c.ContactName,
                    ContactTitle = c.ContactTitle,
                    Phone = c.Phone,
                    City = c.City
                })
                .ToListAsync();
        }

        public async Task<CustomerDto?> GetCustomerById(string customerId)
        {
            var c = await _context.Customers.FindAsync(customerId);

            if (c == null)
                return null;

            return new CustomerDto
            {
                CustomerId = c.CustomerId,
                CompanyName = c.CompanyName,
                ContactName = c.ContactName,
                ContactTitle = c.ContactTitle,
                Phone = c.Phone,
                City = c.City
            };
        }

        public async Task<List<CustomerDto>> SearchCustomers(string texto)
        {
            return await _context.Customers
                .Where(c =>
                    c.CompanyName.Contains(texto) ||
                    (c.City != null && c.City.Contains(texto)) ||
                    (c.Country != null && c.Country.Contains(texto)))
                .Select(c => new CustomerDto
                {
                    CustomerId = c.CustomerId,
                    CompanyName = c.CompanyName,
                    ContactName = c.ContactName,
                    ContactTitle = c.ContactTitle,
                    Phone = c.Phone,
                    City = c.City
                })
                .ToListAsync();
        }

        public async Task AddCustomer(CustomerDto customer)
        {
            var entity = new Customer
            {
                CustomerId = customer.CustomerId,
                CompanyName = customer.CompanyName,
                ContactName = customer.ContactName,
                ContactTitle = customer.ContactTitle,
                Phone = customer.Phone,
                City = customer.City
            };

            _context.Customers.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCustomer(CustomerDto customer)
        {
            var entity = await _context.Customers.FindAsync(customer.CustomerId);

            if (entity != null)
            {
                entity.CompanyName = customer.CompanyName;
                entity.ContactName = customer.ContactName;
                entity.ContactTitle = customer.ContactTitle;
                entity.Phone = customer.Phone;
                entity.City = customer.City;

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteCustomer(string customerId)
        {
            var entity = await _context.Customers.FindAsync(customerId);

            if (entity != null)
            {
                _context.Customers.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}