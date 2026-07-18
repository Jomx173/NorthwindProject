using Domain.Models.DTO;

namespace Domain.Models.Interfaces
{
    public interface ICategory
    {
        Task<List<CategoryDto>> GetCategories();

        Task<CategoryDto?> GetCategoryById(int id);

        Task<bool> CreateCategory(CategoryDto category);

        Task<bool> UpdateCategory(CategoryDto category);

        Task<bool> DeleteCategory(int id);
    }
}
