using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSystem.Entidades
{
    public class Multa
    {
        public int IdMulta { get; set; }
        public int IdSocio { get; set; } 
        public decimal Monto { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public string Motivo { get; set; } 
        public bool Pagada { get; set; }

        public Multa() { }
        public override string ToString()
        {
            return $"Multa ID: {IdMulta}, Socio ID: {IdSocio}, Monto: ₲ {Monto.ToString("N0")}, Fecha: {FechaGeneracion:dd/MM/yyyy}, Pagada: {(Pagada ? "Sí" : "No")}";
        }

    }
}
