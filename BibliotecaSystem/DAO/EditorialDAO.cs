using BibliotecaSystem.Datos;
using BibliotecaSystem.Entidades;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
namespace BibliotecaSystem.DAO
{
    public class EditorialDAO
    {
        public void AgregarEditorial(Editorial editorial)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "INSERT INTO Editoriales (NombreEditorial) VALUES (@NombreEditorial)";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombreEditorial", editorial.NombreEditorial);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar editorial: " + ex.Message);
            }
        }

        public void ModificarEditorial(Editorial editorial)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "UPDATE Editoriales SET NombreEditorial = @NombreEditorial WHERE IdEditorial = @IdEditorial";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombreEditorial", editorial.NombreEditorial);
                    cmd.Parameters.AddWithValue("@IdEditorial", editorial.IdEditorial);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar editorial: " + ex.Message);
            }
        }

        public void EliminarEditorial(int idEditorial)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "DELETE FROM Editoriales WHERE IdEditorial = @IdEditorial";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdEditorial", idEditorial);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar editorial: " + ex.Message);
            }
        }

        public Editorial ObtenerEditorialPorId(int idEditorial)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "SELECT IdEditorial, NombreEditorial FROM Editoriales WHERE IdEditorial = @IdEditorial";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdEditorial", idEditorial);

                    using (var reader = cmd.ExecuteReader())
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
                throw new Exception("Error al obtener editorial: " + ex.Message);
            }

            return null;
        }

        public List<Editorial> ListarEditoriales()
        {
            List<Editorial> lista = new List<Editorial>();

            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "SELECT IdEditorial, NombreEditorial FROM Editoriales";
                    var cmd = new SqlCommand(query, conn);

                    using (var reader = cmd.ExecuteReader())
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
                throw new Exception("Error al listar editoriales: " + ex.Message);
            }

            return lista;
        }
    }
}
