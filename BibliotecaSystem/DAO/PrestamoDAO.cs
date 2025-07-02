using BibliotecaSystem.Entidades;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace BibliotecaSystem.DAO
{
    public class PrestamoDAO
    {

        static string cadenaConexion = "Server=(local)\\SQLEXPRESS;Database=BibliotecaDB;Trusted_Connection=True;TrustServerCertificate=True";

        public void RegistrarPrestamo(Prestamo prestamo)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = @"INSERT INTO Prestamos (LibroId, UsuarioId, SocioId, FechaPrestamo, FechaDevolucion, Devuelto)
                                     VALUES (@LibroId, @UsuarioId, @SocioId, @FechaPrestamo, @FechaDevolucion, @Devuelto)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LibroId", prestamo.LibroId);
                cmd.Parameters.AddWithValue("@UsuarioId", prestamo.UsuarioId);
                cmd.Parameters.AddWithValue("@SocioId", prestamo.SocioId);
                cmd.Parameters.AddWithValue("@FechaPrestamo", prestamo.FechaPrestamo);
                cmd.Parameters.AddWithValue("@FechaDevolucion", (object)prestamo.FechaDevolucion ?? DBNull.Value); //Hicimos de esta forma por que el metodo AddWithValue requiere un valor de tipo objeto
                                                                                                                   //Agregamos una condicion en la que si FechaDevolucion es null, se agrega DBNull.Value a la consulta que es valido en SQL Server
                cmd.Parameters.AddWithValue("@Devuelto", prestamo.Devuelto);
                try { 
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al registrar préstamo: " + ex.Message);
                    throw new Exception("Ocurrio un error inesperado al registrar el prestamo: " +  ex.Message);
                }
            }
         
        }

        public void EliminarPrestamo(int idPrestamo)
        {
            
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "DELETE FROM Prestamos WHERE IdPrestamo = @IdPrestamo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdPrestamo", idPrestamo);
                 
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar el préstamo.");
                    throw new Exception("Ocurrio un error inesperado al eliminar el prestamo: " + ex.Message);
                }
            }
        }

        public void MarcarComoDevuelto(int idPrestamo)
        {
        
            using (SqlConnection conn = new SqlConnection())
            {
                string query = "UPDATE Prestamos SET Devuelto = 1 WHERE IdPrestamo = @IdPrestamo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdPrestamo", idPrestamo);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al marcar préstamo como devuelto: " + ex.Message);
                    throw new Exception("Ocurrio un error inesperado al marcar el prestamo como devuelto: " + ex.Message);
                }
            }
        }

        public List<Prestamo> ObtenerTodosLosPrestamos()
        {
            List<Prestamo> listaPresta = new List<Prestamo>();

                using (SqlConnection conn = new SqlConnection())
                {
                    string query = "SELECT IdPrestamo, LibroId, UsuarioId, SocioId, FechaPrestamo, FechaDevolucion, Devuelto FROM Prestamos";
                    SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                        
                    while (reader.Read())
                    {
                        listaPresta.Add(new Prestamo
                        {
                            IdPrestamo = reader.GetInt32(0),
                            LibroId = reader.GetInt32(1),
                            UsuarioId = reader.GetInt32(2),
                            SocioId = reader.GetInt32(3),
                            FechaPrestamo = reader.GetDateTime(4),
                            FechaDevolucion = reader.IsDBNull(5) ? null : reader.GetDateTime(5), //Se verifica si la columna en la posición 5 es DBNull antes de obtener el valor
                                                                                                 //Si es null la propiedad FechaDevolucion se asigna como null, de lo contrario obtenemos el valor de la columna
                            Devuelto = reader.GetBoolean(6)
                        });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener préstamos: " + ex.Message);
                    throw new Exception("Ocurrio un error inesperado al obtener los prestamos: " + ex.Message);
                }
            }
            return listaPresta;
        }
    }
}
