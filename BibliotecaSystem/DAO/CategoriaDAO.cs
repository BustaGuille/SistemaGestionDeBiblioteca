using BibliotecaSystem.Datos;
using BibliotecaSystem.Entidades;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace BibliotecaSystem.DAO
{
    public class CategoriaDAO
    {
        public void AgregarCategoria(Categoria categoria)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "INSERT INTO Categorias (NombreCategoria) VALUES (@NombreCategoria)";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombreCategoria", categoria.NombreCategoria);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar categoría: " + ex.Message);
            }
        }

        public void ModificarCategoria(Categoria categoria)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "UPDATE Categorias SET NombreCategoria = @NombreCategoria WHERE IdCategoria = @IdCategoria";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombreCategoria", categoria.NombreCategoria);
                    cmd.Parameters.AddWithValue("@IdCategoria", categoria.IdCategoria);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar categoría: " + ex.Message);
            }
        }

        public void EliminarCategoria(int idCategoria)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "DELETE FROM Categorias WHERE IdCategoria = @IdCategoria";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar categoría: " + ex.Message);
            }
        }

        public Categoria ObtenerCategoriaPorId(int idCategoria)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "SELECT IdCategoria, NombreCategoria FROM Categorias WHERE IdCategoria = @IdCategoria";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
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
                throw new Exception("Error al obtener categoría: " + ex.Message);
            }

            return null;
        }

        public List<Categoria> ListarCategorias()
        {
            List<Categoria> lista = new List<Categoria>();

            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "SELECT IdCategoria, NombreCategoria FROM Categorias";
                    var cmd = new SqlCommand(query, conn);
                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
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
                throw new Exception("Error al listar categorías: " + ex.Message);
            }

            return lista;
        }
    }
}
