using Domain.Models.DTO;

namespace Domain.Interfaces
{
    public interface ICategory
    {
        // Obtiene la lista de categorías
        Task<List<CategoryDto>> GetCategories();

        Task<CategoryDto?> GetCategoryById(int id);
        Task AddCategory(CategoryDto category);
        Task UpdateCategory(CategoryDto category);
        Task DeleteCategory(int id);
    }
}