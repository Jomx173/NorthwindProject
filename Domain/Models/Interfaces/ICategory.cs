using Domain.Models.DTO;

namespace Domain.Interfaces
{
    public interface ICategory
    {
        // Obtiene la lista de categorías
        Task<List<CategoryDto>> GetCategories();
    }
}