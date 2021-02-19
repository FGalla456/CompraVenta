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
    public class DaoCompras
    {
        AccesoDatos ds = new AccesoDatos();
        DaoDetalleCompra dc = new DaoDetalleCompra();

        public DataTable getTablaCompras()
        {
            List<Compras> lista = new List<Compras>();
            DataTable tabla = ds.ObtenerTabla("Compras", "select Nro_Factura as 'Numero de Factura',Tipo as 'Tipo de Factura',Total,IdProveedor as 'Id Proveedor',Proveedor.Nombre as 'Nombre del Proveedor',Interes as 'Intereses / Descuentos', Total_IVA as 'Total Con Iva y Descuento/Interes',Medio_Pago as 'Medio de Pago',fecha as 'Fecha' from Compras inner join Proveedor on Compras.IdProveedor = Proveedor.IdProv");
            return tabla;
        }

        public DataTable getTablaComprasFiltrada(string Consulta)
        {
            List<Compras> lista = new List<Compras>();
            DataTable tabla = ds.ObtenerTabla("Compras", Consulta);
            return tabla;
        }

        public void ArmarParametrosCompras(ref SqlCommand Comando, Compras Com)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@NroFact", SqlDbType.NVarChar, 50);
            SqlParametros.Value = Com.getFactura();
            //SqlParametros.Value = incrementarfact();
            SqlParametros = Comando.Parameters.Add("@Tipo", SqlDbType.NVarChar, 50);
            SqlParametros.Value = Com.getTipo();
            SqlParametros = Comando.Parameters.Add("@Total", SqlDbType.Money);
            SqlParametros.Value = Com.getTotal();
            SqlParametros = Comando.Parameters.Add("@Medio_Pago", SqlDbType.NVarChar, 50);
            SqlParametros.Value = Com.getMetodo();
            SqlParametros = Comando.Parameters.Add("@IdProv", SqlDbType.NVarChar, 50);
            SqlParametros.Value = Com.getIdProveedor();
            SqlParametros = Comando.Parameters.Add("@Interes", SqlDbType.Int);
            SqlParametros.Value = Com.getInteres();
            SqlParametros = Comando.Parameters.Add("@Totaliva", SqlDbType.Money);
            SqlParametros.Value = Com.getTotIVA();
            SqlParametros = Comando.Parameters.Add("@fecha", SqlDbType.SmallDateTime);
            SqlParametros.Value = Com.getFecha();

        }

        public void InsertarComprasEnBD(String NombreTabla, Compras com)
        {

            SqlCommand Comando = new SqlCommand();
            ArmarParametrosCompras(ref Comando, com);
            AccesoDatos ad = new AccesoDatos();
            ad.EjecutarProcedimientoAlmacenado(ref Comando, "cargar_compras");

        }

        public void eliminarcomSQL(string codigo)
        {
            SqlConnection conex = new SqlConnection();
            conex = ds.ObtenerConexion();
            SqlCommand Comando = new SqlCommand();

            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@idpro", SqlDbType.NVarChar, 50);
            SqlParametros.Value = codigo;

            Comando.Connection = conex;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "spEliminarCompras";
            Comando.ExecuteNonQuery();

        }

        public bool validacionCompras(string nfac)
        {
            validacion val = new validacion();
            return (val.existedato("Compras", nfac, "Nro_Factura"));
        }
        public int incrementarfact()
        {
            SqlConnection conex = new SqlConnection();
            conex = ds.ObtenerConexion();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conex;
            Comando.CommandText = "SELECT COUNT(*) FROM Compras";
            Int32 count = (Int32)Comando.ExecuteScalar();
            return count + 1;
        }
    }
}
