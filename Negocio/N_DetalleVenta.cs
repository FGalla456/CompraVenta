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
    public class N_DetalleVenta
    {
        public DataTable getTabla()
        {
            DaoDetalleVenta dao = new DaoDetalleVenta();
            return dao.getTablaDetalleVenta();
        }
        public void datosDT(Detalle_x_Venta dt)
        {
            DaoDetalleVenta DT = new DaoDetalleVenta();
           // DT.InsertarDetalleVentasEnBD(dt);
        }
        public int stockinsu(string cant)
        {
            DaoDetalleVenta Cate = new DaoDetalleVenta();
            int stock = Cate.stockinsu(cant);
            return stock;
        }

        public void eliminar(string codigo, string idfactcodigo)
        {
            DaoDetalleVenta pro = new DaoDetalleVenta();
            pro.eliminarcomSQL(codigo, idfactcodigo);
        }

        public DataTable Filtrar(string Consulta)
        {
            DaoDetalleVenta dao = new DaoDetalleVenta();
            return dao.getTablaVentasFiltrada(Consulta);
        }
        public int incremetarfact()
        {
            DaoDetalleVenta det = new DaoDetalleVenta();
            int pep = det.incrementarfact();
            return pep;
        }
        public void datosDC(DataTable lista)
        {
            DaoDetalleVenta DC = new DaoDetalleVenta();
            for (int i = 0; i < lista.Rows.Count; i++)
            {
                DC.InsertarDetalleVentasEnBD(lista, i);
            }
        }

    }
}
