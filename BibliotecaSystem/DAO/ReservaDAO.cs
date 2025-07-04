using BibliotecaSystem.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSystem.DAO
{
    public class ReservaDAO
    {
        static string cadenaConexion = "Server=(local)\\SQLEXPRESS;Database=BibliotecaDB;Trusted_Connection=True;TrustServerCertificate=True";
        public void AgregarReserva(Reserva reserva)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = @"INSERT INTO Reservas (IdLibro, IdSocio, FechaReserva, Activa)
                                     VALUES (@IdLibro, @IdSocio, @FechaReserva, @Activa)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdLibro", reserva.IdLibro);
                cmd.Parameters.AddWithValue("@IdSocio", reserva.IdSocio);
                cmd.Parameters.AddWithValue("@FechaReserva", reserva.FechaReserva);
                cmd.Parameters.AddWithValue("@Activa", reserva.Activa);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocuriio un error al agregar reserva.");
                    throw new Exception("Error al agregar reserva" + ex.Message);
                }
            }
        }

        public void EliminarReserva(int idReserva)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "DELETE FROM Reservas WHERE IdReserva = @IdReserva";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdReserva", idReserva);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar la reserva: " + ex.Message);
                    throw;
                }
            }
        }

        public Reserva ObtenerReservaPorId(int id)
        {
            Reserva reserva = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string query = "SELECT IdReserva, IdLibro, IdSocio, FechaReserva FROM Reservas WHERE IdReserva = @IdReserva";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdReserva", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            reserva = new Reserva
                            {
                                IdReserva = reader.GetInt32(0),
                                IdLibro = reader.GetInt32(1),
                                IdSocio = reader.GetInt32(2),
                                FechaReserva = reader.GetDateTime(3)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener reserva por ID: " + ex.Message);
            }

            return reserva;
        }

        public void ModificarReserva(Reserva reserva)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = @"UPDATE Reservas 
                             SET IdLibro = @IdLibro, 
                                 IdSocio = @IdSocio, 
                                 FechaReserva = @FechaReserva, 
                                 Activa = @Activa 
                             WHERE IdReserva = @IdReserva";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdLibro", reserva.IdLibro);
                cmd.Parameters.AddWithValue("@IdSocio", reserva.IdSocio);
                cmd.Parameters.AddWithValue("@FechaReserva", reserva.FechaReserva);
                cmd.Parameters.AddWithValue("@Activa", reserva.Activa);
                cmd.Parameters.AddWithValue("@IdReserva", reserva.IdReserva);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocuriio un error al modificar reserva.");
                    throw new Exception("Error al modificar reserva" + ex.Message);
                }
            }
        }

        public List<Reserva> ListarReservas()
        {
            List<Reserva> lista = new List<Reserva>();

            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT IdReserva, IdLibro, IdSocio, FechaReserva, Activa FROM Reservas";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Reserva
                            {
                                IdReserva = reader.GetInt32(0),
                                IdLibro = reader.GetInt32(1),
                                IdSocio = reader.GetInt32(2),
                                FechaReserva = reader.GetDateTime(3),
                                Activa = reader.GetBoolean(4)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error al listar reservas.");
                throw new Exception("Error al listar reservas: " + ex.Message);
            }

            return lista;
        }
    }
}
