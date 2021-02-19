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
    public class N_Compras
    {
        public DataTable getTabla()
        {
            DaoCompras dao = new DaoCompras();
            return dao.getTablaCompras();
        }

        public void datosCom(Compras com)
        {
            DaoCompras Vent = new DaoCompras();
            Vent.InsertarComprasEnBD("Compras", com);
        }

        public DataTable Filtrar(string ClausulaSQL)
        {
            string Consulta = "select Nro_Factura as 'Numero de Factura',Tipo as 'Tipo de Factura',Total,IdProveedor as 'Id Proveedor',Proveedor.Nombre as 'Nombre del Proveedor',Interes as 'Intereses / Descuentos', Total_IVA as 'Total Con Iva y Descuento/Interes',Medio_Pago as 'Medio de Pago',fecha from Compras inner join Proveedor on Compras.IdProveedor = Proveedor.IdProv " + ClausulaSQL;
            DaoCompras dao = new DaoCompras();
            return dao.getTablaComprasFiltrada(Consulta);
        }

        public void eliminar(string codigo)
        {
            DaoCompras pro = new DaoCompras();
            pro.eliminarcomSQL(codigo);
        }

        public bool ExisteCom(string fac)
        {
            DaoCompras Cate = new DaoCompras();
            bool categ = Cate.validacionCompras(fac);
            return categ;
        }
        public int incremetarfact()
        {
            DaoDetalleCompra det = new DaoDetalleCompra();
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
