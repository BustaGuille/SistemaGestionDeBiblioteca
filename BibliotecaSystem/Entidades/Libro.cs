using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSystem.Entidades
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public int AutorId { get; set; }
        public int CategoriaId { get; set; }
        public int EditorialId { get; set; }
        public EstadoDeLibroEnum Estado { get; set; }
        public int Cantidad { get; set; }

        public Libro() { }

        public override string ToString()
        {
            return Titulo;
        }
    }
}

//Podemos cargar libros
// Podemos buscar libros por titulo, autor, categoria o editorial
//consultar los libros disponibles
//hacer prestamos de libros y devoluciones de libros