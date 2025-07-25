﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSystem.Entidades
{
    public class Autor
    {
        public int IdAutor { get; set; }
        public string NombreAutor { get; set; }

        public string Nacionalidad { get; set; }

        public Autor() { }

        public override string ToString()
        {
            return NombreAutor + " (" + Nacionalidad + ")";
        }
    }
}

//Represeta a un autor o escritor de un libro
//Cada autor puede estar asociado a varios libros
