using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSistemaBiblioteca.Modelos.Entidades
{
    public class Ejemplar
    {
        public int Id { get; set; }
        public string Numeroejemplar { get; set; }
        public string Edoconservacion { get; set; }
        public int Idlibro { get; set; }

    }
}
