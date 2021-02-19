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
    public class DaoClientes
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaClientes()
        {
            List<Clientes> lista = new List<Clientes>();
            DataTable tabla = ds.ObtenerTabla("Clientes", "select CUIT , Nombre, Apellido, Telefono, Mail, Compras_Realizadas as 'Compras Realizadas ',direccion as 'Direccion' from Clientes");
            return tabla;
        }

        public DataTable getTablaClientesFiltrada(string Consulta)
        {
            List<Clientes> lista = new List<Clientes>();
            DataTable tabla = ds.ObtenerTabla("Clientes", Consulta);
            return tabla;
        }

        public void ArmarParametrosClientes(ref SqlCommand Comando, Clientes cli)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@cuit", SqlDbType.NVarChar, 50);
            SqlParametros.Value = cli.getCUIT();
            SqlParametros = Comando.Parameters.Add("@nombre", SqlDbType.NVarChar, 50);
            SqlParametros.Value = cli.getNombre();
            SqlParametros = Comando.Parameters.Add("@apellido", SqlDbType.NVarChar, 50);
            SqlParametros.Value = cli.getApellido();
            SqlParametros = Comando.Parameters.Add("@telefono", SqlDbType.NVarChar, 50);
            SqlParametros.Value = cli.getTelefono();
            SqlParametros = Comando.Parameters.Add("@mail", SqlDbType.NVarChar, 50);
            SqlParametros.Value = cli.getMail();
            SqlParametros = Comando.Parameters.Add("@compras", SqlDbType.Int);
            SqlParametros.Value = cli.getCompras();
            SqlParametros = Comando.Parameters.Add("@direccion", SqlDbType.NVarChar , 50);
            SqlParametros.Value = cli.getDireccion();
        }

        public void InsertarClientesEnBD(String NombreTabla, Clientes cli)
        {
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosClientes(ref Comando, cli);
            AccesoDatos ad = new AccesoDatos();
            ad.EjecutarProcedimientoAlmacenado(ref Comando, "cargar_clientes");
        }


        public void eliminarcliSQL(string codigo)
        {
            SqlConnection conex = new SqlConnection();
            conex = ds.ObtenerConexion();
            SqlCommand Comando = new SqlCommand();

            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@idpro", SqlDbType.NVarChar, 50);
            SqlParametros.Value = codigo;

            Comando.Connection = conex;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "spEliminarCliente";
            Comando.ExecuteNonQuery();

        }

		public bool validacionClientes(string CUIT)
		{
			validacion val = new validacion();
			return (val.existedato("Clientes", CUIT, "CUIT"));
		}

        public void modificar(Clientes cli)
        {
            SqlCommand Comando = new SqlCommand();
            SqlParameter SqlParametros = new SqlParameter();
            ArmarParametrosClientes(ref Comando, cli);
            AccesoDatos ad = new AccesoDatos();
            ad.EjecutarProcedimientoAlmacenado(ref Comando, "modificar_Clientes");
        }
    }
}

