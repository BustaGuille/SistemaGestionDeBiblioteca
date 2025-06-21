using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSystem.Entidades
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
    }
}


//Aqui se puede filtrar libros por categoria
//Cargar nuevas categorias
//Asociar categorias a libros durante la carga de libros