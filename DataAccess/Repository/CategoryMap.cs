using DataAccess.Models;
using Domain.Models.DTO;

namespace DataAccess.Repository
{
    internal class CategoryMap
    {
        // Convierte la entidad Category en CategoryDto
        public static CategoryDto ToDto(Category category)
        {
            return new CategoryDto
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName
            };
        }
    }
}