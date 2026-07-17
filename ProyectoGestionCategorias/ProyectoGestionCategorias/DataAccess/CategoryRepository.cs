using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Domain;
using ISupplier;
using MiCategoria = Domain.Category;

namespace DataAccess
{
    public class CategoryRepository : ICategory
    {
        private readonly string _connectionString = "Server=localhost;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;";

        public bool RegistrarCategoria(MiCategoria categoria)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Categories (CategoryName, Description) VALUES (@Name, @Desc)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", categoria.CategoryName);
                cmd.Parameters.AddWithValue("@Desc", categoria.Description ?? (object)DBNull.Value);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool ActualizarCategoria(MiCategoria categoria)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Categories SET CategoryName = @Name, Description = @Desc WHERE CategoryID = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", categoria.CategoryID);
                cmd.Parameters.AddWithValue("@Name", categoria.CategoryName);
                cmd.Parameters.AddWithValue("@Desc", categoria.Description ?? (object)DBNull.Value);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool EliminarCategoria(int categoryId)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Categories WHERE CategoryID = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", categoryId);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<Product> ObtenerProductosPorCategoria(int categoryId)
        {
            var productos = new List<Product>();
            using (var conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT ProductID, ProductName, UnitPrice, UnitsInStock FROM Products WHERE CategoryID = @CatId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CatId", categoryId);

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

        public List<MiCategoria> ObtenerTodasLasCategorias()
        {
            var categorias = new List<MiCategoria>();
            using (var conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT CategoryID, CategoryName, Description FROM Categories";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categorias.Add(new MiCategoria
                        {
                            CategoryID = (int)reader["CategoryID"],
                            CategoryName = reader["CategoryName"].ToString(),
                            Description = reader["Description"].ToString()
                        });
                    }
                }
            }
            return categorias;
        }
    }
}