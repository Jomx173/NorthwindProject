using DataAccess.Context;
using DataAccess.Models;
using Domain.Models.DTO;
using Domain.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    internal class CategoryRepository : ICategory
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
                .Select(c => new CategoryDto
                {
                    CategoryId = c.CategoryId,
                    CategoryName = c.CategoryName,
                    Description = c.Description
                })
                .ToListAsync();
        }

        public async Task<CategoryDto?> GetCategoryById(int id)
        {
            var category = await _context.Categories
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.CategoryId == id);

            return category == null ? null : CategoryMap.ToDto(category);
        }

        public async Task<bool> CreateCategory(CategoryDto dto)
        {
            var entity = CategoryMap.ToEntity(dto);

            _context.Categories.Add(entity);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateCategory(CategoryDto dto)
        {
            var entity = await _context.Categories
                .FirstOrDefaultAsync(c => c.CategoryId == dto.CategoryId);

            if (entity == null)
                return false;

            entity.CategoryName = dto.CategoryName;
            entity.Description = dto.Description;

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteCategory(int id)
        {
            var entity = await _context.Categories
                .FirstOrDefaultAsync(c => c.CategoryId == id);

            if (entity == null)
                return false;

            _context.Categories.Remove(entity);

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
