using ProyectoSistemaBiblioteca.Controladores;
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
    public partial class PrestamoView : Form
    {
        public PrestamoView()
        {
            InitializeComponent();
            PrestamoController controlador = new PrestamoController(this);
        }
    }
}
