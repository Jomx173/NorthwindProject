using Domain.Models.DTO;

namespace Domain.Interfaces
{
    public interface IProduct
    {
        // Obtiene la lista de todos los productos
        Task<List<ProductDto>> GetProducts();

        // Busca un producto específico por su ID
        Task<ProductDto> GetProductById(int productId);

        // Actualiza la información de un producto
        Task UpdateProduct(ProductDto product);

        // Agrega un nuevo producto
        Task AddProduct(ProductDto product);

        // Elimina un producto por su ID
        Task DeleteProduct(int productId);

        // Obtiene los productos de una categoría
        Task<List<ProductDto>> GetProductsByCategory(int categoryId);
        Task<List<ProductDto>> GetProductsBySupplier(int supplierId);
    }
}