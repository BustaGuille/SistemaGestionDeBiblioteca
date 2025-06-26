using BibliotecaSystem.Entidades;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace BibliotecaSystem.DAO
{
    public class UsuarioDAO
    {
        static string cadenaConexion = "Server=localhost;Database=BibliotecaDB;Trusted_Connection=True;TrustServerCertificate=True";
        public void AgregarUsuario(Usuario usuario)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "INSERT INTO Usuarios (NombreUsuario, ContraseñaHash) VALUES (@NombreUsuario, @ContraseñaHash)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@ContraseñaHash", usuario.ContraseñaHash);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error inesperado al querer agregar al usuario.");
                    throw new Exception("Error al agregar usuario: " + ex.Message);
                }
            }
        }

        public void ModificarUsuario(Usuario usuario)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "UPDATE Usuarios SET NombreUsuario = @NombreUsuario, ContraseñaHash = @ContraseñaHash WHERE IdUser = @IdUser";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@ContraseñaHash", usuario.ContraseñaHash);
                cmd.Parameters.AddWithValue("@IdUser", usuario.IdUser);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error inesperado al querer modificar al usuario.");
                    throw new Exception("Error al modificar usuario: " + ex.Message);
                }
            }
        }

        public void EliminarUsuario(int IdUser)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "DELETE FROM Usuarios WHERE IdUser = @IdUser";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdUser", IdUser);
                cmd.ExecuteNonQuery();
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error inesperado al querer eliminar al usuario.");
                    throw new Exception("Error al eliminar usuario: " + ex.Message);
                }
            }
        }

        public Usuario ObtenerUsuarioPorId(int IdUser)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT IdUsuario, NombreUsuario, ContraseñaHash FROM Usuarios WHERE IdUser = @IdUser";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdUser", IdUser);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Usuario
                            {
                                IdUser = reader.GetInt32(0),
                                NombreUsuario = reader.GetString(1),
                                ContraseñaHash = reader.GetString(2)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error inesperado al querer obtener al usuario por ID.");
                throw new Exception("Error al obtener usuario por ID: " + ex.Message);
            }

            return null;
        }

        public Usuario ObtenerUsuarioPorNombre(string nombreUsuario)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT IdUser, NombreUsuario, ContraseñaHash FROM Usuarios WHERE NombreUsuario = @NombreUsuario";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Usuario
                            {
                                IdUser = reader.GetInt32(0),
                                NombreUsuario = reader.GetString(1),
                                ContraseñaHash = reader.GetString(2)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error inesperado al querer obtener al usuario por nombre.");
                throw new Exception("Error al obtener usuario por nombre: " + ex.Message);
            }

            return null;
        }

        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();

            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT IdUser, NombreUsuario, ContraseñaHash FROM Usuarios";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Usuario
                            {
                                IdUser = reader.GetInt32(0),
                                NombreUsuario = reader.GetString(1),
                                ContraseñaHash = reader.GetString(2)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error inesperado al querer listar los usuario.");
                throw new Exception("Error al listar usuarios: " + ex.Message);
            }

            return lista;
        }
    }
}
