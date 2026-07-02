using DataAccess.Context;
using Domain.Interfaces;
using Domain.Models.DTO;
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

        // Obtiene la lista de categorías
        public async Task<List<CategoryDto>> GetCategories()
        {
            return await _context.Categories
                .AsNoTracking()
                .Select(c => CategoryMap.ToDto(c))
                .ToListAsync();
        }
    }
}