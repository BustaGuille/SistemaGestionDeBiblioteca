using BibliotecaSystem.Entidades;
using Microsoft.IdentityModel.Logging;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace BibliotecaSystem.DAO
{
    public class SocioDAO
    {
        static string cadenaConexion = "Server=(local)//SQLEXPRESS;Database=BibliotecaDB;Trusted_Connection=True;TrustServerCertificate=True";

        public void AgregarSocio(Socio socio)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = @"INSERT INTO Socios (NombreSocio, CedulaSocio, Direccion, TelefonoSocio, Email) 
                                  VALUES (@NombreSocio, @CedulaSocio, @Direccion, @TelefonoSocio, @Email)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreSocio", socio.NombreSocio);
                cmd.Parameters.AddWithValue("@CedulaSocio", socio.CedulaSocio);
                cmd.Parameters.AddWithValue("@Direccion", socio.Direccion);
                cmd.Parameters.AddWithValue("@TelefonoSocio", socio.TelefonoSocio);
                cmd.Parameters.AddWithValue("@Email", socio.Email);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error inesperado al querer agregar el socio.");
                    throw new Exception("Error al agregar socio: " + ex.Message);
                }
            }
        }

        public void ModificarSocio(Socio socio)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = @"UPDATE Socios 
                                  SET NombreSocio = @NombreSocio, CedulaSocio = @CedulaSocio, Direccion = @Direccion,
                                      TelefonoSocio = @TelefonoSocio, Email = @Email
                                  WHERE IdSocio = @IdSocio";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreSocio", socio.NombreSocio);
                cmd.Parameters.AddWithValue("@CedulaSocio", socio.CedulaSocio);
                cmd.Parameters.AddWithValue("@Direccion", socio.Direccion);
                cmd.Parameters.AddWithValue("@TelefonoSocio", socio.TelefonoSocio);
                cmd.Parameters.AddWithValue("@Email", socio.Email);
                cmd.Parameters.AddWithValue("@IdSocio", socio.IdSocio);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error inesperado al querer modificar el socio.");
                    throw new Exception("Error al modificar socio: " + ex.Message);
                }
            }
        }

        public void EliminarSocio(int idSocio)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "DELETE FROM Socios WHERE IdSocio = @IdSocio";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdSocio", idSocio);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error inesperado al querer eliminar el socio.");
                    throw new Exception("Error al eliminar socio: " + ex.Message);
                }
            }
        }

        public Socio ObtenerSocioPorId(int idSocio)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT IdSocio, NombreSocio, CedulaSocio, Direccion, TelefonoSocio, Email FROM Socios WHERE IdSocio = @IdSocio";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdSocio", idSocio);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
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
                Console.WriteLine("Ocurrio un error inesperado al querer obtener el socio.");
                throw new Exception("Error al obtener socio: " + ex.Message);
            }

            return null;
        }

        public List<Socio> ListarSocios()
        {
            List<Socio> lista = new List<Socio>();

            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT IdSocio, NombreSocio, CedulaSocio, Direccion, TelefonoSocio, Email FROM Socios";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
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
                Console.WriteLine("Ocurrio un error inesperado al querer listar los socios.");
                throw new Exception("Error al listar socios: " + ex.Message);
            }

            return lista;
        }
    }
}
