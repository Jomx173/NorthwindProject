using DataAccess.Context;
using DataAccess.Models;
using Domain.Models.DTO;
using Domain.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    public class SupplierRepository : ISupplier
    {
        private readonly NorthWindContext _context;

        public SupplierRepository(NorthWindContext context)
        {
            _context = context;
        }

        public async Task<List<SupplierDto>> GetSuppliers()
        {
            return await _context.Suppliers
                .AsNoTracking()
                .Select(s => new SupplierDto
                {
                    SupplierId = s.SupplierId,
                    CompanyName = s.CompanyName,
                    ContactName = s.ContactName,
                    Country = s.Country,
                    Phone = s.Phone
                })
                .ToListAsync();
        }

        public async Task<SupplierDto?> GetSupplierById(int id)
        {
            return await _context.Suppliers
                .AsNoTracking()
                .Where(s => s.SupplierId == id)
                .Select(s => new SupplierDto
                {
                    SupplierId = s.SupplierId,
                    CompanyName = s.CompanyName,
                    ContactName = s.ContactName,
                    Country = s.Country,
                    Phone = s.Phone
                })
                .FirstOrDefaultAsync();
        }

        public async Task<List<SupplierDto>> GetSuppliersByCountry(string country)
        {
            return await _context.Suppliers
                .AsNoTracking()
                .Where(s => s.Country != null && s.Country.Contains(country))
                .Select(s => new SupplierDto
                {
                    SupplierId = s.SupplierId,
                    CompanyName = s.CompanyName,
                    ContactName = s.ContactName,
                    Country = s.Country,
                    Phone = s.Phone
                })
                .ToListAsync();
        }

        public async Task AddSupplier(SupplierDto supplierDto)
        {
            var supplier = new Supplier
            {
                CompanyName = supplierDto.CompanyName,
                ContactName = supplierDto.ContactName,
                Country = supplierDto.Country,
                Phone = supplierDto.Phone
            };

            _context.Suppliers.Add(supplier);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateSupplier(SupplierDto supplierDto)
        {
            var supplier = await _context.Suppliers.FindAsync(supplierDto.SupplierId);

            if (supplier == null)
                return;

            supplier.CompanyName = supplierDto.CompanyName;
            supplier.ContactName = supplierDto.ContactName;
            supplier.Country = supplierDto.Country;
            supplier.Phone = supplierDto.Phone;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteSupplier(int id)
        {
            var supplier = await _context.Suppliers.FindAsync(id);

            if (supplier == null)
                return;

            _context.Suppliers.Remove(supplier);
            await _context.SaveChangesAsync();
        }
    }
}
