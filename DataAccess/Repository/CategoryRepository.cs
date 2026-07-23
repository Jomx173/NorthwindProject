using DataAccess.Context;
using DataAccess.Models;
using Domain.Interfaces;
using Domain.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly NorthWindContext _context;

        public CategoryRepository(NorthWindContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryDto>> GetCategories()
        {
            return await _context.Categories
                .AsNoTracking()
                .Select(c => CategoryMap.ToDto(c))
                .ToListAsync();
        }

        public async Task<CategoryDto?> GetCategoryById(int id)
        {
            var category = await _context.Categories
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.CategoryId == id);

            return category == null ? null : CategoryMap.ToDto(category);
        }

        public async Task AddCategory(CategoryDto category)
        {
            var entity = new Category
            {
                CategoryName = category.CategoryName,
                Description = category.Description
            };

            _context.Categories.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCategory(CategoryDto category)
        {
            var entity = await _context.Categories
                .FirstOrDefaultAsync(c => c.CategoryId == category.CategoryId);

            if (entity == null)
                return;

            entity.CategoryName = category.CategoryName;
            entity.Description = category.Description;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategory(int id)
        {
            var entity = await _context.Categories
                .FirstOrDefaultAsync(c => c.CategoryId == id);

            if (entity == null)
                return;

            _context.Categories.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
