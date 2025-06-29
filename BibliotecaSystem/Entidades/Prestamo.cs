using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSystem.Entidades
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public int LibroId { get; set; }
        public int UsuarioId { get; set; }                // ID del usuario que hizo el préstamo (admin o bibliotecario)
        public int SocioId { get; set; }                  // ID del socio al que se le presta el libro
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public bool Devuelto { get; set; }                // Para saber si es que fue devuelto el libro o no

        public Prestamo() { }

        public override string ToString()
        {
            return $"Prestamo ID: {IdPrestamo}, Libro ID: {LibroId}, Usuario ID: {UsuarioId}, Socio ID: {SocioId}, Fecha de Prestamo: {FechaPrestamo}, Fecha de Devolucion: {(FechaDevolucion.HasValue ? FechaDevolucion.Value.ToString("dd/MM/yyyy") : "No devuelto")}, Devuelto: {Devuelto}";
        }
    }
}

//representa un prestamo de un libro por parte de un usuario
//Basicamente cada ves que alguien presta un libro se crea una nueva instancia de esta clase