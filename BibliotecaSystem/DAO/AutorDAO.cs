using BibliotecaSystem.Datos;
using BibliotecaSystem.Entidades;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace BibliotecaSystem.DAO
{
    public class AutorDAO
    {
        public void AgregarAutor(Autor autor)
        {
            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    var query = "INSERT INTO Autores (NombreAutor, Nacionalidad) VALUES (@NombreAutor, @Nacionalidad)";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombreAutor", autor.NombreAutor);
                    cmd.Parameters.AddWithValue("@Nacionalidad", autor.Nacionalidad);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar autor: " + ex.Message);
            }
        }

        public void ModificarAutor(Autor autor)
        {
            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string query = "UPDATE Autores SET NombreAutor = @NombreAutor, Nacionalidad = @Nacionalidad WHERE IdAutor = @IdAutor";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombreAutor", autor.NombreAutor);
                    cmd.Parameters.AddWithValue("@Nacionalidad", autor.Nacionalidad);
                    cmd.Parameters.AddWithValue("@IdAutor", autor.IdAutor);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar autor: " + ex.Message);
            }
        }

        public void EliminarAutor(int idAutor)
        {
            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    string query = "DELETE FROM Autores WHERE IdAutor = @IdAutor";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdAutor", idAutor);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar autor: " + ex.Message);
            }
        }

        public Autor ObtenerAutorPorId(int idAutor)
        {
            try
            {
                using (SqlConnection conn = ConexionBD.ObtenerConexion())
                {
                    String query = "SELECT IdAutor, NombreAutor, Nacionalidad FROM Autores WHERE IdAutor = @IdAutor";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdAutor", idAutor);
                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Autor
                            {
                                IdAutor = reader.GetInt32(reader.GetOrdinal("IdAutor")),
                                NombreAutor = reader.GetString(reader.GetOrdinal("NombreAutor")),
                                Nacionalidad = reader.GetString(reader.GetOrdinal("Nacionalidad"))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener autor: " + ex.Message);
            }

            return null;
        }

        public List<Autor> ListarAutores()
        {
            List<Autor> lista = new List<Autor>();

            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "SELECT IdAutor, NombreAutor, Nacionalidad FROM Autores";
                    var cmd = new SqlCommand(query, conn);
                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Autor
                            {
                                IdAutor = reader.GetInt32(reader.GetOrdinal("IdAutor")),
                                NombreAutor = reader.GetString(reader.GetOrdinal("NombreAutor")),
                                Nacionalidad = reader.GetString(reader.GetOrdinal("Nacionalidad"))
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar autores: " + ex.Message);
            }

            return lista;
        }
    }
}
