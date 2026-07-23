using Domain.Models.DTO;
using Domain.Models.Interfaces;

namespace Domain.Services
{
    public class SupplierService
    {
        private readonly ISupplier _supplier;

        public SupplierService(ISupplier supplier)
        {
            _supplier = supplier;
        }

        public async Task<List<SupplierDto>> GetSuppliers()
        {
            return await _supplier.GetSuppliers();
        }

        public async Task<SupplierDto?> GetSupplierById(int id)
        {
            return await _supplier.GetSupplierById(id);
        }

        public async Task<List<SupplierDto>> GetSuppliersByCountry(string country)
        {
            return await _supplier.GetSuppliersByCountry(country);
        }

        public async Task AddSupplier(SupplierDto supplier)
        {
            await _supplier.AddSupplier(supplier);
        }

        public async Task UpdateSupplier(SupplierDto supplier)
        {
            await _supplier.UpdateSupplier(supplier);
        }

        public async Task DeleteSupplier(int id)
        {
            await _supplier.DeleteSupplier(id);
        }
    }
}
