using BibliotecaSystem.Entidades;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
namespace BibliotecaSystem.DAO
{
    public class EditorialDAO
    {
        static string cadenaConexion = "Server=(local)\\SQLEXPRESS;Database=BibliotecaDB;Trusted_Connection=True;TrustServerCertificate=True";
        public void AgregarEditorial(Editorial editorial)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "INSERT INTO Editoriales (NombreEditorial) VALUES (@NombreEditorial)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreEditorial", editorial.NombreEditorial);
    
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error al querer agregar la editorial.");
                    throw new Exception("Error al agregar editorial: " + ex.Message);
                }
            }
        }

        public void ModificarEditorial(Editorial editorial)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "UPDATE Editoriales SET NombreEditorial = @NombreEditorial WHERE IdEditorial = @IdEditorial";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreEditorial", editorial.NombreEditorial);
                cmd.Parameters.AddWithValue("@IdEditorial", editorial.IdEditorial);
                try { 
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error al querer modificar la editorial.");
                    throw new Exception("Error al modificar editorial: " + ex.Message);
                }
            }
        }

        public void EliminarEditorial(int idEditorial)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                 string query = "DELETE FROM Editoriales WHERE IdEditorial = @IdEditorial";
                 SqlCommand cmd = new SqlCommand(query, conn);
                 cmd.Parameters.AddWithValue("@IdEditorial", idEditorial);

                try { 
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error al querer eliminar la editorial.");
                    throw new Exception("Error al eliminar editorial: " + ex.Message);
                }
            }
        }

        public Editorial ObtenerEditorialPorId(int idEditorial)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();

                    string query = "SELECT IdEditorial, NombreEditorial FROM Editoriales WHERE IdEditorial = @IdEditorial";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdEditorial", idEditorial);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Editorial
                            {
                                IdEditorial = reader.GetInt32(reader.GetOrdinal("IdEditorial")),
                                NombreEditorial = reader.GetString(reader.GetOrdinal("NombreEditorial"))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al querer obtener la editorial por ID.");
                throw new Exception("Error al obtener editorial: " + ex.Message);
            }

            return null;
        }


        public List<Editorial> ListarEditoriales()
        {
            List<Editorial> lista = new List<Editorial>();

            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string query = "SELECT IdEditorial, NombreEditorial FROM Editoriales";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Editorial
                            {
                                IdEditorial = reader.GetInt32(reader.GetOrdinal("IdEditorial")),
                                NombreEditorial = reader.GetString(reader.GetOrdinal("NombreEditorial"))
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al querer listar las editoriales.");
                throw new Exception("Error al listar editoriales: " + ex.Message);
            }

            return lista;
        }
    }
}
