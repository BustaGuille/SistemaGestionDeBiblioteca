using BibliotecaSystem.Entidades;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace BibliotecaSystem.DAO
{
    public class AutorDAO
    {
        static string cadenaConexion = "Server=(local)\\SQLEXPRESS;Database=BibliotecaDB;Trusted_Connection=True;TrustServerCertificate=True"; 
        public void AgregarAutor(Autor autor)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "INSERT INTO Autores (NombreAutor, Nacionalidad) VALUES (@NombreAutor, @Nacionalidad)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreAutor", autor.NombreAutor);
                cmd.Parameters.AddWithValue("@Nacionalidad", autor.Nacionalidad);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error al querer agregar el autor: ");
                    throw new Exception("Error al agregar autor: " + ex.Message);
                }
            }
        }

        public void ModificarAutor(Autor autor)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "UPDATE Autores SET NombreAutor = @NombreAutor, Nacionalidad = @Nacionalidad WHERE IdAutor = @IdAutor";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreAutor", autor.NombreAutor);
                cmd.Parameters.AddWithValue("@Nacionalidad", autor.Nacionalidad);
                cmd.Parameters.AddWithValue("@IdAutor", autor.IdAutor);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error al querer modificar el autor: ");
                    throw new Exception("Error al modificar autor: " + ex.Message);
                }
            }
        }

        public void EliminarAutor(int idAutor)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
               string query = "DELETE FROM Autores WHERE IdAutor = @IdAutor";
               SqlCommand cmd = new SqlCommand(query, conn);
               cmd.Parameters.AddWithValue("@IdAutor", idAutor);
                try { 
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error al querer eliminar el autor: ");
                    throw new Exception("Error al eliminar autor: " + ex.Message);
                }
            }

        }

        public Autor ObtenerAutorPorId(int idAutor)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    String query = "SELECT IdAutor, NombreAutor, Nacionalidad FROM Autores WHERE IdAutor = @IdAutor";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdAutor", idAutor);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
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
                Console.WriteLine("Ocurrio un error al querer obtener el autor.");
                throw new Exception("Error al obtener autor: " + ex.Message);
            }

            return null;
        }

        public List<Autor> ListarAutores()
        {
            List<Autor> lista = new List<Autor>();

            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT IdAutor, NombreAutor, Nacionalidad FROM Autores";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
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
                Console.WriteLine("Ocurrio un error al querer listar los autores.");
                throw new Exception("Error al listar autores: " + ex.Message);
            }

            return lista;
        }
    }
}
