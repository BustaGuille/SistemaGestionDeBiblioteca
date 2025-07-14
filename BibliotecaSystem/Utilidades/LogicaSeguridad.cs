using System.Security.Cryptography;
using System.Text;

//Aqui esta la logica de seguridad que se encarga de hashear las contraseñas 
namespace BibliotecaSystem.Utilidades
{
    public static class LogicaSeguridad
    {
        public static string HashPassword(string input)
        {
            using (SHA256 shaencrip = SHA256.Create()) // Creamos una instancia del algoritmo SHA256 para encriptar la contraseña
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);  // Convierte la cadena de entrada a un arreglo de bytes ya que  el algoritmo trabaja con texto plano
                byte[] hashBytes = shaencrip.ComputeHash(bytes); //Devuelve el hash de la cadena de entrada ya encriptada
                return Convert.ToBase64String(hashBytes); // Convierte el arreglo de bytes del hash a una cadena Base64 para que sea legible y almacenable
            }
        }
    }
}
