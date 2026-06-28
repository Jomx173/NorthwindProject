using Domain.DTO;
using Domain.Models.DTO;
using Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<ProductDto> GetProductById(string productId)
        {
            return await _product.GetProductById(productId);
        }
    }
}