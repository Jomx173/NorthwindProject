using DataAccess.Models;
using Domain.DTO;
using Domain.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductMap
    {
        public static ProductDto ToDto(Product product)
        {
            return new ProductDto
            {
                ProductName = product.ProductName,
                UnitPrice = product.UnitPrice ?? 0,
                UnitsInStock = product.UnitsInStock ?? 0,
                Discontinued = product.Discontinued
            };
        }
    }
}