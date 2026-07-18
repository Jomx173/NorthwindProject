using Domain.Models.DTO;
using Domain.Models.Interfaces;

namespace NorthwindAdmin
{
    public class CategoryService
    {
        private readonly ICategory _categoryRepository;

        public CategoryService(ICategory categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Task<List<CategoryDto>> ListarCategorias()
            => _categoryRepository.GetCategories();

        public Task<bool> CreateCategory(CategoryDto category)
            => _categoryRepository.CreateCategory(category);

        public Task<bool> UpdateCategory(CategoryDto category)
            => _categoryRepository.UpdateCategory(category);

        public Task<bool> DeleteCategory(int id)
            => _categoryRepository.DeleteCategory(id);
    }
}
