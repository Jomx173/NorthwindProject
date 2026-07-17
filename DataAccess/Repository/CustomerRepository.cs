<<<<<<< HEAD
﻿using System;
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
=======
﻿using DataAccess.Context;
using DataAccess.Models;
using Domain.Models.DTO;
using Domain.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CustomerRepository : ICustomer
    {
        private readonly NorthWindContext _context;

        public CustomerRepository(NorthWindContext context)
        {
            _context = context;
        }

        // Obtener todos los clientes
        public async Task<List<CustomerDto>> GetCustomers()
        {
            return await _context.Customers
                .Select(c => new CustomerDto
                {
                    CustomerID = c.CustomerID,
                    CompanyName = c.CompanyName,
                    ContactName = c.ContactName,
                    City = c.City
                })
                .ToListAsync();
        }

        // Buscar cliente por ID
        public async Task<CustomerDto?> GetCustomerById(string customerId)
        {
            var c = await _context.Customers.FindAsync(customerId);

            if (c == null)
                return null;

            return new CustomerDto
            {
                CustomerID = c.CustomerID,
                CompanyName = c.CompanyName,
                ContactName = c.ContactName,
                City = c.City
            };
        }

        // Buscar por empresa, ciudad o país
        public async Task<List<CustomerDto>> SearchCustomers(string texto)
        {
            return await _context.Customers
                .Where(c =>
                    c.CompanyName.Contains(texto) ||
                    c.City.Contains(texto) ||
                    c.Country.Contains(texto))
                .Select(c => new CustomerDto
                {
                    CustomerID = c.CustomerID,
                    CompanyName = c.CompanyName,
                    ContactName = c.ContactName,
                    City = c.City
                })
                .ToListAsync();
        }

        // Registrar cliente
        public async Task AddCustomer(CustomerDto customer)
        {
            var entity = new Customer
            {
                CustomerID = customer.CustomerID,
                CompanyName = customer.CompanyName,
                ContactName = customer.ContactName,
                City = customer.City
            };

            _context.Customers.Add(entity);
            await _context.SaveChangesAsync();
        }

        // Modificar cliente
        public async Task UpdateCustomer(CustomerDto customer)
        {
            var entity = await _context.Customers.FindAsync(customer.CustomerID);

            if (entity != null)
            {
                entity.CompanyName = customer.CompanyName;
                entity.ContactName = customer.ContactName;
                entity.City = customer.City;

                _context.Customers.Update(entity);
                await _context.SaveChangesAsync();
            }
        }

        // Eliminar cliente
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
>>>>>>> origin/gestion-clientes
