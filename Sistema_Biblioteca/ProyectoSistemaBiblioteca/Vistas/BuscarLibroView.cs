using ProyectoSistemaBiblioteca.Modelos.DAO;
using ProyectoSistemaBiblioteca.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSistemaBiblioteca.Vistas
{
    public partial class BuscarLibroView : Form
    {
        public BuscarLibroView()
        {
            InitializeComponent();
        }


        LibroDAO libroDAO = new LibroDAO();
        public Libro _libro = new Libro();

        private void BuscarLibroView_Load(object sender, EventArgs e)
        {
            LibrosdataGridView.DataSource = libroDAO.GetLibro();
        }

        private void NombreLibroTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            LibrosdataGridView.DataSource = libroDAO.GetLibroPorNombre(NombreLibroTextBox.Text);

        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (LibrosdataGridView.RowCount > 0)
            {
                if (LibrosdataGridView.SelectedRows.Count > 0)
                {
                    _libro.Id = (int)LibrosdataGridView.CurrentRow.Cells["ID"].Value;
                    _libro.Titulo = LibrosdataGridView.CurrentRow.Cells["TITULO"].Value.ToString();
                    this.Close();
                }
            }
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarLibroView_Load_1(object sender, EventArgs e)
        {

        }

        private void NombreLibroTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
