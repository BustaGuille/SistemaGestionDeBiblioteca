using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSystem.Entidades
{
    public enum EstadoDeLibroEnum
    {
        Disponible, //El libro esta disponible para ser prestado
        Prestado,   //El libro esta prestado a un usuario
        Reservado,  //El libro esta reservado por un usuario
        Perdido,    //El libro se ha perdido y no puede ser prestado
        EnMantenimiento //El libro esta en mantenimiento y no puede ser prestado
    }
}


//Esto es un enum, en donde definimos los posibles estados de un libro en la biblioteca.