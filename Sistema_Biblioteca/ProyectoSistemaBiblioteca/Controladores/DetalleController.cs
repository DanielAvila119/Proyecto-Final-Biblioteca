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
            //vista.Load += new EventHandler(Load);
            //vista.txt_IdPrestamo.KeyPress += txt_IdPrestamo_KeyPress;
            vista.btn_BuscarLibro.Click += Btn_BuscarLibro_Click;
            vista.txt_IdLibro.KeyPress += txt_IdLibro_KeyPress;
            //vista.txt_NombreLibro.KeyPress += Txt_NombreLibro_KeyPress;
            vista.txt_IDCliente.KeyPress += Txt_IDCliente_KeyPress;
            //vista.txt_Nombre.KeyPress += Txt_Nombre_KeyPress;
            vista.btn_BuscarCliente.Click += Btn_BuscarCliente_Click;
            vista.btn_Guardar.Click += Btn_Guardar_Click;
            //vista.btn_Cancelar.Click += Btn_Cancelar_Click;
            //vista.txt_Multa.KeyPress += Txt_Multa_KeyPress;
            //vista.EntregadateTimePicker1.CloseUp += EntregadateTimePicker1_CloseUp;
            vista.DevoluciondateTimePicker2.CloseUp += DevoluciondateTimePicker2_CloseUp;
            //vista.txt_Cobro.KeyPress += Txt_Cobro_KeyPress;
            
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

        //private void EntregadateTimePicker1_CloseUp(object sender, EventArgs e)
        //{
           
        //}

        private void EntregadateTimePicker1_CloseUp(object sender, KeyPressEventArgs e)
        {
            //DateTime FechaEntrega = vista.EntregadateTimePicker1.Value.Date;
            //DateTime FechaDevolucion = vista.DevoluciondateTimePicker2.Value.Date;
            //decimal multa;
            //decimal cobro = 25;
            //if (FechaDevolucion > FechaEntrega)
            //{
            //    multa = cobro + 5;
            //    vista.DetalledataGridView.DataSource = null;
            //    vista.DetalledataGridView.DataSource = listaDetallePrestamo;

            //    vista.txt_Multa.Text = multa.ToString("N2");
            //    vista.txt_Cobro.Text = cobro.ToString("N2");
            //}
            //else
            //{
            //    multa = 0;
            //    vista.txt_Multa.Text = multa.ToString("N2");
            //    vista.txt_Cobro.Text = cobro.ToString("N2");
            //}


        }

        private void Txt_Cobro_KeyPress(object sender, KeyPressEventArgs e)
        {
            vista.txt_Cobro.Text = Convert.ToDecimal(cobro).ToString();
        }

        //private void EntregadateTimePicker1_CloseUp(object sender, EventArgs e)
        //{

        //    DateTime FechaEntrega = vista.EntregadateTimePicker1.Value.Date;
        //    DateTime FechaDevolucion = vista.DevoluciondateTimePicker2.Value.Date;
        //    decimal multa;
        //    decimal cobro = 25 ;
        //    if (FechaDevolucion > FechaEntrega)
        //    {
        //        multa = cobro + 5;

        //    }
        //    else
        //    {
        //        multa = 0;
        //    }

        //}

        //        Dim fecha_devolucion As Date = dtp_entrega.Value.Date
        //If fecha_devolucion > fecha_entrega Then
        //Dim dias_retraso As Integer = CType(DateDiff(DateInterval.Day, fecha_entrega, fecha_devolucion), Integer)
        //Dim multa As Single = dias_retraso * 50 'calcula la multa, 50 lempiras por cada dia de retraso
        //lbl_observacion.Text = "Se paso de la fecha entrega " & dias_retraso & " dias, " & ControlChars.NewLine & " tiene una multa de " & multa & " lempiras"
        //Else
        //lbl_observacion.Text = Nothing
        //End If

        //private void PrestamodateTimePicker1.(object sender, EventArgs e)
        //{
        //    DateTime FechaPrestamo =prestamoda;
        //    DateTime FechaDevolucion;
        //    int diaretraso;
        //    decimal multa;
        //    if (FechaPrestamo > FechaDevolucion)
        //    {

        //    }


        //}

        private void Txt_Multa_KeyPress(object sender, KeyPressEventArgs e)
        {
            vista.txt_Multa.Text = Convert.ToDecimal(multa).ToString();
        }

        //private void Btn_Cancelar_Click(object sender, EventArgs e)
        //{

        //}

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

        //private void Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

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

        //private void Txt_NombreLibro_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

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



        //private void txt_IdPrestamo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}



        //private void CantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(vista.CantidadTextBox.Text))
        //    {
        //        DetalleFactura detalleFactura = new DetalleFactura();
        //        detalleFactura.IdProducto = producto.Id;
        //        detalleFactura.Cantidad = Convert.ToInt32(vista.CantidadTextBox.Text);
        //        detalleFactura.Precio = producto.Precio;
        //        detalleFactura.Total = Convert.ToDecimal(Convert.ToInt32(vista.CantidadTextBox.Text) * producto.Precio);

        //        subTotal += detalleFactura.Total;
        //        isv = subTotal * 0.15M;
        //        totalPagar = subTotal + isv;

        //        listaDetalleFactura.Add(detalleFactura);
        //        vista.DetalleDataGridView.DataSource = null;
        //        vista.DetalleDataGridView.DataSource = listaDetalleFactura;

        //        vista.SubtotalTextBox.Text = subTotal.ToString("N2");
        //        vista.ImpuestoTextBox.Text = isv.ToString("N2");
        //        vista.TotalTextBox.Text = totalPagar.ToString("N2");
        //    }
        //}

        //private void CodigoProductoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        producto = productoDAO.GetProductoPorCodigo(vista.CodigoProductoTextBox.Text);

        //        vista.DescripcionProductoTextBox.Text = producto.Descripcion;
        //    }
        //    else
        //    {
        //        producto = null;
        //        vista.DescripcionProductoTextBox.Clear();
        //    }
        //}

        //private void BuscarClienteButton_Click(object sender, EventArgs e)
        //{
        //    BuscarClienteView form = new BuscarClienteView();
        //    form.ShowDialog();
        //    cliente = form._cliente;
        //    vista.IdentidadMaskedTextBox.Text = cliente.Identidad;
        //    vista.NombreTextBox.Text = cliente.Nombre;
        //}

        //private void txt_IdLibro_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        libro = libroDAO.GetLibroPorNombre(vista.txt_IdLibro.Text);

        //        vista.txt_IdLibro.Text = cliente.Nombre;
        //    }
        //    else
        //    {
        //        cliente = null;
        //        vista.NombreTextBox.Clear();
        //    }
        //}



    
}
