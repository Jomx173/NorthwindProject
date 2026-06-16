using Domain.Models.DTO;

namespace Domain.Interfaces
{
    public interface IProduct
    {
        Task<List<ProductDto>> GetProducts();

        Task<ProductDto> GetProductById(int productId);
    }
}