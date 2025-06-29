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
        private static string cadenaConexion = "Server=(local)//SQLEXPRESS;Database=BibliotecaDB;Trusted_Connection=True;TrustServerCertificate=True";

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
    }
}
