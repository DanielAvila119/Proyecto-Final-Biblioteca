using ProyectoSistemaBiblioteca.Modelos.DAO;
using ProyectoSistemaBiblioteca.Modelos.Entidades;
using ProyectoSistemaBiblioteca.Vistas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSistemaBiblioteca.Controladores
{
    public class LoginController
    {
        LoginView vista;

        public LoginController(LoginView view)
        {
            vista = view;
            vista.btn_Aceptar.Click += new EventHandler(ValidarUsuario);
        }

        private void ValidarUsuario(object sender, EventArgs e)
        {
            bool esValido = false;
            LoginDAO loginDAO = new LoginDAO();

            Login login = new Login();
            login.Email = vista.txt_Email.Text;
            login.Clave = EncriptarClave(vista.txt_Clave.Text);

            esValido = loginDAO.ValidarUsuario(login);
            if (esValido)
            {
                //MessageBox.Show("Usuario Correcto");
                MenuView menu = new MenuView();
                vista.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto, Vuelva A Intentarlo");
            }
        }

        public static string EncriptarClave(string str)
        {
            string cadena = str + "MiClavePersonal";
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(cadena));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();

        }
    }
}
