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
    public class PrestamoController
    {
        PrestamoView vista;
        PrestamoDAO prestamoDAO = new PrestamoDAO();
        Prestamo prestamo = new Prestamo();
        string operacion = string.Empty;

        public PrestamoController(PrestamoView view)
        {
            vista = view;
            vista.btn_Nuevo.Click += new EventHandler(Nuevo);
            vista.btn_Guardar.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
            vista.btn_Modificar.Click += new EventHandler(Modificar);
            vista.btn_Eliminar.Click += new EventHandler(Eliminar);
        }

        private void Eliminar(object sender, EventArgs e)
        {
            if (vista.PrestamoDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = prestamoDAO.EliminarPrestamo(Convert.ToInt32(vista.PrestamoDataGridView.CurrentRow.Cells[0].Value.ToString()));
                if (elimino)
                {
                    DeshabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("¡Préstamo Eliminado Exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarPrestamo();
                }
                else
                {
                    MessageBox.Show("No se puedo Eliminar el préstamo. Vuelvalo a intentar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Modificar(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (vista.PrestamoDataGridView.SelectedRows.Count > 0)
            {
                vista.txt_ID.Text = vista.PrestamoDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                vista.PrestamoDateTimePicker.Text = vista.PrestamoDataGridView.CurrentRow.Cells["FECHAPRESTAMO"].Value.ToString();
                vista.EntregaDateTimePicker.Text = vista.PrestamoDataGridView.CurrentRow.Cells["FECHAENTREGA"].Value.ToString();
                vista.DevolucionDateTimePicker.Text = vista.PrestamoDataGridView.CurrentRow.Cells["FECHADEVOLUCION"].Value.ToString();
                vista.txt_Multa.Text = vista.PrestamoDataGridView.CurrentRow.Cells["MULTA"].Value.ToString();
                vista.TxtIdEjemplar.Text = vista.PrestamoDataGridView.CurrentRow.Cells["IDEJEMPLAR"].Value.ToString();
                vista.TxtIdCliente.Text = vista.PrestamoDataGridView.CurrentRow.Cells["IDCLIENTE"].Value.ToString();
                HabilitarControles();
            }
        }
        private void Load(object sender, EventArgs e)
        {
            ListarPrestamo();
        }

        private void ListarPrestamo()
        {
            vista.PrestamoDataGridView.DataSource = prestamoDAO.GetPrestamo();
        }
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }
        private void Guardar(object sender, EventArgs e)
        {

            if (vista.PrestamoDateTimePicker.Text == "")
            {
                vista.errorProvider1.SetError(vista.PrestamoDateTimePicker, "Por favor ingrese una fecha de préstamo");
                vista.PrestamoDateTimePicker.Focus();
                return;
            }
            if (vista.EntregaDateTimePicker.Text == "")
            {
                vista.errorProvider1.SetError(vista.EntregaDateTimePicker, "Por favor ingrese una fecha de entrega");
                vista.EntregaDateTimePicker.Focus();
                return;
            }
            if (vista.DevolucionDateTimePicker.Text == "")
            {
                vista.errorProvider1.SetError(vista.DevolucionDateTimePicker, "Por favor ingrese una fecha de devolución");
                vista.DevolucionDateTimePicker.Focus();
                return;
            }
            if (vista.TxtIdEjemplar.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_Multa, "Por favor ingrese un id de ejemplar");
                vista.TxtIdEjemplar.Focus();
                return;
            }
            if (vista.TxtIdCliente.Text == "")
            {
                vista.errorProvider1.SetError(vista.TxtIdCliente, "Por favor ingrese un id cliente");
                vista.TxtIdCliente.Focus();
                return;
            }

            try
            {

                prestamo.FechaPrestamo = vista.PrestamoDateTimePicker.Value;
                prestamo.FechaEntrega = vista.EntregaDateTimePicker.Value;
                prestamo.FechaDevolucion = vista.DevolucionDateTimePicker.Value;
                prestamo.Multa = Convert.ToDecimal(vista.txt_Multa.Text);
                prestamo.IdEjemplar = Convert.ToInt32( vista.TxtIdEjemplar.Text);
                prestamo.IdCliente = Convert.ToInt32(vista.TxtIdCliente.Text);

                if (operacion == "Nuevo")
                {
                    bool inserto = prestamoDAO.InsertarNuevoPrestamo(prestamo);
                    if (inserto)
                    {
                        MessageBox.Show("Cliente creado exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear el Cliente, intente denuevo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (operacion == "Modificar")
                {
                    prestamo.Id = Convert.ToInt32(vista.txt_ID.Text);
                    bool modifico = prestamoDAO.ActualizarPrestamo(prestamo);
                    if (modifico)
                    {
                        DeshabilitarControles();
                        LimpiarControles();

                        MessageBox.Show("¡Préstamo Modificado Exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarPrestamo();
                    }
                    else
                    {
                        MessageBox.Show("No se puedo Modificar el préstamo. Vuelvalo a intentar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

            }

        }
        private void HabilitarControles()
        {
            //Habilitar TextBoxs

            vista.PrestamoDateTimePicker.Enabled = true;
            vista.EntregaDateTimePicker.Enabled = true;
            vista.DevolucionDateTimePicker.Enabled = true;
            vista.txt_Multa.Enabled = true;
            vista.TxtIdEjemplar.Enabled = true;
            vista.TxtIdCliente.Enabled = true;

            //Habilitar Botones
            vista.btn_Guardar.Enabled = true;
            vista.btn_Cancelar.Enabled = true;
            vista.btn_Eliminar.Enabled = true;
            vista.btn_Modificar.Enabled = true;
            vista.btn_Nuevo.Enabled = false;

        }
        private void DeshabilitarControles()
        {
            //Deshabilitar TextBoxs
            vista.PrestamoDateTimePicker.Enabled = false;
            vista.EntregaDateTimePicker.Enabled = false;
            vista.DevolucionDateTimePicker.Enabled = false;
            vista.txt_Multa.Enabled = false;
            vista.TxtIdEjemplar.Enabled = false;
            vista.TxtIdCliente.Enabled = false;

            //Habilitar y desahiblitar Botones
            vista.btn_Guardar.Enabled = false;
            vista.btn_Cancelar.Enabled = false;
            vista.btn_Eliminar.Enabled = false;
            vista.btn_Modificar.Enabled = false;
            vista.btn_Nuevo.Enabled = true;


        }
        private void LimpiarControles()
        {
            vista.txt_ID.Clear();
            vista.PrestamoDateTimePicker.Value.ToString();
            vista.EntregaDateTimePicker.Value.ToString();
            vista.DevolucionDateTimePicker.Value.ToString();
            vista.txt_Multa.Clear();
            vista.TxtIdEjemplar.Clear();
            vista.TxtIdCliente.Clear();
        }
    }
}
