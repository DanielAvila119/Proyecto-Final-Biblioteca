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
    public class PrestamoDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();
        public bool InsertarNuevoPrestamo(Prestamo prestamo, Cliente cliente)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO PRESTAMO ");
                sql.Append(" VALUES (@FechaPrestamo, @FechaEntrega, @FechaDevolucion, @IdEjemplar, @IdCliente); ");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@FechaPrestamo", SqlDbType.DateTime).Value = prestamo.FechaPrestamo;
                comando.Parameters.Add("@FechaEntrega", SqlDbType.DateTime).Value = prestamo.FechaEntrega;
                comando.Parameters.Add("@FechaDevolucion", SqlDbType.DateTime).Value = prestamo.FechaDevolucion;
                //comando.Parameters.Add("@IdEjemplar", SqlDbType.Decimal).Value = prestamo.;
                comando.Parameters.Add("@IdCliente", SqlDbType.Decimal).Value = cliente.Id;
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
        public DataTable GetPrestamo()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM PRESTAMO ");
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
        public bool ActualizarPrestamo(Prestamo prestamo, Cliente cliente)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE PRESTAMO ");
                sql.Append(" SET FECHAPRESTAMO = @FechaPrestamo, FECHAENTREGA = @FechaEntrega, FECHADEVOLUCION = @FechaDevolucion, " +
                    "MULTA = @Multa, IDEJEMPLAR = @IdEjemplar, IDCLIENTE= @IdCliente");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@FechaPrestamo", SqlDbType.DateTime).Value = prestamo.FechaPrestamo;
                comando.Parameters.Add("@FechaEntrega", SqlDbType.DateTime).Value = prestamo.FechaEntrega;
                comando.Parameters.Add("@FechaDevolucion", SqlDbType.DateTime).Value = prestamo.FechaDevolucion;
                //comando.Parameters.Add("@IdEjemplar", SqlDbType.Decimal).Value = prestamo.IdEjemplar;
                comando.Parameters.Add("@IdCliente", SqlDbType.Decimal).Value = cliente.Id;
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
        public bool EliminarPrestamo(int id)
        {
            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM PRESTAMO ");
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

