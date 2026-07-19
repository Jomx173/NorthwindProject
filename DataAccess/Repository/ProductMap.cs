using DataAccess.Models;
using Domain.Models.DTO;

namespace DataAccess.Repository
{
    internal class ProductMap
    {
        public static ProductDto ToDto(Product product)
        {
            return new ProductDto
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                UnitPrice = product.UnitPrice,
                UnitsInStock = product.UnitsInStock
            };
        }
    }
}