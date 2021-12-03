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
    public class DetalleDAO:Conexion
    {
        SqlCommand comando = new SqlCommand();
        SqlCommand comando2 = new SqlCommand();
        

        public bool InsertarNuevoDetallePrestamo(Detalle detalle, List<Prestamo> prestamo)
        {
            bool inserto = false;
            MiConexion.Close();
            comando.Connection = MiConexion;
            MiConexion.Open();

            SqlTransaction transaction = MiConexion.BeginTransaction(IsolationLevel.ReadCommitted);

            try
            {
                StringBuilder sqlD = new StringBuilder();
                sqlD.Append(" INSERT INTO DETALLEPRESTAMO ");
                sqlD.Append(" VALUES (@IdPrestamo, @IdLibro, @NombreLibro, @IdCliente, @NombreCliente, @Prestamo, @Devolucion, @Cobro, @Multa); ");
                sqlD.Append(" SELECT SCOPE_IDENTITY() ");

               

                comando.Transaction = transaction;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sqlD.ToString();
                comando.Parameters.Add("@IdPrestamo", SqlDbType.DateTime).Value = detalle.IdPrestamo;
                comando.Parameters.Add("@IdLibro", SqlDbType.Int).Value = detalle.IdLibro;
                comando.Parameters.Add("@NombreLibro", SqlDbType.NVarChar,100).Value=detalle.NombreLibro;
                comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = detalle.IdCliente;
                comando.Parameters.Add("@NombreCliente", SqlDbType.NVarChar, 50).Value = detalle.NombreCliente;
                comando.Parameters.Add("@Prestamo", SqlDbType.DateTime).Value = detalle.Prestamo;
                comando.Parameters.Add("@Devolucion", SqlDbType.DateTime).Value = detalle.Devolucion;
                comando.Parameters.Add("@Cobro", SqlDbType.Decimal).Value = detalle.Cobro;
                comando.Parameters.Add("@Multa", SqlDbType.NVarChar, 50).Value = detalle.Multa;

                int IdPrestamo = Convert.ToInt32(comando.ExecuteScalar());

                foreach (var item in prestamo)
                {
                    comando.Transaction = transaction;
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = sqlD.ToString();
                    comando.Parameters.Add("@FechaPrestamo", SqlDbType.Date).Value = item.FechaPrestamo  ;
                    comando.Parameters.Add("@FechaEntrega", SqlDbType.Date).Value = item.FechaEntrega ;
                    comando.Parameters.Add("@FechaDevolucion", SqlDbType.Date).Value = item.FechaDevolucion ;
                    comando.Parameters.Add("@IdEjemplar", SqlDbType.Int).Value = item.IdEjemplar;
                    comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = item.IdCliente;
                    comando.ExecuteNonQuery();
                }
                transaction.Commit();
                MiConexion.Close();
            }
            catch (Exception ex)
            {
                inserto = false;
                transaction.Rollback();
            }
            return inserto;
        }

        internal static bool InsertarNuevaFactura(Detalle detalle)
        {
            throw new NotImplementedException();
        }
    }
}
