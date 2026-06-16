using DataAccess.Context;
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

        public async Task<ProductDto> GetProductById(int productId)
        {
            var product = await _context.Products
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.ProductId == productId);

            return product is null ? null : ProductMap.ToDto(product);
        }

        public async Task<List<ProductDto>> GetProducts()
        {
            return await _context.Products
                .AsNoTracking()
                .Select(p => ProductMap.ToDto(p))
                .ToListAsync();
        }
    }
}