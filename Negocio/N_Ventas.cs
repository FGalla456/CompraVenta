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
	public class N_Ventas
	{
		public DataTable getTabla()
		{
			DaoVentas dao = new DaoVentas();
			return dao.getTablaVentas();
		}

        public void datosVent(Ventas ven)
        {
            DaoVentas Vent = new DaoVentas();
            Vent.InsertarVentasEnBD("ventas",ven);
           // return filasafec;
        }
        public void eliminar(string codigo)
        {
            DaoVentas pro = new DaoVentas();
            pro.eliminarvenSQL(codigo);
        }

		public DataTable Filtrar(string ClausulaSQL)
		{
			string Consulta = "select Nro_Factura as 'Numero de Factura',Tipo as 'Tipo de Factura',Total, Metodo_Pago as 'Metodo de pago',CUIT_Cliente as 'CUIT Cliente', Clientes.Nombre as 'Nombre del Cliente', Clientes.Apellido as 'Apellido del Cliente', Interes as 'Intereses / Descuentos',Total_IVA as 'Total Con Iva y Descuento/Interes', ventas.IdEmpleado as 'Id Empleado', Empleados.Nombre as 'Nombre del Empleado',Empleados.Apellido as 'Apellido del Empleado', fecha from Ventas inner join Empleados on Empleados.IdEmpleado = Ventas.IdEmpleado inner join Clientes on Clientes.CUIT = Ventas.CUIT_Cliente " + ClausulaSQL;
			DaoVentas dao = new DaoVentas();
			return dao.getTablaVentasFiltrada(Consulta);
		}

		public bool ExisteVen(string fact)
		{
			DaoVentas Cate = new DaoVentas();
			bool categ = Cate.validacionVentas(fact);
			return categ;
		}
        public int incremetarfact()
        {
            DaoDetalleVenta det = new DaoDetalleVenta();
            int pep = det.incrementarfact();
            return pep;
        }
        public DataTable Reportestabla(string ClausulaSQL)
        {
            string Consulta = ClausulaSQL;
            DaoEmpleados dao = new DaoEmpleados();
            return dao.getTablaEmpleadosFiltrada(Consulta);
        }
    }
}
