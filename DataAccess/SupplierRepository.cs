using System;
using System.Collections.Generic;
using System.Data.SqlClient;
// Usamos el alias directo apuntando a la clase del Dominio
using MiProveedor = Domain.Supplier;

namespace ProyectoProveedores
{
    public class SupplierRepository : ISupplier
    {
        private readonly string _connectionString = "Server=localhost;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;";

        public bool RegistrarProveedor(MiProveedor proveedor)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Suppliers (CompanyName, ContactName, Country, Phone) VALUES (@Comp, @Cont, @Country, @Phone)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Comp", proveedor.CompanyName);
                cmd.Parameters.AddWithValue("@Cont", proveedor.ContactName ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Country", proveedor.Country ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Phone", proveedor.Phone ?? (object)DBNull.Value);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool ActualizarProveedor(MiProveedor proveedor)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Suppliers SET CompanyName = @Comp, ContactName = @Cont, Country = @Country, Phone = @Phone WHERE SupplierID = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", proveedor.SupplierID);
                cmd.Parameters.AddWithValue("@Comp", proveedor.CompanyName);
                cmd.Parameters.AddWithValue("@Cont", proveedor.ContactName ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Country", proveedor.Country ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Phone", proveedor.Phone ?? (object)DBNull.Value);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<Product> ObtenerProductosPorProveedor(int supplierId)
        {
            var productos = new List<Product>();
            using (var conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT ProductID, ProductName, UnitPrice, UnitsInStock FROM Products WHERE SupplierID = @SupId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SupId", supplierId);

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productos.Add(new Product
                        {
                            ProductID = (int)reader["ProductID"],
                            ProductName = reader["ProductName"].ToString(),
                            UnitPrice = reader["UnitPrice"] as decimal?,
                            UnitsInStock = reader["UnitsInStock"] as short?
                        });
                    }
                }
            }
            return productos;
        }

        public List<MiProveedor> BuscarProveedoresPorPais(string pais)
        {
            var proveedores = new List<MiProveedor>();
            using (var conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT SupplierID, CompanyName, ContactName, Country, Phone FROM Suppliers WHERE Country LIKE @Pais";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Pais", "%" + pais + "%");

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        proveedores.Add(new MiProveedor
                        {
                            SupplierID = (int)reader["SupplierID"],
                            CompanyName = reader["CompanyName"].ToString(),
                            ContactName = reader["ContactName"].ToString(),
                            Country = reader["Country"].ToString(),
                            Phone = reader["Phone"].ToString()
                        });
                    }
                }
            }
            return proveedores;
        }
    }
}