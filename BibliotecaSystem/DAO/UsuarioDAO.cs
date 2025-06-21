using BibliotecaSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BibliotecaSystem.DAO
{
    public class UsuarioDAO
    {
        public void AgregarUser(Usuario usuario)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "INSERT INTO Usuarios (NombreUsuario, ContraseñaHash) VALUES (@NombreUsuario, @ContraseñaHash)";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("@ContraseñaHash", usuario.ContraseñaHash);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el usuario: " + ex.Message);
            }
        }

        public void ModificarUser(Usuario usuario)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "UPDATE Usuarios SET NombreUsuario = @NombreUsuario, ContraseñaHash = @ContraseñaHash WHERE Id = @Id";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("@ContraseñaHash", usuario.ContraseñaHash);
                    cmd.Parameters.AddWithValue("@Id", usuario.Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el usuario: " + ex.Message);
            }
        }

        public void EliminarUser(int id)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "DELETE FROM Usuarios WHERE Id = @Id";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el usuario: " + ex.Message);
            }
        }

        public Usuario ObtenerUserPorId(int id)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "SELECT Id, NombreUsuario, ContraseñaHash FROM Usuarios WHERE Id = @Id";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Usuario
                            {
                                Id = reader.GetInt32(0),
                                NombreUsuario = reader.GetString(1),
                                ContraseñaHash = reader.GetString(2)
                            };
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el usuario por ID: " + ex.Message);
            }
        }

        public Usuario ObtenerUserPorNombre(string nombreUsuario)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "SELECT Id, NombreUsuario, ContraseñaHash FROM Usuarios WHERE NombreUsuario = @NombreUsuario";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Usuario
                            {
                                Id = reader.GetInt32(0),
                                NombreUsuario = reader.GetString(1),
                                ContraseñaHash = reader.GetString(2)
                            };
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el usuario por nombre: " + ex.Message);
            }
        }

        public List<Usuario> ListarUsuariosExistntes()
        {
            try
            {
                List<Usuario> usuariosList = new List<Usuario>();
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "SELECT Id, NombreUsuario, ContraseñaHash FROM Usuarios";
                    var cmd = new SqlCommand(query, conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usuariosList.Add(new Usuario
                            {
                                Id = reader.GetInt32(0),
                                NombreUsuario = reader.GetString(1),
                                ContraseñaHash = reader.GetString(2)
                            });
                        }
                    }
                }
                return usuariosList;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los usuarios: " + ex.Message);
            }
        }
    }
}
