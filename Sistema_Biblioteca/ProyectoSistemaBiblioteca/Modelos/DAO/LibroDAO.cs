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
    public class LibroDAO : Conexion
    {

        SqlCommand comando = new SqlCommand();
        public bool InsertarNuevoLibro(Libro libro)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO LIBRO ");
                sql.Append(" VALUES (@Titulo, @Autor, @Editorial, @NumeroEdicion, @NumeroEjemplares); ");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Titulo", SqlDbType.NVarChar, 50).Value = libro.Titulo;
                comando.Parameters.Add("@Autor", SqlDbType.NVarChar, 50).Value = libro.Autor;
                comando.Parameters.Add("@Editorial", SqlDbType.NVarChar, 50).Value = libro.Editorial;
                comando.Parameters.Add("@NumeroEdicion", SqlDbType.NVarChar, 50).Value = libro.NumeroEdicion;
                comando.Parameters.Add("@NumeroEjemplares", SqlDbType.NVarChar, 50).Value = libro.NumeroEjemplares;
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
        public DataTable GetLibro()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM LIBRO ");
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
        public Libro GetLibroPorID(string id)
        {
            Libro libro = new Libro();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM LIBRO ");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    libro.Id = (int)dr["ID"];
                    libro.Titulo = (string)dr["TITULO"];
                    libro.Autor = (string)dr["AUTOR"];
                    libro.Editorial = (string)dr["EDITORIAL"];
                    libro.NumeroEdicion = (string)dr["NUMEROEDICION"];
                    libro.NumeroEjemplares = (string)dr["NUMEROEJEMPLARES"];
                }

                MiConexion.Close();

            }
            catch (Exception ex)
            {
                MiConexion.Close();
            }
            return libro;
        }
        public DataTable GetLibroPorNombre(string titulo)
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM LIBRO WHERE LIKE ('%" + titulo + "%') "); 
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
        public bool ActualizarLibro(Libro libro)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE LIBRO ");
                sql.Append(" SET TITULO = @Titulo, AUTOR = @Autor, EDITORIAL = @Editorial, NUMEROEDICION = @NumeroEdicion, NUMEROEJEMPLARES = @NumeroEjemplares ");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = libro.Id;
                comando.Parameters.Add("@Titulo", SqlDbType.NVarChar, 50).Value = libro.Titulo;
                comando.Parameters.Add("@Autor", SqlDbType.NVarChar, 50).Value = libro.Autor;
                comando.Parameters.Add("@Editorial", SqlDbType.NVarChar, 50).Value = libro.Editorial;
                comando.Parameters.Add("@NumeroEdicion", SqlDbType.NVarChar, 50).Value = libro.NumeroEdicion;
                comando.Parameters.Add("@NumeroEjemplares", SqlDbType.NVarChar, 50).Value = libro.NumeroEjemplares;
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
        public bool EliminarLibro(int id)
        {
            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM LIBRO ");
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
