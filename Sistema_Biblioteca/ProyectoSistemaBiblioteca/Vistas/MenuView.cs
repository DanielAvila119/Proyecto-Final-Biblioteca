﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoSistemaBiblioteca.Vistas
{
    public partial class MenuView : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuView()
        {
            InitializeComponent();
        }
        ClienteView vistaClientes;
        LibroView vistaLibro;

        private void ClientesToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaClientes == null)
            {
                vistaClientes = new ClienteView();
                vistaClientes.MdiParent = this;
                vistaClientes.FormClosed += VistaClientes_FormClosed;
                vistaClientes.Show();
            }
            else
            {
                vistaClientes.Activate();
            }
        }

        private void VistaClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaClientes = null;
        }

        private void LibrosToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaLibro == null)
            {
                vistaLibro = new LibroView();
                vistaLibro.MdiParent = this;
                vistaLibro.FormClosed += VistaLibro_FormClosed;
                vistaLibro.Show();
            }
            else
            {
                vistaClientes.Activate();
            }
        }

        private void VistaLibro_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaLibro = null;
        }
    }
}
