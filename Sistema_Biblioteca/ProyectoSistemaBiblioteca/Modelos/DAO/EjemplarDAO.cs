using ProyectoSistemaBiblioteca.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSistemaBiblioteca.Modelos.DAO
{
    public class EjemplarDAO: Conexion
    {
        SqlCommand comando = new SqlCommand();
        public bool InsertarNuevoEjemplar(Ejemplar ejemplar)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO EJEMPLAR ");
                sql.Append(" VALUES (@Numeroejemplar, @Edoconservacion, @Idlibro); ");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Numeroejemplar", SqlDbType.NVarChar, 50).Value = ejemplar.Numeroejemplar;
                comando.Parameters.Add("@Edoconservacion", SqlDbType.NVarChar, 50).Value = ejemplar.Edoconservacion;
                comando.Parameters.Add("@Idlibro", SqlDbType.Int).Value = ejemplar.Idlibro;
                comando.ExecuteNonQuery();
                inserto = true;
                MiConexion.Close();
                return true;

            }
            catch (Exception)
            {
                inserto = false;
            }
            return inserto;
        }
        public DataTable GetEjemplar()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM EJEMPLAR ");
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
        public bool ActualizarEjemplar(Ejemplar ejemplar)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE EJEMPLAR ");
                sql.Append(" SET NUMEROEJEMPLAR = @Numeroejemplar, EDOCONSERVACION = @Edoconservacion, IDLIBRO = @Idlibro ");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = ejemplar.Id;
                comando.Parameters.Add("@Numeroejemplar", SqlDbType.NVarChar, 50).Value = ejemplar.Numeroejemplar;
                comando.Parameters.Add("@Edoconservacion", SqlDbType.NVarChar, 50).Value = ejemplar.Edoconservacion;
                comando.Parameters.Add("@Idlibro", SqlDbType.Int).Value = ejemplar.Idlibro;
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
        public bool EliminarEjemplar(int id)
        {
            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM EJEMPLAR ");
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
