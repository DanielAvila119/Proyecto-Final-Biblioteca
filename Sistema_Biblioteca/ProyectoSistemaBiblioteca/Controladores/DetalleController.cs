using ProyectoSistemaBiblioteca.Modelos.Entidades;
using ProyectoSistemaBiblioteca.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSistemaBiblioteca.Controladores
{
    public class DetalleController
    {
        DetalleView vista;
        Cliente cliente = new Cliente();
        Libro libro = new Libro();
        Detalle detalle = new Detalle();

        public DetalleController(DetalleView view) 
        {
            vista.btn_BuscarCliente.Click += Btn_BuscarCliente_Click;
            vista.btn_BuscarLibro.Click += Btn_BuscarLibro_Click;
            vista.txt_Cobro.KeyPress += Txt_Cobro_KeyPress;
            vista.txt_Multa.KeyPress += Txt_Multa_KeyPress;
        }

        private void Txt_Multa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(vista.txt_Multa.Text))
            {
                detalle.Multa = vista.txt_Multa.Text;
            }
        }

        private void Txt_Cobro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(vista.txt_Cobro.Text))
            {
                detalle.Cobro = Convert.ToDecimal(vista.txt_Cobro.Text);
            }
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


        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            
            detalle.IdCliente = cliente.Id;
            detalle.IdLibro = libro.Id;
            detalle.NombreCliente = cliente.Nombre;
            detalle.NombreLibro = libro.Titulo;
          
            detalle.Cobro = Convert.ToDecimal(vista.txt_Cobro.Text);
            detalle.Multa = vista.txt_Multa.Text;

            bool inserto = detalleDAO.InsertarNuevaFactura(detalle);
            if (inserto)
            {
                MessageBox.Show("Prestamo registrado correctamente");
            }
            else
            {
                MessageBox.Show("Error al registrarel Prestamo");
            }

        }

    }
}
