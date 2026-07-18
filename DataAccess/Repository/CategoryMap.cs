using DataAccess.Models;
using Domain.Models.DTO;

namespace DataAccess.Repository
{
    internal static class CategoryMap
    {
        public static CategoryDto ToDto(Category category)
        {
            return new CategoryDto
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
                Description = category.Description
            };
        }

        public static Category ToEntity(CategoryDto dto)
        {
            return new Category
            {
                CategoryId = dto.CategoryId,
                CategoryName = dto.CategoryName,
                Description = dto.Description
            };
        }
    }
}
