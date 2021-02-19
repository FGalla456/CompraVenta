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
    public class DaoDetalleCompra
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaDetalleCompra()
        {
            List<Detalle_x_Compra> lista = new List<Detalle_x_Compra>();
            DataTable tabla = ds.ObtenerTabla("DetalleCompra", "select Detalle_x_Compra.IdProd as 'Id Producto',Nombre,Nro_Factura as 'Numero de Factura',Cantidad,Detalle_x_Compra.Precio_x_Unidad 'Precio Unitario'  from Detalle_x_Compra inner join Productos on Productos.IdProd = Detalle_x_Compra.IdProd");
            return tabla;
        }
        public DataTable getTablaVentasFiltrada(string Consulta)
        {
            List<Detalle_x_Compra> lista = new List<Detalle_x_Compra>();
            DataTable tabla = ds.ObtenerTabla("Detalle_x_Compra", Consulta);
            return tabla;
        }

        public void ArmarParametrosDetalleCompras(ref SqlCommand Comando, DataTable fila, int i)
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

        public void InsertarDetalleComprasEnBD(DataTable lista, int row)
        {

            SqlCommand Comando = new SqlCommand();
            ArmarParametrosDetalleCompras(ref Comando, lista, row);
            AccesoDatos ad = new AccesoDatos();
            ad.EjecutarProcedimientoAlmacenado(ref Comando, "cargar_detalle_compra");

        }


        public int AgregarDetCom(string consulta)
        {
            AccesoDatos cn = new AccesoDatos();
            SqlConnection conex = new SqlConnection();
            conex = cn.ObtenerConexion();
            SqlCommand comando = new SqlCommand(consulta, conex);
            int filasAfectadas = comando.ExecuteNonQuery();
            return filasAfectadas;
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
            Comando.CommandText = "spEliminardetalleCompra";
            Comando.ExecuteNonQuery();

        }

        public int incrementarfact()
        {
            SqlConnection conex = new SqlConnection();
            conex = ds.ObtenerConexion();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conex;
            Comando.CommandText = "SELECT TOP 1 nro_factura FROM Compras ORDER BY Nro_Factura DESC";
            Int32 count = Convert.ToInt32(Comando.ExecuteScalar());
            return count + 1;
        }
    }

}
