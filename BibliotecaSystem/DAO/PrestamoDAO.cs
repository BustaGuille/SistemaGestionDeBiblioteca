using BibliotecaSystem.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace BibliotecaSystem.DAO
{
    public class PrestamoDAO
    {

        static string cadenaConexion = "Server=(local)\\SQLEXPRESS;Database=BibliotecaDB;Trusted_Connection=True;TrustServerCertificate=True";

        public void RegistrarPrestamo(Prestamo prestamo)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                //Se hace uno o no se hace ninguno, esto es lo que se conoce como transacción, lo hacemos por que hacemos 2 operaciones criticas
                SqlTransaction transaction = conn.BeginTransaction(); //con esto iniciamos una transacción para asegurar que ambas operaciones (insertar préstamo y actualizar cantidad de libro) se realicen correctamente

                try
                {
                    // Estamos insertando un nuevo préstamo en la tabla Prestamos
                    string queryInsert = @"INSERT INTO Prestamos (LibroId, UsuarioId, SocioId, FechaPrestamo, FechaDevolucion, Devuelto)
                                   VALUES (@LibroId, @UsuarioId, @SocioId, @FechaPrestamo, @FechaDevolucion, @Devuelto)";
                    SqlCommand cmdInsert = new SqlCommand(queryInsert, conn, transaction);
                    cmdInsert.Parameters.AddWithValue("@LibroId", prestamo.LibroId);
                    cmdInsert.Parameters.AddWithValue("@UsuarioId", prestamo.UsuarioId);
                    cmdInsert.Parameters.AddWithValue("@SocioId", prestamo.SocioId);
                    cmdInsert.Parameters.AddWithValue("@FechaPrestamo", prestamo.FechaPrestamo);
                    cmdInsert.Parameters.AddWithValue("@FechaDevolucion", (object)prestamo.FechaDevolucion ?? DBNull.Value);
                    cmdInsert.Parameters.AddWithValue("@Devuelto", prestamo.Devuelto);

                    cmdInsert.ExecuteNonQuery();

                    // Estamos actualizando la cantidad de ejemplares del libro en la tabla Libros
                    string queryUpdate = @"UPDATE Libros SET Cantidad = Cantidad - 1 WHERE IdLibro = @IdLibro AND Cantidad > 0"; //Actualizamos la cantidad de libros solo si hay ejemplares disponibles
                    SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn, transaction);
                    cmdUpdate.Parameters.AddWithValue("@IdLibro", prestamo.LibroId);

                    int filasAfectadas = cmdUpdate.ExecuteNonQuery(); 

                    if (filasAfectadas == 0) //Es por si no hay ejemplares disponibles del libro hacemos rollback
                        throw new Exception("No hay ejemplares disponibles del libro.");

                    transaction.Commit(); // Si es que todo sale bien se confirma la transacción
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al registrar el préstamo: " + ex.Message);
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
        
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
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

       


        public void ModificarPrestamo(Prestamo prestamo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = @"UPDATE Prestamos 
                                 SET LibroId = @LibroId, 
                                     UsuarioId = @UsuarioId,
                                     SocioId = @SocioId,
                                     FechaPrestamo = @FechaPrestamo,
                                     FechaDevolucion = @FechaDevolucion,
                                     Devuelto = @Devuelto
                                 WHERE IdPrestamo = @IdPrestamo";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@LibroId", prestamo.LibroId);
                    cmd.Parameters.AddWithValue("@UsuarioId", prestamo.UsuarioId);
                    cmd.Parameters.AddWithValue("@SocioId", prestamo.SocioId);
                    cmd.Parameters.AddWithValue("@FechaPrestamo", prestamo.FechaPrestamo);
                    cmd.Parameters.AddWithValue("@FechaDevolucion", (object)prestamo.FechaDevolucion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Devuelto", prestamo.Devuelto);
                    cmd.Parameters.AddWithValue("@IdPrestamo", prestamo.IdPrestamo);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al modificar el préstamo: " + ex.Message);
            }
        }

        public Prestamo ObtenerPrestamoPorId(int idPrestamo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = @"SELECT IdPrestamo, LibroId, UsuarioId, SocioId, FechaPrestamo, FechaDevolucion, Devuelto
                             FROM Prestamos
                             WHERE IdPrestamo = @IdPrestamo";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdPrestamo", idPrestamo);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Prestamo
                            {
                                IdPrestamo = reader.GetInt32(reader.GetOrdinal("IdPrestamo")),
                                LibroId = reader.GetInt32(reader.GetOrdinal("LibroId")),
                                UsuarioId = reader.GetInt32(reader.GetOrdinal("UsuarioId")),
                                SocioId = reader.GetInt32(reader.GetOrdinal("SocioId")),
                                FechaPrestamo = reader.GetDateTime(reader.GetOrdinal("FechaPrestamo")),
                                FechaDevolucion = reader.IsDBNull(reader.GetOrdinal("FechaDevolucion"))
                                                  ? null
                                                  : reader.GetDateTime(reader.GetOrdinal("FechaDevolucion")),
                                Devuelto = reader.GetBoolean(reader.GetOrdinal("Devuelto"))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener préstamo por ID: " + ex.Message);
                throw new Exception("Error al buscar préstamo: " + ex.Message);
            }

            return null;
        }

        public DataTable ObtenerTodosLosPrestamos()
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = @"
            SELECT 
                p.IdPrestamo,
                l.Titulo AS NombreLibro,
                u.NombreUsuario,
                s.NombreSocio,
                p.FechaPrestamo,
                p.FechaDevolucion,
                p.Devuelto
            FROM Prestamos p
            INNER JOIN Libros l ON p.LibroId = l.IdLibro
            INNER JOIN Usuarios u ON p.UsuarioId = u.IdUser
            INNER JOIN Socios s ON p.SocioId = s.IdSocio";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable tabla = new DataTable();

                try
                {
                    adapter.Fill(tabla);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los préstamos: " + ex.Message);
                }

                return tabla;
            }
        }


    }
}
