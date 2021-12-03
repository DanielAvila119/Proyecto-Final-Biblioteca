using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSistemaBiblioteca.Modelos.Entidades
{
    public class Detalle
    {
        public int Id { get; set; }
        public int IdLibro { get; set; }
        public string NombreLibro { get; set; }
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public decimal Cobro { get; set; }
        public decimal Multa { get; set; }

    }

}
