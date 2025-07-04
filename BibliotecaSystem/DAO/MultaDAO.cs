using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaSystem.Entidades;
using Microsoft.Data.SqlClient;

namespace BibliotecaSystem.DAO
{
    public class MultaDAO
    {
        static string cadenaConexion = "Server=(local)\\SQLEXPRESS;Database=BibliotecaDB;Trusted_Connection=True;TrustServerCertificate=True";
        public void RegistrarMulta(Multa multa)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = @"INSERT INTO Multas (IdSocio, Monto, FechaGeneracion, Motivo, Pagada)
                                     VALUES (@IdSocio, @Monto, @FechaGeneracion, @Motivo, @Pagada)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdSocio", multa.IdSocio);
                cmd.Parameters.AddWithValue("@Monto", multa.Monto);
                cmd.Parameters.AddWithValue("@FechaGeneracion", multa.FechaGeneracion);
                cmd.Parameters.AddWithValue("@Motivo", multa.Motivo);
                cmd.Parameters.AddWithValue("@Pagada", multa.Pagada);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error inesperado al querer registrar la multa.");
                    throw new Exception("Error al registrar multa: " + ex.Message);
                }
            }
        }

        public List<Multa> ListarMultas()
        {
            List<Multa> lista = new List<Multa>();
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT IdMulta, IdSocio, Monto, FechaGeneracion, Motivo, Pagada FROM Multas";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Multa
                            {
                                IdMulta = reader.GetInt32(0),
                                IdSocio = reader.GetInt32(1),
                                Monto = reader.GetDecimal(2),
                                FechaGeneracion = reader.GetDateTime(3),
                                Motivo = reader.GetString(4),
                                Pagada = reader.GetBoolean(5)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error inesperado al querer listar la multa.");
                throw new Exception("Error al listar las multas: " + ex.Message);
            }
            return lista;
        }

        public Multa ObtenerMultaPorId(int idMulta)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = @"SELECT IdMulta, IdSocio, Monto, FechaGeneracion, Motivo, Pagada 
                         FROM Multas 
                         WHERE IdMulta = @IdMulta";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdMulta", idMulta);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Multa
                            {
                                IdMulta = reader.GetInt32(0),
                                IdSocio = reader.GetInt32(1),
                                Monto = reader.GetDecimal(2),
                                FechaGeneracion = reader.GetDateTime(3),
                                Motivo = reader.GetString(4),
                                Pagada = reader.GetBoolean(5)
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener multa por ID: " + ex.Message);
                    throw new Exception("Error al obtener multa por ID: " + ex.Message);
                }

                return null;
            }

        }

        public void EliminarMulta(int idMulta)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "DELETE FROM Multas WHERE IdMulta = @IdMulta";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdMulta", idMulta);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar la multa: " + ex.Message);
                }
            }
        }

        public void ModificarMulta(Multa multa)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = @"UPDATE Multas
                             SET IdSocio = @IdSocio,
                                 Monto = @Monto,
                                 FechaGeneracion = @FechaGeneracion,
                                 Motivo = @Motivo,
                                 Pagada = @Pagada
                             WHERE IdMulta = @IdMulta";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdMulta", multa.IdMulta);
                cmd.Parameters.AddWithValue("@IdSocio", multa.IdSocio);
                cmd.Parameters.AddWithValue("@Monto", multa.Monto);
                cmd.Parameters.AddWithValue("@FechaGeneracion", multa.FechaGeneracion);
                cmd.Parameters.AddWithValue("@Motivo", multa.Motivo);
                cmd.Parameters.AddWithValue("@Pagada", multa.Pagada);

                try
                {
                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas == 0)
                    {
                        throw new Exception("No se encontró la multa con el ID proporcionado.");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al modificar la multa: " + ex.Message);
                }
            }
        }
    }
}

