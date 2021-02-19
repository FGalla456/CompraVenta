using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class AccesoDatos
    {
		String rutaBDFinal =
	  "Data Source=localhost\\sqlexpress;Initial Catalog=TP_Final;Integrated Security=True";

		public SqlConnection ObtenerConexion()
		{
			SqlConnection cn = new SqlConnection(rutaBDFinal);
			try
			{
				cn.Open();
				return cn;
			}
			catch (Exception ex)
			{
				return null;
			}
		}

		private SqlDataAdapter ObtenerAdaptador(String consultaSql, SqlConnection cn)
		{
			SqlDataAdapter adaptador;
			try
			{
				adaptador = new SqlDataAdapter(consultaSql, cn);
				return adaptador;
			}
			catch (Exception ex)
			{
				return null;
			}
		}

		public DataTable ObtenerTabla(String NombreTabla, String Sql)
		{
			DataSet ds = new DataSet();
			SqlConnection Conexion = ObtenerConexion();
			SqlDataAdapter adp = ObtenerAdaptador(Sql, Conexion);
			adp.Fill(ds, NombreTabla);
			Conexion.Close();
			return ds.Tables[NombreTabla];
		}

		public void EjecutarProcedimientoAlmacenado(ref SqlCommand Comando, String NombreSP)
		{
		
			SqlConnection Conexion = ObtenerConexion();
			//SqlCommand cmd = new SqlCommand();
			//cmd = Comando;
			Comando.Connection = Conexion;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = NombreSP;
            Comando.ExecuteNonQuery();
			Conexion.Close();
			//return FilasCambiadas;
		}

	}
}
