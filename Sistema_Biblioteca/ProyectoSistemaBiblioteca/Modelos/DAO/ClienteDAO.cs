using ProyectoSistemaBiblioteca.Modelos.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ProyectoSistemaBiblioteca.Modelos.DAO
{
    public class ClienteDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();
        public bool InsertarNuevoCliente(Cliente cliente)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO CLIENTE ");
                sql.Append(" VALUES (@Nombre, @Direccion, @Telefono, @Email, @Ocupacion); ");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = cliente.Nombre;
                comando.Parameters.Add("@Direccion", SqlDbType.NVarChar, 50).Value = cliente.Direccion;
                comando.Parameters.Add("@Telefono", SqlDbType.NVarChar, 50).Value = cliente.Telefono;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = cliente.Email;
                comando.Parameters.Add("@Ocupacion", SqlDbType.NVarChar, 50).Value = cliente.Direccion;
                comando.ExecuteNonQuery();
                inserto = true;
                MiConexion.Close();
                //return true;

            }
            catch (Exception)
            {
                inserto = false;
            }
            return inserto;
        }
        public DataTable GetCliente()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM CLIENTE ");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                MiConexion.Close();
            }
            catch (Exception)
            {
            }
            return dt;
        }
        public DataTable GetClientePorNombre(string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM CLIENTE WHERE LIKE ('%" + nombre +"%')");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                MiConexion.Close();
            }
            catch (Exception)
            {
                MiConexion.Close();

            }
            return dt;
        }
        public bool ActualizarCliente(Cliente cliente)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE CLIENTE ");
                sql.Append(" SET NOMBRE = @Nombre, DIRECCION = @Direccion, TELEFONO = @Telefono, EMAIL = @Email, OCUPACION = @Ocupacion ");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = cliente.Id;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = cliente.Nombre;
                comando.Parameters.Add("@Direccion", SqlDbType.NVarChar, 50).Value = cliente.Direccion;
                comando.Parameters.Add("@Telefono", SqlDbType.NVarChar, 50).Value = cliente.Telefono;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = cliente.Email;
                comando.Parameters.Add("@Ocupacion", SqlDbType.NVarChar, 50).Value = cliente.Direccion;
                comando.ExecuteNonQuery();
                modifico = true;
                MiConexion.Close();

            }
            catch (Exception)
            {

                return modifico;
            }
            return modifico;
        }
        public bool EliminarCliente(int id)
        {
            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM CLIENTE ");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                comando.ExecuteNonQuery();
                elimino = true;
                MiConexion.Close();

            }
            catch (Exception)
            {

                return elimino;
            }
            return elimino;
        }

    }
}
