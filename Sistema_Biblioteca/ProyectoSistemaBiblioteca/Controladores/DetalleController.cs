using ProyectoSistemaBiblioteca.Modelos.DAO;
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
        DetalleDAO detalleDAO = new DetalleDAO();
        Prestamo prestamo = new Prestamo();
        PrestamoDAO prestamoDAO = new PrestamoDAO();
        //UsuarioDAO usuarioDAO = new UsuarioDAO();
        Cliente cliente = new Cliente();
        ClienteDAO clienteDAO = new ClienteDAO();
        Libro libro = new Libro();
        LibroDAO libroDAO = new LibroDAO();
        
      

        List<Prestamo> listaDetallePrestamo = new List<Prestamo>();

        decimal cobro = 0;
        decimal multa = 0;
        


        public DetalleController(DetalleView view)
        {
            vista = view;
            vista.Load += new EventHandler(Load);
            vista.txt_IdPrestamo.KeyPress += Txt_IdPrestamo_KeyPress;
            vista.btn_BuscarLibro.Click += Btn_BuscarLibro_Click;
            vista.txt_IdLibro.KeyPress += txt_IdLibro_KeyPress;
            vista.txt_IDCliente.KeyPress += Txt_IDCliente_KeyPress;
            vista.btn_BuscarCliente.Click += Btn_BuscarCliente_Click;
            vista.btn_Guardar.Click += Btn_Guardar_Click;
            vista.btn_Cancelar.Click += Btn_Cancelar_Click;
            vista.DevoluciondateTimePicker2.CloseUp += DevoluciondateTimePicker2_CloseUp;
            
        }

        private void Load(object sender, EventArgs e)
        {
            ListarDetalle();
        }

        private void ListarDetalle()
        {
            vista.DetalledataGridView.DataSource = detalleDAO.GetDetalle();
        }

        private void Txt_IdPrestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            }
        }

        private void DevoluciondateTimePicker2_CloseUp(object sender, EventArgs e)
        {
            DateTime FechaEntrega = vista.EntregadateTimePicker1.Value.Date;
            DateTime FechaDevolucion = vista.DevoluciondateTimePicker2.Value.Date;
            decimal multa;
            decimal cobro = 5;
            if (FechaDevolucion > FechaEntrega)
            {
                TimeSpan tspan = FechaDevolucion - FechaEntrega;
                int dias = tspan.Days;
                vista.txt_diasretraso.Text = dias.ToString();

                multa = dias * cobro;
                vista.DetalledataGridView.DataSource = null;
                

                vista.txt_Multa.Text = multa.ToString("N2");
                vista.txt_Cobro.Text = cobro.ToString("N2");
                
            }
            else
            {
                multa = 0;
                vista.txt_Multa.Text = multa.ToString("N2");
                vista.txt_Cobro.Text = cobro.ToString("N2");
            }
        }
        private void Txt_Multa_KeyPress(object sender, KeyPressEventArgs e)
        {
            vista.txt_Multa.Text = Convert.ToDecimal(multa).ToString();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Detalle detalle = new Detalle();
            detalle.IdLibro = libro.Id;
            detalle.NombreLibro = libro.Titulo;
            detalle.IdCliente = cliente.Id;
            detalle.NombreCliente =cliente.Nombre;
            detalle.Cobro = Convert.ToDecimal(vista.txt_Cobro.Text);
            detalle.Multa = Convert.ToDecimal(vista.txt_Multa.Text);
            

            bool inserto = detalleDAO.InsertarNuevoDetallePrestamo(detalle, listaDetallePrestamo);
            if (inserto)
            {
                MessageBox.Show("Prestamo Registrado correctamente");
            }
            else
            {
                MessageBox.Show("Error al registrar El Prestamo");
            }
        }

        private void Btn_BuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarClientesView form = new BuscarClientesView();
            form.ShowDialog();
            cliente = form._cliente;
            vista.txt_IDCliente.Text = Convert.ToInt32(cliente.Id).ToString();
            vista.txt_Nombre.Text = cliente.Nombre;

        }

        private void Btn_BuscarLibro_Click(object sender, EventArgs e)
        {
            BuscarLibroView form = new BuscarLibroView();
            form.ShowDialog();
            libro = form._libro;
            vista.txt_IdLibro.Text = Convert.ToInt32(libro.Id).ToString();
            vista.txt_NombreLibro.Text = libro.Titulo;
        }

        private void Txt_IDCliente_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cliente = clienteDAO.GetClientePorID(vista.txt_IDCliente.Text);

                vista.txt_Nombre.Text = cliente.Nombre;
            }
            else
            {
                cliente = null;
                vista.txt_Nombre.Clear();
            }
        }

        private void txt_IdLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                libro = libroDAO.GetLibroPorID(vista.txt_IdLibro.Text);

                vista.txt_NombreLibro.Text = libro.Titulo;
            }
            else
            {
                cliente = null;
                vista.txt_Nombre.Clear();
            }
        }
    }
}
