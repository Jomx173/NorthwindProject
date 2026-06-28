using DataAccess.Context;
using DataAccess.Context;
using Domain.DTO;
using Domain.Models.DTO;
using Domain.Models.DTO;
using Domain.Models.Interfaces;
using Domain.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly NorthwindContext _context;

        public ProductRepository(NorthwindContext context)
        {
            _context = context;
        }

        public async Task<ProductDto> GetProductById(string productId)
        {
            var product = await _context.Products
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.ProductId.ToString() == productId);

            return product is null ? null : ProductMap.ToDto(product);
        }

        public async Task<List<ProductDto>> GetProducts()
        {
            var products = await _context.Products
                .AsNoTracking()
                .ToListAsync();

            return products.Select(p => ProductMap.ToDto(p)).ToList();
        }
    }
}