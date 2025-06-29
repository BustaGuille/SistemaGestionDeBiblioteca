using BibliotecaSystem.Entidades;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace BibliotecaSystem.DAO
{
    public class LibroDAO
    {
        static string cadenaConexion = "Server=(local)//SQLEXPRESS;Database=BibliotecaDB;Trusted_Connection=True;TrustServerCertificate=True";

        public void AgregarLibro(Libro libro)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            { 
                string query = @"INSERT INTO Libros (Titulo, AutorId, EditorialId, CategoriaId, Estado, Cantidad)
                                  VALUES (@Titulo, @AutorId, @EditorialId, @CategoriaId, @Estado, @Cantidad)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Titulo", libro.Titulo);
                cmd.Parameters.AddWithValue("@AutorId", libro.AutorId);
                cmd.Parameters.AddWithValue("@EditorialId", libro.EditorialId);
                cmd.Parameters.AddWithValue("@CategoriaId", libro.CategoriaId);
                cmd.Parameters.AddWithValue("@Estado", (int)libro.Estado);
                cmd.Parameters.AddWithValue("@Cantidad", libro.CantidadDisponible);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error inesperado al querer agregar el libro.");
                    throw new Exception("Ocurrio un error al agregar el libro: " + ex.Message);  
                }
            }
        }

        public void ModificarLibro(Libro libro)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = @"UPDATE Libros SET Titulo = @Titulo, AutorId = @AutorId, EditorialId = @EditorialId,
                                  CategoriaId = @CategoriaId, Estado = @Estado, Cantidad = @Cantidad
                                  WHERE IdLibro = @IdLibro";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Titulo", libro.Titulo);
                cmd.Parameters.AddWithValue("@AutorId", libro.AutorId);
                cmd.Parameters.AddWithValue("@EditorialId", libro.EditorialId);
                cmd.Parameters.AddWithValue("@CategoriaId", libro.CategoriaId);
                cmd.Parameters.AddWithValue("@Estado", (int)libro.Estado);
                cmd.Parameters.AddWithValue("@Cantidad", libro.CantidadDisponible);
                cmd.Parameters.AddWithValue("@IdLibro", libro.IdLibro);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error inesperado al querer modificar el libro.");
                    throw new Exception("Error al modificar el libro: " + ex.Message);
                }
            }
        }

        public void EliminarLibro(int idLibro)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "DELETE FROM Libros WHERE IdLibro = @IdLibro";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdLibro", idLibro);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrio un error inesperado al querer elimar el libro.");
                    throw new Exception("Error al eliminar el libro: " + ex.Message);
                }
            }
        }


        //Obtenemos por id cuando se selecciona un libro desde una lista y se necesita traer sus detalles para editar o eliminar por ejemplo
        //El id es unico para cada libro, por lo que se puede usar para identificarlo de manera única en la base de datos.
        public Libro ObtenerLibroPorId(int idLibro)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT * FROM Libros WHERE IdLibro = @IdLibro";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdLibro", idLibro);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Libro
                            {
                                IdLibro = reader.GetInt32(reader.GetOrdinal("IdLibro")),
                                Titulo = reader.GetString(reader.GetOrdinal("Titulo")),
                                AutorId = reader.GetInt32(reader.GetOrdinal("AutorId")),
                                EditorialId = reader.GetInt32(reader.GetOrdinal("EditorialId")),
                                CategoriaId = reader.GetInt32(reader.GetOrdinal("CategoriaId")),
                                Estado = (EstadoDeLibroEnum)reader.GetInt32(reader.GetOrdinal("Estado")),
                                CantidadDisponible = reader.GetInt32(reader.GetOrdinal("Cantidad"))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error inesperado al querer obtener el libro.");
                throw new Exception("Error al obtener el libro: " + ex.Message);
            }

            return null;
        }

        //Obtenermos los libros por título, esto es útil para buscar un libro específico por su nombre en algun formulario de búsqueda o similar.
        public Libro ObtenerLibroPorTitulo(string titulo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT * FROM Libros WHERE Titulo = @Titulo";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Titulo", titulo);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Libro
                            {
                                IdLibro = reader.GetInt32(reader.GetOrdinal("IdLibro")),
                                Titulo = reader.GetString(reader.GetOrdinal("Titulo")),
                                AutorId = reader.GetInt32(reader.GetOrdinal("AutorId")),
                                EditorialId = reader.GetInt32(reader.GetOrdinal("EditorialId")),
                                CategoriaId = reader.GetInt32(reader.GetOrdinal("CategoriaId")),
                                Estado = (EstadoDeLibroEnum)reader.GetInt32(reader.GetOrdinal("Estado")),
                                CantidadDisponible = reader.GetInt32(reader.GetOrdinal("Cantidad"))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error inesperado al querer obtener el libro por título.");
                throw new Exception("Error al obtener libro por título: " + ex.Message);
            }

            return null;
        }

        public List<Libro> ListarLibros()
        {
            List<Libro> lista = new List<Libro>();

            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = "SELECT * FROM Libros";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Libro
                            {
                                IdLibro = reader.GetInt32(reader.GetOrdinal("IdLibro")),
                                Titulo = reader.GetString(reader.GetOrdinal("Titulo")),
                                AutorId = reader.GetInt32(reader.GetOrdinal("AutorId")),
                                EditorialId = reader.GetInt32(reader.GetOrdinal("EditorialId")),
                                CategoriaId = reader.GetInt32(reader.GetOrdinal("CategoriaId")),
                                Estado = (EstadoDeLibroEnum)reader.GetInt32(reader.GetOrdinal("Estado")),
                                CantidadDisponible = reader.GetInt32(reader.GetOrdinal("Cantidad"))
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error inesperado al querer listar los libros.");
                throw new Exception("Error al listar libros: " + ex.Message);
            }

            return lista;
        }
    }
}