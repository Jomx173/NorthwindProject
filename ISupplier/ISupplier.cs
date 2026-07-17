using System;
using System.Collections.Generic;
// Apuntamos directo a la clase del Dominio para evitar confusiones de nombres
using MiProveedor = Domain.Supplier;

namespace ProyectoProveedores
{
    public interface ISupplier
    {
        bool RegistrarProveedor(MiProveedor proveedor);
        bool ActualizarProveedor(MiProveedor proveedor);
        List<Product> ObtenerProductosPorProveedor(int supplierId);
        List<MiProveedor> BuscarProveedoresPorPais(string pais);
    }
}