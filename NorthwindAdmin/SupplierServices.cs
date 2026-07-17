using System;
using System.Collections.Generic;
using MiProveedor = Domain.Supplier;

namespace ProyectoProveedores
{
    public class SupplierServices
    {
        private readonly ISupplier _supplierRepository;

        public SupplierServices(ISupplier supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public string Registrar(MiProveedor proveedor)
        {
            if (string.IsNullOrEmpty(proveedor.CompanyName))
                return "El nombre de la empresa es obligatorio.";

            bool exito = _supplierRepository.RegistrarProveedor(proveedor);
            return exito ? "Proveedor registrado con éxito." : "Error al registrar el proveedor.";
        }

        public string Actualizar(MiProveedor proveedor)
        {
            if (proveedor.SupplierID <= 0)
                return "ID de proveedor inválido.";

            bool exito = _supplierRepository.ActualizarProveedor(proveedor);
            return exito ? "Proveedor actualizado con éxito." : "Error al actualizar el proveedor.";
        }

        public List<Product> ListarProductosSuministrados(int supplierId)
        {
            return _supplierRepository.ObtenerProductosPorProveedor(supplierId);
        }

        public List<SupplierDto> FiltrarProveedoresPorPais(string pais)
        {
            var listaDto = new List<SupplierDto>();
            var proveedores = _supplierRepository.BuscarProveedoresPorPais(pais);

            foreach (var s in proveedores)
            {
                listaDto.Add(new SupplierDto
                {
                    Id = s.SupplierID,
                    Empresa = s.CompanyName,
                    Contacto = s.ContactName,
                    Pais = s.Country,
                    Telefono = s.Phone
                });
            }

            return listaDto;
        }
    }
}