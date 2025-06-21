using BibliotecaSystem.Datos;
using BibliotecaSystem.Entidades;
using Microsoft.IdentityModel.Logging;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace BibliotecaSystem.DAO
{
    public class SocioDAO
    {
        public void AgregarSocio(Socio socio)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = @"INSERT INTO Socios (NombreSocio, CedulaSocio, Direccion, TelefonoSocio, Email) 
                                  VALUES (@NombreSocio, @CedulaSocio, @Direccion, @TelefonoSocio, @Email)";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombreSocio", socio.NombreSocio);
                    cmd.Parameters.AddWithValue("@CedulaSocio", socio.CedulaSocio);
                    cmd.Parameters.AddWithValue("@Direccion", socio.Direccion);
                    cmd.Parameters.AddWithValue("@TelefonoSocio", socio.TelefonoSocio);
                    cmd.Parameters.AddWithValue("@Email", socio.Email);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) {
            
                throw new Exception("Error al agregar socio: " + ex.Message);
            }
        }

        public void ModificarSocio(Socio socio)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = @"UPDATE Socios 
                                  SET NombreSocio = @NombreSocio, CedulaSocio = @CedulaSocio, Direccion = @Direccion,
                                      TelefonoSocio = @TelefonoSocio, Email = @Email
                                  WHERE IdSocio = @IdSocio";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombreSocio", socio.NombreSocio);
                    cmd.Parameters.AddWithValue("@CedulaSocio", socio.CedulaSocio);
                    cmd.Parameters.AddWithValue("@Direccion", socio.Direccion);
                    cmd.Parameters.AddWithValue("@TelefonoSocio", socio.TelefonoSocio);
                    cmd.Parameters.AddWithValue("@Email", socio.Email);
                    cmd.Parameters.AddWithValue("@IdSocio", socio.IdSocio);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar socio: " + ex.Message);
            }
        }

        public void EliminarSocio(int idSocio)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "DELETE FROM Socios WHERE IdSocio = @IdSocio";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdSocio", idSocio);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar socio: " + ex.Message);
            }
        }

        public Socio ObtenerSocioPorId(int idSocio)
        {
            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "SELECT IdSocio, NombreSocio, CedulaSocio, Direccion, TelefonoSocio, Email FROM Socios WHERE IdSocio = @IdSocio";
                    var cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdSocio", idSocio);
                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Socio
                            {
                                IdSocio = reader.GetInt32(0),
                                NombreSocio = reader.GetString(1),
                                CedulaSocio = reader.GetString(2),
                                Direccion = reader.GetString(3),
                                TelefonoSocio = reader.GetString(4),
                                Email = reader.GetString(5)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener socio: " + ex.Message);
            }

            return null;
        }

        public List<Socio> ListarSocios()
        {
            List<Socio> lista = new List<Socio>();

            try
            {
                using (var conn = ConexionBD.ObtenerConexion())
                {
                    var query = "SELECT IdSocio, NombreSocio, CedulaSocio, Direccion, TelefonoSocio, Email FROM Socios";
                    var cmd = new SqlCommand(query, conn);
                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Socio
                            {
                                IdSocio = reader.GetInt32(0),
                                NombreSocio = reader.GetString(1),
                                CedulaSocio = reader.GetString(2),
                                Direccion = reader.GetString(3),
                                TelefonoSocio = reader.GetString(4),
                                Email = reader.GetString(5)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar socios: " + ex.Message);
            }

            return lista;
        }
    }
}
