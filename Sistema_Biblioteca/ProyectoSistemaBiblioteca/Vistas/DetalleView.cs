using ProyectoSistemaBiblioteca.Controladores;
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
    public partial class DetalleView : Form
    {
        public DetalleView()
        {
            
        InitializeComponent();
        DetalleController controlador = new DetalleController(this);
        }
        PrestamoDAO prestamoDAO = new PrestamoDAO();
        public Prestamo _prestamo = new Prestamo();

        private void DetalleView_Load(object sender, EventArgs e)
        {
            DetalledataGridView.DataSource = prestamoDAO.GetPrestamo();
        }

        private void EntregadateTimePicker1_KeyUp(object sender, EventArgs e)
        {
            DetalledataGridView.DataSource = prestamoDAO.GetPrestamoPorID(EntregadateTimePicker1.Text);
        }

       

        private void DevoluciondateTimePicker2_KeyUp(object sender, EventArgs e)
        {
            DetalledataGridView.DataSource = prestamoDAO.GetPrestamoPorID(DevoluciondateTimePicker2.Text);
        }
    }
}
