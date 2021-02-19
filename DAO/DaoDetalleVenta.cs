using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace DAO
{
	public class DaoDetalleVenta
	{
		AccesoDatos ds = new AccesoDatos();

		public DataTable getTablaDetalleVenta()
		{
			List<Detalle_x_Venta> lista = new List<Detalle_x_Venta>();
			DataTable tabla = ds.ObtenerTabla("DetalleVenta", "select Detalle_x_Venta.IdProd as 'Id Producto',Productos.Nombre as 'Nombre del Producto',Nro_Factura as 'Numero de Factura',Cantidad,Detalle_x_Venta.Precio_x_Unidad 'Precio Unitario'  from Detalle_x_Venta inner join Productos on Productos.IdProd = Detalle_x_Venta.IdProd");
			return tabla;
		}

        public DataTable getTablaVentasFiltrada(string Consulta)
        {
            List<Detalle_x_Venta> lista = new List<Detalle_x_Venta>();
            DataTable tabla = ds.ObtenerTabla("Detalle_x_Venta", Consulta);
            return tabla;
        }

        public void ArmarParametrosDetalleVentas(ref SqlCommand Comando, DataTable fila, int i)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@NroFact", SqlDbType.NVarChar, 50);
            SqlParametros.Value = fila.Rows[i]["id factura"];
            // SqlParametros.Value = incrementarfact();
            SqlParametros = Comando.Parameters.Add("@IdProd", SqlDbType.NVarChar, 50);
            SqlParametros.Value = fila.Rows[i]["id producto"];
            SqlParametros = Comando.Parameters.Add("@Cantidad", SqlDbType.Int);
            SqlParametros.Value = fila.Rows[i]["cantidad"];
            SqlParametros = Comando.Parameters.Add("@PrecioXUni", SqlDbType.Money);
            SqlParametros.Value = fila.Rows[i]["precio"];
        }

        public int AgregarDetVen(string consulta)
        {
            AccesoDatos cn = new AccesoDatos();
            SqlConnection conex = new SqlConnection();
            conex = cn.ObtenerConexion();
            SqlCommand comando = new SqlCommand(consulta, conex);
            int filasAfectadas = comando.ExecuteNonQuery();
            return filasAfectadas;
        }
        public bool stockinsua(string prod)
        {
            validacion val = new validacion();
            return (val.stockinsuf("Productos", prod, "Stock"));
        }

        public int stockinsu(string prod)
        { 
         int yourValue = 0;
            string sql = "select stock from productos where idprod='"+prod+"'";
            using (SqlConnection conn = ds.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
               // conn.Open();
                yourValue = Convert.ToInt32(cmd.ExecuteScalar());
                return yourValue;
            }
        }

        public void eliminarcomSQL(string codigo, string idfactcodigo)
        {
            SqlConnection conex = new SqlConnection();
            conex = ds.ObtenerConexion();
            SqlCommand Comando = new SqlCommand();

            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@idpro", SqlDbType.NVarChar, 50);
            SqlParametros.Value = codigo;
            SqlParametros = Comando.Parameters.Add("@idfact", SqlDbType.NVarChar, 50);

            SqlParametros.Value = idfactcodigo;

            Comando.Connection = conex;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "spEliminardetalleVenta";
            Comando.ExecuteNonQuery();

        }

        public int incrementarfact()
        {
            SqlConnection conex = new SqlConnection();
            conex = ds.ObtenerConexion();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conex;
            Comando.CommandText = "SELECT TOP 1 nro_factura FROM ventas ORDER BY Nro_Factura DESC";
            Int32 count = Convert.ToInt32(Comando.ExecuteScalar());
            return count + 1;
        }
        public void InsertarDetalleVentasEnBD(DataTable lista, int row)
        {

            SqlCommand Comando = new SqlCommand();
            ArmarParametrosDetalleVentas(ref Comando, lista, row);
            AccesoDatos ad = new AccesoDatos();
            ad.EjecutarProcedimientoAlmacenado(ref Comando, "cargar_detalle_venta");

        }
    }
}
