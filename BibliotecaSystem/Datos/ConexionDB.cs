using System;
using System.Data.SqlClient;

namespace BibliotecaSystem.Datos
{
    public static class ConexionBD
    {
        // Aqui se define la cadena de conexión a la base de datos. 
        private static readonly string cadenaConexion = "localhost:8080";

        public static SqlConnection ObtenerConexion()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                return conexion;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al conectar con la base de datos: " + ex.Message);
            }
        }
    }
}
