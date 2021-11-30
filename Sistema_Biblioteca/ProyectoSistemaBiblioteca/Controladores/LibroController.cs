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
    public class LibroController
    {
        LibroView vista;
        LibroDAO libroDAO = new LibroDAO();
        Libro libro = new Libro();
        string operacion = string.Empty;

        public LibroController(LibroView view)
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
            if (vista.LibrosDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = libroDAO.EliminarLibro(Convert.ToInt32(vista.LibrosDataGridView.CurrentRow.Cells[0].Value.ToString()));
                if (elimino)
                {
                    DeshabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("¡Libro Eliminado Exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarLibros();
                }
                else
                {
                    MessageBox.Show("No se puedo Eliminar el libro. Vuelvalo a intentar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Modificar(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (vista.LibrosDataGridView.SelectedRows.Count > 0)
            {
                vista.txt_ID.Text = vista.LibrosDataGridView.CurrentRow.Cells["ID"].Value.ToString();
                vista.txt_Titulo.Text = vista.LibrosDataGridView.CurrentRow.Cells["TITULO"].Value.ToString();
                vista.txt_Autor.Text = vista.LibrosDataGridView.CurrentRow.Cells["AUTOR"].Value.ToString();
                vista.txt_Editor.Text = vista.LibrosDataGridView.CurrentRow.Cells["EDITORIAL"].Value.ToString();
                vista.txt_NumEdicion.Text = vista.LibrosDataGridView.CurrentRow.Cells["NUMEROEDICION"].Value.ToString();
                vista.txt_NumEjemplares.Text = vista.LibrosDataGridView.CurrentRow.Cells["NUMEROEJEMPLARES"].Value.ToString();

                HabilitarControles();
            }
        }
        private void Load(object sender, EventArgs e)
        {
            ListarLibros();
        }

        private void ListarLibros()
        {
            vista.LibrosDataGridView.DataSource = libroDAO.GetLibro();
        }
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }
        private void Guardar(object sender, EventArgs e)
        {
          
            if (vista.txt_Titulo.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_Titulo, "Por favor ingrese el titulo");
                vista.txt_Titulo.Focus();
                return;
            }

            if (vista.txt_Autor.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_Autor, "Por favor ingrese el autor");
                vista.txt_Autor.Focus();
                return;
            }
            if (vista.txt_Editor.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_Editor, "Por favor ingrese el editor");
                vista.txt_Editor.Focus();
                return;
            }
            if (vista.txt_NumEdicion.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_NumEdicion, "Por favor ingrese el numero de edicion");
                vista.txt_NumEdicion.Focus();
                return;
            }
            if (vista.txt_NumEjemplares.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_NumEjemplares, "Por favor ingrese el numero de ejemplares del libro");
                vista.txt_NumEjemplares.Focus();
                return;
            }

            try
            {

                libro.Titulo = vista.txt_Titulo.Text.ToUpper();
                libro.Autor = vista.txt_Autor.Text;
                libro.Editorial = vista.txt_Editor.Text;
                libro.NumeroEdicion = vista.txt_NumEdicion.Text;
                libro.NumeroEjemplares = vista.txt_NumEjemplares.Text;

                if (operacion == "Nuevo")
                {
                    bool inserto = libroDAO.InsertarNuevoLibro(libro);
                    if (inserto)
                    {
                        MessageBox.Show("libro insertedo exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar el libro, intente denuevo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else if (operacion == "Modificar")
                {
                    libro.Id = Convert.ToInt32(vista.txt_ID.Text);
                    bool modifico = libroDAO.ActualizarLibro(libro);
                    if (modifico)
                    {
                        DeshabilitarControles();
                        LimpiarControles();

                        MessageBox.Show("¡Libro Modificado Exitosamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarLibros();
                    }
                    else
                    {
                        MessageBox.Show("No se puedo Modificar el libro. Vuelvalo a intentar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            vista.txt_Titulo.Enabled = true;
            vista.txt_Autor.Enabled = true;
            vista.txt_Editor.Enabled = true;
            vista.txt_NumEdicion.Enabled = true;
            vista.txt_NumEjemplares.Enabled = true;

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
            vista.txt_Titulo.Enabled = false;
            vista.txt_Autor.Enabled = false;
            vista.txt_Editor.Enabled = false;
            vista.txt_NumEdicion.Enabled = false;
            vista.txt_NumEjemplares.Enabled = false;

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
            vista.txt_Titulo.Clear();
            vista.txt_Autor.Clear();
            vista.txt_Editor.Clear();
            vista.txt_NumEdicion.Clear();
            vista.txt_NumEjemplares.Clear();
        }

    }
}
