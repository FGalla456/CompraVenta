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
    public class DaoProductos
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaProductos()
        {
            List<Productos> lista = new List<Productos>();
            DataTable tabla = ds.ObtenerTabla("Productos", "select IdProd as 'Id Producto', Productos.Nombre ,IdCat as 'Id Categoria',Categoria.Nombre as 'Nombre de Categoria' ,Stock ,precio_x_unidad as 'Precio Unitario'  from Productos inner join Categoria on Productos.IdCat = Categoria.IdCategoria");
            return tabla;
        }

        public DataTable getTablaProductosFiltrada(string Consulta)
        {
            List<Productos> lista = new List<Productos>();
            DataTable tabla = ds.ObtenerTabla("Productos", Consulta);
            return tabla;
        }


        public void ArmarParametrosProductos(ref SqlCommand Comando, Productos prod)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@idprod", SqlDbType.NVarChar, 50);
            SqlParametros.Value = prod.getIdProducto();
            SqlParametros = Comando.Parameters.Add("@nombre", SqlDbType.NVarChar, 50);
            SqlParametros.Value = prod.getNombre();
            SqlParametros = Comando.Parameters.Add("@idcat", SqlDbType.NVarChar, 50);
            SqlParametros.Value = prod.getIdCat();
            SqlParametros = Comando.Parameters.Add("@precio", SqlDbType.Float);
            SqlParametros.Value = prod.getPrecio();
            SqlParametros = Comando.Parameters.Add("@stock", SqlDbType.NVarChar, 50);
            SqlParametros.Value = prod.getStock();
        }

        public void ArmarParametrosProductossinstock(ref SqlCommand Comando, prodssotck prod)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@idprod", SqlDbType.NVarChar, 50);
            SqlParametros.Value = prod.getIdProducto();
            SqlParametros = Comando.Parameters.Add("@nombre", SqlDbType.NVarChar, 50);
            SqlParametros.Value = prod.getNombre();
            SqlParametros = Comando.Parameters.Add("@idcat", SqlDbType.NVarChar, 50);
            SqlParametros.Value = prod.getIdCat();
            SqlParametros = Comando.Parameters.Add("@precio", SqlDbType.Float);
            SqlParametros.Value = prod.getPrecio();
        }

        public void InsertarProductosEnBD(String NombreTabla, Productos prod)
        {
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosProductos(ref Comando, prod);
            AccesoDatos ad = new AccesoDatos();
            ad.EjecutarProcedimientoAlmacenado(ref Comando, "cargar_Productos");
        }

        public void eliminarprodSQL(string codigo)
        {
            SqlConnection conex = new SqlConnection();
            conex = ds.ObtenerConexion();
            SqlCommand Comando = new SqlCommand();

            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@idpro", SqlDbType.NVarChar, 50);
            SqlParametros.Value = codigo;

            Comando.Connection = conex;
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "spEliminarProducto";
            Comando.ExecuteNonQuery();

        }

        public string stock()
        {
            DataTable tabla = ds.ObtenerTabla("Productos", "Select Stock from Productos");
            foreach (DataRow fila in tabla.Rows)
            {
                return fila[0].ToString();
            }
            return "Stock Insuficiente";
        }

		public bool validacionProd(string prod)
		{
			validacion val = new validacion();
			return (val.existedato("Productos", prod, "IdProd"));
		}

        public void modificar(prodssotck cli)
        {
            SqlCommand Comando = new SqlCommand();
            SqlParameter SqlParametros = new SqlParameter();
            ArmarParametrosProductossinstock(ref Comando, cli);
            AccesoDatos ad = new AccesoDatos();
            ad.EjecutarProcedimientoAlmacenado(ref Comando, "modificar_Productos");
        }
    }
}
