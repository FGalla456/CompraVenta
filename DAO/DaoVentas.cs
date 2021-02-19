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
    public class DaoVentas
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaVentas()
        {
            List<Ventas> lista = new List<Ventas>();
            DataTable tabla = ds.ObtenerTabla("Ventas", "select Nro_Factura as 'Numero de Factura',Tipo as 'Tipo de Factura',Total, Metodo_Pago as 'Medio de Pago',CUIT_Cliente as 'CUIT Cliente', Clientes.Nombre as 'Nombre del Cliente', Clientes.Apellido as 'Apellido Del Cliente', Interes as 'Intereses / Descuentos',Total_IVA as 'Total Con Iva y Descuento/Interes', ventas.IdEmpleado as 'Id Empleado', Empleados.Nombre as 'Nombre del Empleado',Empleados.Apellido as 'Apellido del Empleado', fecha as 'Fecha' from Ventas inner join Empleados on Empleados.IdEmpleado = Ventas.IdEmpleado inner join Clientes on Clientes.CUIT = Ventas.CUIT_Cliente");
            return tabla;
        }

        public DataTable getTablaVentasFiltrada(string Consulta)
        {
            List<Ventas> lista = new List<Ventas>();
            DataTable tabla = ds.ObtenerTabla("Ventas", Consulta);
            return tabla;
        }

        public void ArmarParametrosVentas(ref SqlCommand Comando, Ventas ven)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@nrofact", SqlDbType.NVarChar, 50);
            SqlParametros.Value = ven.getFactura();
            SqlParametros = Comando.Parameters.Add("@tipo", SqlDbType.NVarChar, 50);
            SqlParametros.Value = ven.getTipo();
            SqlParametros = Comando.Parameters.Add("@total", SqlDbType.Money);
            SqlParametros.Value = ven.getTotal();
            SqlParametros = Comando.Parameters.Add("@medio_pago", SqlDbType.NVarChar, 50);
            SqlParametros.Value = ven.getMetodo();
            SqlParametros = Comando.Parameters.Add("@cuit", SqlDbType.NVarChar, 50);
            SqlParametros.Value = ven.getCUIT();
            SqlParametros = Comando.Parameters.Add("@interes", SqlDbType.Int);
            SqlParametros.Value = ven.getInteres();
            SqlParametros = Comando.Parameters.Add("@totaliva", SqlDbType.Money);
            SqlParametros.Value = ven.getTotIVA();
            SqlParametros = Comando.Parameters.Add("@idemp", SqlDbType.NVarChar, 50);
            SqlParametros.Value = ven.getIdEmpleado();
            SqlParametros = Comando.Parameters.Add("@fecha", SqlDbType.SmallDateTime);
            SqlParametros.Value = ven.getFecha();
        }

        public void InsertarVentasEnBD(String NombreTabla, Ventas Ven)
        {

            SqlCommand Comando = new SqlCommand();
            ArmarParametrosVentas(ref Comando, Ven);
            AccesoDatos ad = new AccesoDatos();
            ad.EjecutarProcedimientoAlmacenado(ref Comando, "cargar_ventas");

        }

        public void eliminarvenSQL(string codigo)
        {
            SqlConnection conex = new SqlConnection();
            conex = ds.ObtenerConexion();
            SqlCommand Comando = new SqlCommand();

            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@idpro", SqlDbType.NVarChar, 50);
            SqlParametros.Value = codigo;

            Comando.Connection = conex;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "spEliminarVentas";
            Comando.ExecuteNonQuery();

        }

		public bool validacionVentas(string nfac)
		{
			validacion val = new validacion();
			return (val.existedato("Ventas", nfac, "Nro_Factura"));
		}
	}
}
