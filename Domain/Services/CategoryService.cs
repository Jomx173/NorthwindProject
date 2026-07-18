using Domain.Models.DTO;
using Domain.Models.Interfaces;

namespace Domain.Services
{
    public class CategoryService : ICategory
    {
        private readonly ICategory _repository;

        public CategoryService(ICategory repository)
        {
            _repository = repository;
        }

        public Task<List<CategoryDto>> GetCategories()
            => _repository.GetCategories();

        public Task<CategoryDto?> GetCategoryById(int id)
            => _repository.GetCategoryById(id);

        public Task<bool> CreateCategory(CategoryDto category)
            => _repository.CreateCategory(category);

        public Task<bool> UpdateCategory(CategoryDto category)
            => _repository.UpdateCategory(category);

        public Task<bool> DeleteCategory(int id)
            => _repository.DeleteCategory(id);
    }
}
