using DataAccess.Context;
using DataAccess.Models;
using Domain.Interfaces;
using Domain.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    internal class ProductRepository : IProduct
    {
        private readonly NorthWindContext _context;

        public ProductRepository(NorthWindContext context)
        {
            _context = context;
        }

        // Busca un producto por su ID
        public async Task<ProductDto> GetProductById(int productId)
        {
            var product = await _context.Products
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.ProductId == productId);

            return product is null ? null : ProductMap.ToDto(product);
        }

        // Obtiene la lista de todos los productos
        public async Task<List<ProductDto>> GetProducts()
        {
            return await _context.Products
                .AsNoTracking()
                .Select(p => ProductMap.ToDto(p))
                .ToListAsync();
        }

        // Actualiza la información de un producto
        public async Task UpdateProduct(ProductDto productDto)
        {
            var product = await _context.Products
                .FirstOrDefaultAsync(p => p.ProductId == productDto.ProductId);

            if (product != null)
            {
                product.ProductName = productDto.ProductName;
                product.UnitPrice = productDto.UnitPrice;
                product.UnitsInStock = productDto.UnitsInStock;

                await _context.SaveChangesAsync();
            }
        }

        // Agrega un nuevo producto
        public async Task AddProduct(ProductDto productDto)
        {
            var product = new Product
            {
                ProductName = productDto.ProductName,
                UnitPrice = productDto.UnitPrice,
                UnitsInStock = productDto.UnitsInStock
            };

            _context.Products.Add(product);

            await _context.SaveChangesAsync();
        }
        // Elimina un producto por su ID
        public async Task DeleteProduct(int productId)
        {
            var product = await _context.Products
                .FirstOrDefaultAsync(p => p.ProductId == productId);

            if (product != null)
            {
                _context.Products.Remove(product);

                await _context.SaveChangesAsync();
            }
        }
        // Obtiene los productos de una categoría
        public async Task<List<ProductDto>> GetProductsByCategory(int categoryId)
        {
            return await _context.Products
                .AsNoTracking()
                .Where(p => p.CategoryId == categoryId)
                .Select(p => ProductMap.ToDto(p))
                .ToListAsync();
        }
    }
}