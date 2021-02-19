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
    public class DaoEmpleados
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaEmpleados()
        {
            List<Empleados> lista = new List<Empleados>();
            DataTable tabla = ds.ObtenerTabla("Empleados", "Select * from Empleados");
            return tabla;
        }

		public DataTable getTablaEmpleadosFiltrada(string Consulta)
		{
			List<Empleados> lista = new List<Empleados>();
			DataTable tabla = ds.ObtenerTabla("Empleados", Consulta);
			return tabla;
		}

		public void ArmarParametrosEmpleados(ref SqlCommand Comando, Empleados emp)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@idemp", SqlDbType.NVarChar, 50);
            SqlParametros.Value = emp.getIdEmpleado();
            SqlParametros = Comando.Parameters.Add("@nombre", SqlDbType.NVarChar, 50);
            SqlParametros.Value = emp.getNombre();
            SqlParametros = Comando.Parameters.Add("@apellido", SqlDbType.NVarChar, 50);
            SqlParametros.Value = emp.getApellido();
            SqlParametros = Comando.Parameters.Add("@telefono", SqlDbType.NVarChar, 50);
            SqlParametros.Value = emp.getTelefono();
            SqlParametros = Comando.Parameters.Add("@direccion", SqlDbType.NVarChar, 50);
            SqlParametros.Value = emp.getDireccion();
            SqlParametros = Comando.Parameters.Add("@mail", SqlDbType.NVarChar, 50);
            SqlParametros.Value = emp.getMail();
            SqlParametros = Comando.Parameters.Add("@sueldo", SqlDbType.Money);
            SqlParametros.Value = emp.getSueldo();
        }

        public void InsertarEmpleadosEnBD(String NombreTabla, Empleados emp)
        {
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosEmpleados(ref Comando, emp);
            AccesoDatos ad = new AccesoDatos();
            ad.EjecutarProcedimientoAlmacenado(ref Comando, "cargar_empleados");

        }

        public void eliminarempSQL(string codigo)
        {
            SqlConnection conex = new SqlConnection();
            conex = ds.ObtenerConexion();
            SqlCommand Comando = new SqlCommand();

            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@idpro", SqlDbType.NVarChar, 50);
            SqlParametros.Value = codigo;

            Comando.Connection = conex;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "spEliminarEmpleado";
            Comando.ExecuteNonQuery();

        }

        public void modificar(Empleados cat)
        {
            SqlCommand Comando = new SqlCommand();
            SqlParameter SqlParametros = new SqlParameter();
            ArmarParametrosEmpleados(ref Comando, cat);
            AccesoDatos ad = new AccesoDatos();
            ad.EjecutarProcedimientoAlmacenado(ref Comando, "modificar_Empleados");
        }


        public bool validacionEmpleados(string idem)
		{
			validacion val = new validacion();
			return (val.existedato("Empleados", idem, "IdEmpleado"));
		}
	}
}
