using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Entidad;
using System.Data;

namespace Negocio
{
	public class N_Empleados
	{
		public DataTable getTabla()
		{
			DaoEmpleados dao = new DaoEmpleados();
			return dao.getTablaEmpleados();
		}

        public void datosEmp(Empleados emp)
        {
            DaoEmpleados Empl = new DaoEmpleados();
            Empl.InsertarEmpleadosEnBD("empleados",emp);
        }
        public void eliminar(string codigo)
        {
            DaoEmpleados pro = new DaoEmpleados();
            pro.eliminarempSQL(codigo);
        }

		public DataTable Filtrar(string ClausulaSQL)
		{
			string Consulta = "Select * from Empleados " + ClausulaSQL;
			DaoEmpleados dao = new DaoEmpleados();
			return dao.getTablaEmpleadosFiltrada(Consulta);
		}

        public DataTable Reportestabla(string ClausulaSQL)
        {
            string Consulta =  ClausulaSQL;
            DaoEmpleados dao = new DaoEmpleados();
            return dao.getTablaEmpleadosFiltrada(Consulta);
        }

        public bool ExisteEmp(string idem)
		{
			DaoEmpleados Cate = new DaoEmpleados();
			bool categ = Cate.validacionEmpleados(idem);
			return categ;
		}

        public void modificaremp(Empleados cat)
        {
            DaoEmpleados Cate = new DaoEmpleados();
            Cate.modificar(cat);
        }
    }
}
