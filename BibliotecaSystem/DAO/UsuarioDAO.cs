using BibliotecaSystem.Datos;
using BibliotecaSystem.Entidades;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace BibliotecaSystem.DAO
{
    public class UsuarioDAO
    {
        public void AgregarUsuario(Usuario usuario)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "INSERT INTO Usuarios (NombreUsuario, ContraseñaHash) VALUES (@NombreUsuario, @ContraseñaHash)";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("@ContraseñaHash", usuario.ContraseñaHash);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar usuario: " + ex.Message);
            }
        }

        public void ModificarUsuario(Usuario usuario)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "UPDATE Usuarios SET NombreUsuario = @NombreUsuario, ContraseñaHash = @ContraseñaHash WHERE IdUser = @IdUser";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("@ContraseñaHash", usuario.ContraseñaHash);
                    cmd.Parameters.AddWithValue("@IdUser", usuario.IdUser);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar usuario: " + ex.Message);
            }
        }

        public void EliminarUsuario(int IdUser)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "DELETE FROM Usuarios WHERE IdUser = @IdUser";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdUser", IdUser);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar usuario: " + ex.Message);
            }
        }

        public Usuario ObtenerUsuarioPorId(int IdUser)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "SELECT IdUsuario, NombreUsuario, ContraseñaHash FROM Usuarios WHERE IdUser = @IdUser";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdUser", IdUser);

                    using (var reader = cmd.ExecuteReader())
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
                throw new Exception("Error al obtener usuario por ID: " + ex.Message);
            }

            return null;
        }

        public Usuario ObtenerUsuarioPorNombre(string nombreUsuario)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "SELECT IdUser, NombreUsuario, ContraseñaHash FROM Usuarios WHERE NombreUsuario = @NombreUsuario";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
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
                throw new Exception("Error al obtener usuario por nombre: " + ex.Message);
            }

            return null;
        }

        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();

            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "SELECT IdUser, NombreUsuario, ContraseñaHash FROM Usuarios";
                    var cmd = new SqlCommand(query, conn);
                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
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
                throw new Exception("Error al listar usuarios: " + ex.Message);
            }

            return lista;
        }
    }
}
