using Domain.Interfaces;
using Domain.Models.DTO;

namespace Domain.Services
{
    public class ProductService : IProduct
    {
        private readonly IProduct _product;

        public ProductService(IProduct product)
        {
            _product = product;
        }

        public async Task<List<ProductDto>> GetProducts()
        {
            return await _product.GetProducts();
        }

        public async Task<ProductDto> GetProductById(int productId)
        {
            return await _product.GetProductById(productId);
        }
    }
}