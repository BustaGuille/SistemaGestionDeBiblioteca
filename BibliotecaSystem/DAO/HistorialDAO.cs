using BibliotecaSystem.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSystem.DAO
{
    public class HistorialDAO
    {
        private static string cadenaConexion = "Server=(local)\\SQLEXPRESS;Database=BibliotecaDB;Trusted_Connection=True;TrustServerCertificate=True";

        public void RegistrarHistorial(Historial historial)
        {
             using (SqlConnection conn = new SqlConnection(cadenaConexion))
             {
                string query = @"INSERT INTO Historial (IdPrestamo, IdLibro, IdSocio, FechaPrestamo, FechaDevolucion, Devuelto)
                                     VALUES (@IdPrestamo, @IdLibro, @IdSocio, @FechaPrestamo, @FechaDevolucion, @Devuelto)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdPrestamo", historial.IdPrestamo);
                cmd.Parameters.AddWithValue("@IdLibro", historial.IdLibro);
                cmd.Parameters.AddWithValue("@IdSocio", historial.IdSocio);
                cmd.Parameters.AddWithValue("@FechaPrestamo", historial.FechaPrestamo);
                cmd.Parameters.AddWithValue("@FechaDevolucion", (object)historial.FechaDevolucion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Devuelto", historial.Devuelto);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error al registrar el historial.");
                    throw new Exception("Error al registrar historial: " + ex.Message);
                }
             }
        }

        public List<Historial> ListarHistorial()
        {
            List<Historial> lista = new List<Historial>();
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT IdHistorial, IdPrestamo, IdLibro, IdSocio, FechaPrestamo, FechaDevolucion, Devuelto FROM Historial";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Historial
                            {
                                IdHistorial = reader.GetInt32(0),
                                IdPrestamo = reader.GetInt32(1),
                                IdLibro = reader.GetInt32(2),
                                IdSocio = reader.GetInt32(3),
                                FechaPrestamo = reader.GetDateTime(4),
                                FechaDevolucion = reader.IsDBNull(5) ? null : reader.GetDateTime(5),
                                Devuelto = reader.GetBoolean(6)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un Error al listar historial.");
                throw new Exception("Error al listar historial: " + ex.Message);
            }

            return lista;
        }
    }
}
