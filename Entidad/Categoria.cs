using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
	public class Categoria
	{
		private string IdCategoria;
		private string Nombre;
		private string Detalle;

		public string getIdCategoria()
		{
			return IdCategoria;
		}

		public void setIdCategoria(string idcat)
		{
			IdCategoria = idcat;
		}

		public string getNombre()
		{
			return Nombre;
		}

		public void setNombre(string nom)
		{
			Nombre = nom;
		}

		public string getDetalle()
		{
			return Detalle;
		}

		public void setDetalle(string deta)
		{
			Detalle = deta;
		}

	}
}
