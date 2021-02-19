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
    public class N_Categoria
    {
		public DataTable getTabla()
		{
			DaoCategoria dao = new DaoCategoria();
			return dao.getTablaCategorias();

        }

        public void datosCat(Categoria cat)
        {
           DaoCategoria Cate = new DaoCategoria();
            Cate.AgregarCat("Categoria",cat);
        }

        public void eliminar(string codigo)
        {
            DaoCategoria pro = new DaoCategoria();
            pro.eliminarcatSQL(codigo);
        }

        public void modificarcate(Categoria cat)
        {
            DaoCategoria Cate = new DaoCategoria();
            Cate.modificar(cat);
        }

        public bool ExisteCat(string idcat)
        {
            DaoCategoria Cate = new DaoCategoria();
            bool categ = Cate.validacionCat(idcat);
            return categ;
        }

    }
}
