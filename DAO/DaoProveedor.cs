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
    public class DaoProveedor
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaProveedor()
        {
            List<Proveedor> lista = new List<Proveedor>();
            DataTable tabla = ds.ObtenerTabla("Proveedor", "select IdProv as 'ID Proveedor',Nombre , Direccion, CUIT , Mail_o_Web as 'Mail o Web',Telefono from Proveedor");
            return tabla;
        }

        public DataTable getTablaProveedorFiltrada(string Consulta)
        {
            List<Proveedor> lista = new List<Proveedor>();
            DataTable tabla = ds.ObtenerTabla("Proveedor", Consulta);
            return tabla;
        }

	    public void ArmarParametrosProveedores(ref SqlCommand Comando, Proveedor prov)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@idProv", SqlDbType.NVarChar, 50);
            SqlParametros.Value = prov.getIdProv();
            SqlParametros = Comando.Parameters.Add("@nombre", SqlDbType.NVarChar, 50);
            SqlParametros.Value = prov.getNombre();
            SqlParametros = Comando.Parameters.Add("@telefono", SqlDbType.NVarChar, 50);
            SqlParametros.Value = prov.getTelefono();
            SqlParametros = Comando.Parameters.Add("@direccion", SqlDbType.NVarChar, 50);
            SqlParametros.Value = prov.getDireccion();
            SqlParametros = Comando.Parameters.Add("@cuit", SqlDbType.NVarChar, 50);
            SqlParametros.Value = prov.getCUIT();
           // SqlParametros = Comando.Parameters.Add("@ciudad", SqlDbType.NVarChar, 50);
            //SqlParametros.Value = prov.getCUIT();
            SqlParametros = Comando.Parameters.Add("@mail", SqlDbType.NVarChar, 50);
            SqlParametros.Value = prov.getMail();
        }

        public void InsertarProveedorEnBD(String NombreTabla, Proveedor prov)
        {
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosProveedores(ref Comando, prov);
            AccesoDatos ad = new AccesoDatos();
            ad.EjecutarProcedimientoAlmacenado(ref Comando, "cargar_proveedor");

        }

        public void eliminarProvSQL(string codigo)
        {
            SqlConnection conex = new SqlConnection();
            conex = ds.ObtenerConexion();
            SqlCommand Comando = new SqlCommand();

            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@idpro", SqlDbType.NVarChar, 50);
            SqlParametros.Value = codigo;

            Comando.Connection = conex;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "spEliminarProveedor";
            Comando.ExecuteNonQuery();

        }
        public void modificar_prov(Entidad.Proveedor cli)
        {
            SqlCommand Comando = new SqlCommand();
            SqlParameter SqlParametros = new SqlParameter();
            ArmarParametrosProveedores(ref Comando, cli);
            AccesoDatos ad = new AccesoDatos();
            ad.EjecutarProcedimientoAlmacenado(ref Comando, "modificar_Proveedor");
        }
        public DataTable getTablaProveedorID(string code)
        {
            List<Proveedor> lista = new List<Proveedor>();
            DataTable tabla = ds.ObtenerTabla("Proveedor", "Select * from Proveedor where IdProv = " + code);
            return tabla;
        }

        public bool verficarFactProvBD(string codpro)
        {
            AccesoDatos ac = new AccesoDatos();
            SqlCommand checkFac = new SqlCommand("select * from Proveedor where IdProv =" + codpro, ac.ObtenerConexion());
            SqlDataReader reader = checkFac.ExecuteReader();
            if (reader.HasRows)
            {
                //ader.Close();

                return true;
            }
            else { return false; }
        }

		public bool validacionProv(string prov)
		{
			validacion val = new validacion();
			return (val.existedato("Proveedor", prov, "IdProv"));
		}
	}
}
