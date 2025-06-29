using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSystem.Entidades
{
    public class Editorial
    {
        public int IdEditorial { get; set; }
        public string NombreEditorial { get; set; }

        public Editorial() { }

        public override string ToString()
        {
            return NombreEditorial;
        }

    }
}

//Esta clase representa una editorial que publica libros.