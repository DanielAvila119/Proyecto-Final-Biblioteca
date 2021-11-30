using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSistemaBiblioteca.Modelos.Entidades
{
    public class Login
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
    }
}
