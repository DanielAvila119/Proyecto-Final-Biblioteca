using ProyectoSistemaBiblioteca.Modelos.Entidades;
using ProyectoSistemaBiblioteca.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSistemaBiblioteca.Controladores
{
    public class DetalleController
    {
        DetalleView vista;
        Cliente cliente = new Cliente();
        Libro libro = new Libro();

        public DetalleController(DetalleView view) 
        {
            vista.btn_BuscarCliente.Click += Btn_BuscarCliente_Click;
            vista.btn_BuscarLibro.Click += Btn_BuscarLibro_Click;
        }

        private void Btn_BuscarLibro_Click(object sender, EventArgs e)
        {
            BuscarLibroView form = new BuscarLibroView();
            form.ShowDialog();
            libro = form._libro;
            vista.txt_NombreLibro.Text = libro.Titulo;
            vista.txt_IdLibro.Text = Convert.ToString(libro.Id);
        }

        private void Btn_BuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarClientesView form = new BuscarClientesView();
            form.ShowDialog();
            cliente = form._cliente;
            vista.txt_Nombre.Text = cliente.Nombre;
            vista.txt_ID.Text =Convert.ToString( cliente.Id);
        }
    }
}
