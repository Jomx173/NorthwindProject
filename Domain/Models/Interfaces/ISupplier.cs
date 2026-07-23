using Domain.Models.DTO;

namespace Domain.Models.Interfaces
{
    public interface ISupplier
    {
        Task<List<SupplierDto>> GetSuppliers();
        Task<SupplierDto?> GetSupplierById(int id);
        Task<List<SupplierDto>> GetSuppliersByCountry(string country);
        Task AddSupplier(SupplierDto supplier);
        Task UpdateSupplier(SupplierDto supplier);
        Task DeleteSupplier(int id);
    }
}
