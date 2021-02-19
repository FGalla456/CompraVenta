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
    public class N_Clientes
    {
        public DataTable getTabla()
        {
            DaoClientes dao = new DaoClientes();
            return dao.getTablaClientes();
        }

        public void datosCli(Clientes Cli)
        {
            DaoClientes clien = new DaoClientes();
            clien.InsertarClientesEnBD("Clientes", Cli);

        }
        public void eliminar(string codigo)
        {
            DaoClientes pro = new DaoClientes();
            pro.eliminarcliSQL(codigo);
        }

		public DataTable Filtrar(string ClausulaSQL)
		{
			string Consulta = "select CUIT , Nombre, Apellido, Telefono, Mail, Compras_Realizadas as 'Compras Realizadas ',direccion as 'Direccion' from Clientes " + ClausulaSQL;
			DaoClientes dao = new DaoClientes();
			return dao.getTablaClientesFiltrada(Consulta);
		}

		public bool ExisteCli(string cuit)
        {
            DaoClientes Cate = new DaoClientes();
            bool categ = Cate.validacionClientes(cuit);
            return categ;
        }

        public void modificarcliente(Clientes cli)
        {
            DaoClientes clie = new DaoClientes();
            clie.modificar(cli);

        }
    }
}
