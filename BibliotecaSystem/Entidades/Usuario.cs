using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaSystem.Utilidades;

namespace BibliotecaSystem.Entidades
{
    public class Usuario
    {
        public int IdUser { get; set; }
        public string NombreUsuario { get; set; }
        public string ContraseñaHash { get; set; }
        public bool VerificarPassword(string contraseñaPlano) //Metodo para verificar la contraseña ingresada por el usuario
        {
            return LogicaSeguridad.HashPassword(contraseñaPlano) == ContraseñaHash; //Compara el hash de la contraseña ingresada (Texto plano) con la contraseña almacenada (Hash)
        }

        public Usuario() { }

        public override string ToString()
        {
            return NombreUsuario;
        }
    }
}

//El metodo en si Verifica si la contraseña ingresada por el usuario coincide con el hash almacenado en la base de datos.
// Si coinciden, devuelve true, indicando que la contraseña es correcta. Si no coinciden, devuelve false, indicando que la contraseña es incorrecta. Esto permite autenticar al usuario de manera segura sin almacenar contraseñas en texto plano.
