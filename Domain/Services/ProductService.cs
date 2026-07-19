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

        // Actualiza la información de un producto
        public async Task UpdateProduct(ProductDto product)
        {
            await _product.UpdateProduct(product);
        }
        // Agrega un nuevo producto
        public async Task AddProduct(ProductDto product)
        {
            await _product.AddProduct(product);
        }
        // Elimina un producto por su ID
        public async Task DeleteProduct(int productId)
        {
            await _product.DeleteProduct(productId);
        }
        // Obtiene los productos de una categoría
        public async Task<List<ProductDto>> GetProductsByCategory(int categoryId)
        {
            return await _product.GetProductsByCategory(categoryId);
        }
    }
}