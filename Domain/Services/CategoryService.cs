using Domain.Interfaces;
using Domain.Models.DTO;

namespace Domain.Services
{
    public class CategoryService : ICategory
    {
        private readonly ICategory _category;

        public CategoryService(ICategory category)
        {
            _category = category;
        }

        public async Task<List<CategoryDto>> GetCategories()
        {
            return await _category.GetCategories();
        }

        public async Task<CategoryDto?> GetCategoryById(int id)
        {
            return await _category.GetCategoryById(id);
        }

        public async Task AddCategory(CategoryDto category)
        {
            await _category.AddCategory(category);
        }

        public async Task UpdateCategory(CategoryDto category)
        {
            await _category.UpdateCategory(category);
        }

        public async Task DeleteCategory(int id)
        {
            await _category.DeleteCategory(id);
        }
    }
}
