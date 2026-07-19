using System;
using System.Collections.Generic;
using Domain;
using DataAccess;
using ISupplier;

using MiCategoria = Domain.Category;

namespace NorthwindAdmin
{
    public class CategoryService
    {
        private readonly ICategory _categoryRepository;

        public CategoryService()
        {
            // Instanciamos el repositorio que está en tu capa DataAccess
            _categoryRepository = new CategoryRepository();
        }

        public List<MiCategoria> ListarCategorias()
        {
            return _categoryRepository.ObtenerTodasLasCategorias();
        }

        // 🔄 CAMBIADO: Ahora retorna una lista de ProductDto en lugar de Product de Dominio
        public List<ProductDto> ListarProductosPorCategoria(int categoryId)
        {
            if (categoryId <= 0) return new List<ProductDto>();

            var listaDto = new List<ProductDto>();
            var productosDominio = _categoryRepository.ObtenerProductosPorCategoria(categoryId);

            foreach (var prod in productosDominio)
            {
                listaDto.Add(new ProductDto
                {
                    Id = prod.ProductID,
                    Nombre = prod.ProductName,
                    Precio = prod.UnitPrice,
                    Stock = prod.UnitsInStock
                });
            }

            return listaDto;
        }

        public string GuardarCategoria(MiCategoria categoria)
        {
            if (string.IsNullOrWhiteSpace(categoria.CategoryName))
            {
                return "El nombre de la categoría es obligatorio.";
            }

            bool resultado = categoria.CategoryID == 0
                ? _categoryRepository.RegistrarCategoria(categoria)
                : _categoryRepository.ActualizarCategoria(categoria);

            return resultado ? "OK" : "Error al guardar en la base de datos.";
        }

        public string EliminarCategoria(int categoryId)
        {
            try
            {
                bool resultado = _categoryRepository.EliminarCategoria(categoryId);
                return resultado ? "OK" : "No se encontró la categoría.";
            }
            catch (Exception)
            {
                return "No se puede eliminar la categoría porque contiene productos asignados.";
            }
        }
    }
}