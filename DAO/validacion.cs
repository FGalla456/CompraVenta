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
    class validacion
    {
        AccesoDatos ds = new AccesoDatos();

        public bool existedato(string nombretabla, string datoabuscar, string nombrecolumna)
        {

            bool var = false;
            string consulta = "SELECT * FROM " + nombretabla;
            SqlConnection sql = ds.ObtenerConexion();
            SqlCommand comando = new SqlCommand(consulta, sql);
            SqlDataReader rd = comando.ExecuteReader();
            while (rd.Read())
            {
                if (rd[nombrecolumna].ToString() == datoabuscar)
                {
                    var = true;
                }
            }
            return var;
        }

        public bool stockinsuf(string nombretabla, string datoabuscar, string nombrecolumna)
        {

            bool var = false;
            string consulta = "SELECT * FROM " + nombretabla;
            SqlConnection sql = ds.ObtenerConexion();
            SqlCommand comando = new SqlCommand(consulta, sql);
            SqlDataReader rd = comando.ExecuteReader();
            int temp;
            while (rd.Read())
            {
                temp = Int32.Parse(rd[nombrecolumna].ToString()) - Int32.Parse(datoabuscar);
                if (temp < 0 )
                {
                    var = true;
                }
            }
            return var;
        }



    }
}
