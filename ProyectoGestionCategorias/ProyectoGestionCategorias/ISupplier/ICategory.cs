using System.Collections.Generic;
using Domain; 

namespace ISupplier 
{
    public interface ICategory
    {
        bool RegistrarCategoria(Category categoria);
        bool ActualizarCategoria(Category categoria);
        bool EliminarCategoria(int categoryId);
        List<Product> ObtenerProductosPorCategoria(int categoryId); 
        List<Category> ObtenerTodasLasCategorias();
    }
}