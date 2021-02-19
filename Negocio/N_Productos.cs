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
    public class N_Productos
    {
        public DataTable getTabla()
        {
            DaoProductos dao = new DaoProductos();
            return dao.getTablaProductos();
        }

        public void datosProd(Productos prod)
        {
            DaoProductos pro = new DaoProductos();
            pro.InsertarProductosEnBD("productos", prod);

        }
        public void eliminar(string codigo)
        {
            DaoProductos pro = new DaoProductos();
            pro.eliminarprodSQL(codigo);
        }

		public DataTable Filtrar(string ClausulaSQL)
		{
			string Consulta = "select IdProd as 'Id Producto', Productos.Nombre ,IdCat as 'Id Categoria',Categoria.Nombre as 'Nombre de Categoria' ,Stock ,precio_x_unidad as 'Precio Unitario'  from Productos inner join Categoria on Productos.IdCat = Categoria.IdCategoria " + ClausulaSQL;
			DaoProductos dao = new DaoProductos();
			return dao.getTablaProductosFiltrada(Consulta);
		}

		public bool ExisteProd(string idprod)
        {
            DaoProductos Cate = new DaoProductos();
            bool categ = Cate.validacionProd(idprod);
            return categ;
        }
    
         public void modificarprod(prodssotck cat)
         {
                 DaoProductos Cate = new DaoProductos();
                 Cate.modificar(cat);
         }

        public DataTable Reportestabla(string ClausulaSQL)
        {
            string Consulta = ClausulaSQL;
            DaoEmpleados dao = new DaoEmpleados();
            return dao.getTablaEmpleadosFiltrada(Consulta);
        }

    }
}
