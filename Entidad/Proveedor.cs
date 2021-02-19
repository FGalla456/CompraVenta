using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
	public class Proveedor
	{
		private string IdProv;
		private string Nombre; ///Nombre de la Empresa
		private string Telefono;
		private string Direccion;
		private string CUIT;
		private string Ciudad;
		private string Mail_Web;

		public string getIdProv()
		{
			return IdProv;
		}

		public void setIdProv(string idpro)
		{
			IdProv = idpro;
		}

		public string getNombre()
		{
			return Nombre;
		}

		public void setNombre(string nom)
		{
			Nombre = nom;
		}

		public string getTelefono()
		{
			return Telefono;
		}

		public void setTelefono(string tel)
		{
			Telefono = tel;
		}

		public string getDireccion()
		{
			return Direccion;
		}

		public void setDireccion(string dir)
		{
		 	Direccion = dir;
		}

		public string getCUIT()
		{
			return CUIT;
		}

		public void setCUIT(string cuit)
		{
			CUIT = cuit;
		}

		public string getCiudad()
		{
			return Ciudad;
		}

		public void setCiudad(string ciu)
		{
			Ciudad = ciu;
		}

		public string getMail()
		{
			return Mail_Web;
		}

		public void setMail(string MW)
		{
			Mail_Web = MW;
		}

	}
}
