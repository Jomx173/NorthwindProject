using DataAccess.Context;
using DataAccess.Models;
using Domain.Interfaces;
using Domain.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly NorthWindContext _context;

        public ProductRepository(NorthWindContext context)
        {
            _context = context;
        }

        // Obtiene todos los productos
        public async Task<List<ProductDto>> GetProducts()
        {
            return await _context.Products
                .AsNoTracking()
                .Select(p => new ProductDto
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    UnitPrice = p.UnitPrice,
                    UnitsInStock = p.UnitsInStock
                })
                .ToListAsync();
        }

        // Busca un producto por su ID
        public async Task<ProductDto?> GetProductById(int productId)
        {
            return await _context.Products
                .AsNoTracking()
                .Where(p => p.ProductId == productId)
                .Select(p => new ProductDto
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    UnitPrice = p.UnitPrice,
                    UnitsInStock = p.UnitsInStock
                })
                .FirstOrDefaultAsync();
        }

        // Obtiene los productos de una categoría
        public async Task<List<ProductDto>> GetProductsByCategory(int categoryId)
        {
            return await _context.Products
                .AsNoTracking()
                .Where(p => p.CategoryId == categoryId)
                .Select(p => new ProductDto
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    UnitPrice = p.UnitPrice,
                    UnitsInStock = p.UnitsInStock
                })
                .ToListAsync();
        }

        // Obtiene los productos de un proveedor
        public async Task<List<ProductDto>> GetProductsBySupplier(int supplierId)
        {
            return await _context.Products
                .AsNoTracking()
                .Where(p => p.SupplierId == supplierId)
                .Select(p => new ProductDto
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    UnitPrice = p.UnitPrice,
                    UnitsInStock = p.UnitsInStock,
                    SupplierId = p.SupplierId
                })
                .ToListAsync();
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

        // Actualiza un producto
        public async Task UpdateProduct(ProductDto productDto)
        {
            var product = await _context.Products.FindAsync(productDto.ProductId);

            if (product == null)
                return;

            product.ProductName = productDto.ProductName;
            product.UnitPrice = productDto.UnitPrice;
            product.UnitsInStock = productDto.UnitsInStock;

            await _context.SaveChangesAsync();
        }

        // Elimina un producto
        public async Task DeleteProduct(int productId)
        {
            var product = await _context.Products.FindAsync(productId);

            if (product == null)
                return;

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}