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
    public class EjemplarController
    {
        EjemplarView vista;
        EjemplarDAO ejemplarDAO = new EjemplarDAO();
        Ejemplar ejemplar = new Ejemplar();
        string operacion = string.Empty;

        public EjemplarController(EjemplarView view)
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
            if (vista.EjemplarDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = ejemplarDAO.EliminarEjemplar(Convert.ToInt32(vista.EjemplarDataGridView.CurrentRow.Cells[0].Value.ToString()));
                if (elimino)
                {
                    DeshabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("¡Ejemplar Eliminado Exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarEjemplares();
                }
                else
                {
                    MessageBox.Show("No Se Pudo Eliminar El Ejemplar. Vuelvalo A Intentarlo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Modificar(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (vista.EjemplarDataGridView.SelectedRows.Count > 0)
            {
                vista.txt_ID.Text = vista.EjemplarDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                vista.txt_NumEjemplar.Text = vista.EjemplarDataGridView.CurrentRow.Cells["NUMEROEJEMPLAR"].Value.ToString();
                vista.txt_EstadoConservacion.Text = vista.EjemplarDataGridView.CurrentRow.Cells["EDOCONSERVACION"].Value.ToString();
                vista.txt_Idlibro.Text = vista.EjemplarDataGridView.CurrentRow.Cells["IDLIBRO"].Value.ToString();

                HabilitarControles();
            }
        }
        private void Load(object sender, EventArgs e)
        {
            ListarEjemplares();
        }

        private void ListarEjemplares()
        {
            vista.EjemplarDataGridView.DataSource = ejemplarDAO.GetEjemplar();
        }
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }
        private void Guardar(object sender, EventArgs e)
        {
            if (vista.txt_NumEjemplar.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_NumEjemplar, "Por Favor Ingrese Un Ejemplar");
                vista.txt_NumEjemplar.Focus();
                return;
            }
            if (vista.txt_EstadoConservacion.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_EstadoConservacion, "Por Favor Ingrese El Estado");
                vista.txt_EstadoConservacion.Focus();
                return;
            }
            if (vista.txt_Idlibro.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_Idlibro, "Por Favor Ingrese Un ID De libro");
                vista.txt_Idlibro.Focus();
                return;
            }

            try
            {

                ejemplar.Numeroejemplar = vista.txt_NumEjemplar.Text.ToUpper();
                ejemplar.Edoconservacion = vista.txt_EstadoConservacion.Text;
                ejemplar.Idlibro = Convert.ToInt32(vista.txt_Idlibro.Text);

                if (operacion == "Nuevo")
                {
                    bool inserto = ejemplarDAO.InsertarNuevoEjemplar(ejemplar);
                    if (inserto)
                    {
                        MessageBox.Show("Ejemplar Creado Exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Se Pudo Crear El Ejemplar, Intente De Nuevo Por Favor", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (operacion == "Modificar")
                {
                    ejemplar.Id = Convert.ToInt32(vista.txt_ID.Text);
                    bool modifico = ejemplarDAO.ActualizarEjemplar(ejemplar);
                    if (modifico)
                    {
                        DeshabilitarControles();
                        LimpiarControles();

                        MessageBox.Show("¡Ejemplar Modificado Exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarEjemplares();
                    }
                    else
                    {
                        MessageBox.Show("No Se Pudo Modificar El Ejemplar. Vuelvalo A Intentar Por Favor", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            vista.txt_NumEjemplar.Enabled = true;
            vista.txt_EstadoConservacion.Enabled = true;
            vista.txt_Idlibro.Enabled = true;

            //Habilitar Botones
            vista.btn_Guardar.Enabled = true;
            vista.btn_Cancelar.Enabled = true;
            vista.btn_Eliminar.Enabled = true;
            vista.btn_Modificar.Enabled = false;
            vista.btn_Nuevo.Enabled = false;

        }
        private void DeshabilitarControles()
        {
            //Deshabilitar TextBoxs
            vista.txt_NumEjemplar.Enabled = false;
            vista.txt_EstadoConservacion.Enabled = false;
            vista.txt_Idlibro.Enabled = false;

            //Habilitar y desahiblitar Botones
            vista.btn_Guardar.Enabled = false;
            vista.btn_Cancelar.Enabled = false;
            vista.btn_Eliminar.Enabled = false;
            vista.btn_Modificar.Enabled = true;
            vista.btn_Nuevo.Enabled = true;


        }
        private void LimpiarControles()
        {
            vista.txt_ID.Clear();
            vista.txt_NumEjemplar.Clear();
            vista.txt_EstadoConservacion.Clear();
            vista.txt_Idlibro.Clear();
        }
    }
}
