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
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO DETALLEPRESTAMO ");
                sql.Append(" VALUES (@IdPrestamo, @IdLibro, @NombreLibro, @IdCliente, @NombreCliente, @Prestamo, @Devolucion, @Cobro, @Multa); ");
                sql.Append(" SELECT SCOPE_IDENTITY() ");

               

                comando.Transaction = transaction;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@IdPrestamo", SqlDbType.DateTime).Value = detalle.IdPrestamo;
                comando.Parameters.Add("@IdLibro", SqlDbType.Int).Value = detalle.IdLibro;
                comando.Parameters.Add("@NombreLibro", SqlDbType.NVarChar,100).Value=detalle.NombreLibro;
                comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = detalle.IdCliente;
                comando.Parameters.Add("@NombreCliente", SqlDbType.NVarChar, 50).Value = detalle.NombreCliente;
                comando.Parameters.Add("@Prestamo", SqlDbType.DateTime).Value = detalle.Prestamo;
                comando.Parameters.Add("@Devolucion", SqlDbType.DateTime).Value = detalle.Devolucion;
                comando.Parameters.Add("@Cobro", SqlDbType.Decimal).Value = detalle.Cobro;
                comando.Parameters.Add("@Multa", SqlDbType.NVarChar, 50).Value = detalle.Multa;

                int IdFactura = Convert.ToInt32(comando.ExecuteScalar());

                foreach (var item in prestamo)
                {
                    comando.Transaction = transaction;
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = sqlD.ToString();
                    comando.Parameters.Add("@FechaPrestamo", SqlDbType.Int).Value = prestamo.;
                    comando.Parameters.Add("@FechaEntrega", SqlDbType.Int).Value = item;
                    comando.Parameters.Add("@FechaDevolucion", SqlDbType.Int).Value = item.Cantidad;
                    comando.Parameters.Add("@IdEjemplar", SqlDbType.Decimal).Value = item.Precio;
                    comando.Parameters.Add("@IdCliente", SqlDbType.Decimal).Value = item.Total;
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
