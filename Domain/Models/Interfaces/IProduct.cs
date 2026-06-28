using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.DTO;
namespace Domain.Models.Interfaces
{
    public interface IProduct
    {
        Task<List<ProductDto>> GetProducts();

        Task<ProductDto> GetProductById(string productId);
    }
}