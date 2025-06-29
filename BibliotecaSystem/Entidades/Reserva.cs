using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSystem.Entidades
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public int IdLibro { get; set; }
        public int IdSocio { get; set; }
        public DateTime FechaReserva { get; set; }
        public bool Activa { get; set; }

        public Reserva(){}

        public override string ToString()
        {
            return $"Reserva ID: {IdReserva}, Libro ID: {IdLibro}, Socio ID: {IdSocio}, Fecha: {FechaReserva:dd/MM/yyyy}, Activa: {(Activa ? "Sí" : "No")}";
        }

    }
}
