using BibliotecaSystem.Entidades;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace BibliotecaSystem.DAO
{
    public class CategoriaDAO
    {
        static string cadenaConexion = "Server=(local)\\SQLEXPRESS;Database=BibliotecaDB;Trusted_Connection=True;TrustServerCertificate=True";
        public void AgregarCategoria(Categoria categoria)
        {

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "INSERT INTO Categorias (NombreCategoria) VALUES (@NombreCategoria)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreCategoria", categoria.NombreCategoria);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error al querer agregar la categoría.");
                    throw new Exception("Error al agregar categoría: " + ex.Message);
                }
            }
        }

        public void ModificarCategoria(Categoria categoria)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "UPDATE Categorias SET NombreCategoria = @NombreCategoria WHERE IdCategoria = @IdCategoria";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreCategoria", categoria.NombreCategoria);
                cmd.Parameters.AddWithValue("@IdCategoria", categoria.IdCategoria);
                try { 
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error al querer modificar la categoría.");
                    throw new Exception("Error al modificar categoría: " + ex.Message);
                }
            }
        }

        public void EliminarCategoria(int idCategoria)
        { 
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "DELETE FROM Categorias WHERE IdCategoria = @IdCategoria";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                try { 
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error al querer eliminar la categoría.");
                    throw new Exception("Error al eliminar categoría: " + ex.Message);
                }
            }
        }

        public Categoria ObtenerCategoriaPorId(int idCategoria)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT IdCategoria, NombreCategoria FROM Categorias WHERE IdCategoria = @IdCategoria";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Categoria
                            {
                                IdCategoria = reader.GetInt32(reader.GetOrdinal("IdCategoria")),
                                NombreCategoria = reader.GetString(reader.GetOrdinal("NombreCategoria"))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al querer obtener la categoría.");
                throw new Exception("Error al obtener categoría: " + ex.Message);
            }

            return null;
        }

        public List<Categoria> ListarCategorias()
        {
            List<Categoria> lista = new List<Categoria>();

            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT IdCategoria, NombreCategoria FROM Categorias";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Categoria
                            {
                                IdCategoria = reader.GetInt32(reader.GetOrdinal("IdCategoria")),
                                NombreCategoria = reader.GetString(reader.GetOrdinal("NombreCategoria"))
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al querer listar las categorías.");
                throw new Exception("Error al listar categorías: " + ex.Message);
            }

            return lista;
        }
    }
}
