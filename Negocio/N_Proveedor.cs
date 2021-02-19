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
	public class N_Proveedor
	{
		public DataTable getTabla()
		{
			DaoProveedor dao = new DaoProveedor();
			return dao.getTablaProveedor();
		}
        public void datosProv(Proveedor prov)
        {
            DaoProveedor pro = new DaoProveedor();
            pro.InsertarProveedorEnBD("proveedores",prov);

        }

		public DataTable Filtrar(string ClausulaSQL)
		{
			string Consulta = "select IdProv as 'ID Proveedor',Nombre , Direccion, CUIT , Mail_o_Web as 'Mail o Web',Telefono from Proveedor " + ClausulaSQL;
			DaoProveedor dao = new DaoProveedor();
			return dao.getTablaProveedorFiltrada(Consulta);
		}

		public void eliminar(string codigo)
        {
            DaoProveedor pro = new DaoProveedor();
            pro.eliminarProvSQL(codigo);
        }

        public DataTable getTablaId(string code)
        {
            DaoProveedor dao = new DaoProveedor();
            return dao.getTablaProveedorID(code);
        }

		public bool ExisteProv(string idprov)
		{
			DaoProveedor Cate = new DaoProveedor();
			bool categ = Cate.validacionProv(idprov);
			return categ;
		}
        public void modificarpro(Entidad.Proveedor cli)
        {
            DaoProveedor prov = new DaoProveedor();
            prov.modificar_prov(cli);
        }
	}
}
