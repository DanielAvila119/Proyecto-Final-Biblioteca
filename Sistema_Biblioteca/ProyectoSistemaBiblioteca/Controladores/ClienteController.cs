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
    public class ClienteController
    {
        ClienteView vista;
        ClienteDAO clienteDAO = new ClienteDAO();
        Cliente cliente = new Cliente();
        string operacion = string.Empty;

        public ClienteController(ClienteView view)
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
            if (vista.ClientesDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = clienteDAO.EliminarCliente(Convert.ToInt32(vista.ClientesDataGridView.CurrentRow.Cells[0].Value.ToString()));
                if (elimino)
                {
                    DeshabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("¡Usuario Eliminado Exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarClientes();
                }
                else
                {
                    MessageBox.Show("No se puedo Eliminar el usuario. Vuelvalo a intentar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Modificar(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (vista.ClientesDataGridView.SelectedRows.Count > 0)
            {
                vista.txt_ID.Text = vista.ClientesDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                vista.txt_Nombre.Text = vista.ClientesDataGridView.CurrentRow.Cells["NOMBRE"].Value.ToString();
                vista.txt_Direccion.Text = vista.ClientesDataGridView.CurrentRow.Cells["DIRECCION"].Value.ToString();
                vista.txt_Telefono.Text = vista.ClientesDataGridView.CurrentRow.Cells["TELEFONO"].Value.ToString();
                vista.txt_Email.Text = vista.ClientesDataGridView.CurrentRow.Cells["EMAIL"].Value.ToString();
                vista.txt_Ocupacion.Text = vista.ClientesDataGridView.CurrentRow.Cells["OCUPACION"].Value.ToString();

                HabilitarControles();
            }
        }
        private void Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void ListarClientes()
        {
            vista.ClientesDataGridView.DataSource = clienteDAO.GetCliente();
        }
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }
        private void Guardar(object sender, EventArgs e)
        {
           
            if (vista.txt_Nombre.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_Nombre, "Por favor ingrese un Nombre");
                vista.txt_Nombre.Focus();
                return;
            }
            if (vista.txt_Direccion.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_Direccion, "Por favor ingrese una Dirección");
                vista.txt_Direccion.Focus();
                return;
            }
            if (vista.txt_Telefono.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_Telefono, "Por favor ingrese un Numero De Telefono");
                vista.txt_Telefono.Focus();
                return;
            }
            if (vista.txt_Email.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_Email, "Por favor ingrese un Email");
                vista.txt_Email.Focus();
                return;
            }
            if (vista.txt_Ocupacion.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_Ocupacion, "Por favor ingrese una Ocupacion");
                vista.txt_Ocupacion.Focus();
                return;
            }

            try
            {
              
                cliente.Nombre = vista.txt_Nombre.Text.ToUpper();
                cliente.Direccion = vista.txt_Direccion.Text;
                cliente.Telefono = vista.txt_Telefono.Text;
                cliente.Email = vista.txt_Email.Text;
                cliente.Ocupacion = vista.txt_Ocupacion.Text;

                if (operacion == "Nuevo")
                {
                    bool inserto = clienteDAO.InsertarNuevoCliente(cliente);
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
                    cliente.Id = Convert.ToInt32(vista.txt_ID.Text);
                    bool modifico = clienteDAO.ActualizarCliente(cliente);
                    if (modifico)
                    {
                        DeshabilitarControles();
                        LimpiarControles();

                        MessageBox.Show("¡Usuario Modificado Exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarClientes();
                    }
                    else
                    {
                        MessageBox.Show("No se puedo Modificar el usuario. Vuelvalo a intentar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
           
            vista.txt_Nombre.Enabled = true;
            vista.txt_Direccion.Enabled = true;
            vista.txt_Telefono.Enabled = true;
            vista.txt_Email.Enabled = true;
            vista.txt_Ocupacion.Enabled = true;

            //Habilitar Botones
            vista.btn_Guardar.Enabled = true;
            vista.btn_cancelar.Enabled = true;
            vista.btn_Eliminar.Enabled = true;
            vista.btn_Modificar.Enabled = false;
            vista.btn_Nuevo.Enabled = false;

        }
        private void DeshabilitarControles()
        {
            //Deshabilitar TextBoxs
            vista.txt_Nombre.Enabled = false;
            vista.txt_Direccion.Enabled = false;
            vista.txt_Telefono.Enabled = false;
            vista.txt_Email.Enabled = false;
            vista.txt_Ocupacion.Enabled = false;

            //Habilitar y desahiblitar Botones
            vista.btn_Guardar.Enabled = false;
            vista.btn_cancelar.Enabled = false;
            vista.btn_Eliminar.Enabled = false;
            vista.btn_Modificar.Enabled = true;
            vista.btn_Nuevo.Enabled = true;

            
        }
        private void LimpiarControles()
        {
            vista.txt_ID.Clear();
            vista.txt_Nombre.Clear();
            vista.txt_Email.Clear();
            vista.txt_Ocupacion.Clear();
            vista.txt_Direccion.Clear();
            vista.txt_Telefono.Clear();
        }


    }
}
