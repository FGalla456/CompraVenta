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
	public class DaoCategoria
		{
		AccesoDatos ds = new AccesoDatos();

		public DataTable getTablaCategorias()
		{
			List<Categoria> lista = new List<Categoria>();
			DataTable tabla = ds.ObtenerTabla("Categoria", "Select * from Categoria");
			return tabla;
		}

        public void ArmarParametrosCategorias(ref SqlCommand  Comando, Entidad.Categoria cat)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IdCat", SqlDbType.NVarChar, 50);
            SqlParametros.Value = cat.getIdCategoria();
            SqlParametros = Comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50);
            SqlParametros.Value = cat.getNombre();
            SqlParametros = Comando.Parameters.Add("@Detalle", SqlDbType.NVarChar, 50);
            SqlParametros.Value =cat.getDetalle();
        }

        public void AgregarCat(String NombreTabla,Categoria cat)
        {

                SqlCommand Comando = new SqlCommand();
                SqlParameter SqlParametros = new SqlParameter();
                ArmarParametrosCategorias(ref Comando,cat);
                AccesoDatos ad = new AccesoDatos();
                ad.EjecutarProcedimientoAlmacenado(ref Comando, "cargar_categoria");
        }

        public void eliminarcatSQL(string codigo)
        {
            SqlConnection conex = new SqlConnection();
            conex = ds.ObtenerConexion();
            SqlCommand Comando = new SqlCommand();

            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@idpro", SqlDbType.NVarChar, 50);
            SqlParametros.Value = codigo;

            Comando.Connection = conex;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "spEliminarCategoria";
            Comando.ExecuteNonQuery();

        }
        public void modificar( Categoria cat)
        {
            SqlCommand Comando = new SqlCommand();
            SqlParameter SqlParametros = new SqlParameter();
            ArmarParametrosCategorias(ref Comando, cat);
            AccesoDatos ad = new AccesoDatos();
            ad.EjecutarProcedimientoAlmacenado(ref Comando, "modificar_Categoria");
        }

        public bool validacionCat(string idcat)
        {
            validacion val = new validacion();
            return (val.existedato("categoria",idcat,"idcategoria"));
        }

    }
}