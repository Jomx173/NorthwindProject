using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Context;
using Domain.Interfaces;
using Domain.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    internal class ProductRepository : IProductRepository
    {
        private readonly NorthWindContext _context;
        public ProductRepository(NorthWindContext context)
        {
            _context = context;
        }

        public async Task<List<ProductDto>> GetAllProducts()
        {
            return await _context.Products
                .AsNoTracking()
                .Select(p => new ProductDto
                {
                    Id = p.ProductId,
                    ProductName = p.ProductName,
                    UnitsInStock = p.UnitsInStock,
                    UnitsOnOrder = p.UnitsOnOrder,
                    ReorderLevel = p.ReorderLevel,
                    UnitPrice = p.UnitPrice
                })
                .ToListAsync();
        }

        public async Task<List<ProductDto>> GetLowStockProducts(int threshold)
        {
            return await _context.Products
                .AsNoTracking()
                .Where(p => p.UnitsInStock <= threshold)
                .Select(p => new ProductDto
                {
                    Id = p.ProductId,
                    ProductName = p.ProductName,
                    UnitsInStock = p.UnitsInStock,
                    UnitsOnOrder = p.UnitsOnOrder,
                    ReorderLevel = p.ReorderLevel,
                    UnitPrice = p.UnitPrice
                })
                .ToListAsync();
        }

        public async Task<List<ProductDto>> GetOutOfStockProducts()
        {
            return await _context.Products
                .AsNoTracking()
                .Where(p => p.UnitsInStock <= 0)
                .Select(p => new ProductDto
                {
                    Id = p.ProductId,
                    ProductName = p.ProductName,
                    UnitsInStock = p.UnitsInStock,
                    UnitsOnOrder = p.UnitsOnOrder,
                    ReorderLevel = p.ReorderLevel,
                    UnitPrice = p.UnitPrice
                })
                .ToListAsync();
        }

        public async Task<List<ProductDto>> GetTopSellingProducts(int topN)
        {
            var top = await _context.OrderDetails
                .AsNoTracking()
                .GroupBy(od => od.ProductId)
                .Select(g => new { ProductId = g.Key, Quantity = g.Sum(od => od.Quantity) })
                .OrderByDescending(x => x.Quantity)
                .Take(topN)
                .ToListAsync();

            var productIds = top.Select(t => t.ProductId).ToList();

            var products = await _context.Products
                .AsNoTracking()
                .Where(p => productIds.Contains(p.ProductId))
                .ToListAsync();

            var ordered = top.Join(products,
                                    t => t.ProductId,
                                    p => p.ProductId,
                                    (t, p) => new { Product = p, t.Quantity })
                             .OrderByDescending(x => x.Quantity)
                             .Select(x => new ProductDto
                             {
                                 Id = x.Product.ProductId,
                                 ProductName = x.Product.ProductName,
                                 UnitsInStock = x.Product.UnitsInStock,
                                 UnitsOnOrder = x.Product.UnitsOnOrder,
                                 ReorderLevel = x.Product.ReorderLevel,
                                 UnitPrice = x.Product.UnitPrice
                             })
                             .ToList();

            return ordered;
        }
    }
}