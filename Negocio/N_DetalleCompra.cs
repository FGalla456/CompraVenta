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
    public class N_DetalleCompra
    {
        //  List<Detalle_x_Compra> lista = new List<Detalle_x_Compra>();
        public DataTable getTabla()
        {
            DaoDetalleCompra dao = new DaoDetalleCompra();
            return dao.getTablaDetalleCompra();
        }

        public void eliminar(string codigo, string idfactcodigo)
        {
            DaoDetalleCompra pro = new DaoDetalleCompra();
            pro.eliminarcomSQL(codigo, idfactcodigo);
        }

        public DataTable Filtrar(string Consulta)
        {
            DaoDetalleCompra dao = new DaoDetalleCompra();
            return dao.getTablaVentasFiltrada(Consulta);
        }

        public void datosDC(DataTable lista)
        {
            DaoDetalleCompra DC = new DaoDetalleCompra();
            for (int i = 0; i < lista.Rows.Count; i++)
            {
                DC.InsertarDetalleComprasEnBD(lista, i);
            }
        }

        public int incremetarfact()
        {
            DaoDetalleCompra det = new DaoDetalleCompra();
            int pep = det.incrementarfact();
            return pep;
        }

    }
}
