using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSystem.Entidades
{
    public class Historial
    {
        public int IdHistorial { get; set; }
        public int IdPrestamo { get; set; } // Esto es para la relaion con el préstamo, si es que existe
        public int IdLibro { get; set; }
        public int IdSocio { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public bool Devuelto { get; set; }

        public Historial() { }

        public override string ToString()
        {
            return $"Historial ID: {IdHistorial}, Libro ID: {IdLibro}, Socio ID: {IdSocio}, Fecha Préstamo: {FechaPrestamo:dd/MM/yyyy}, Devuelto: {(Devuelto ? "Sí" : "No")}";
        }

    }
}
