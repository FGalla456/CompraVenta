using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
	public class Clientes
	{
		private string CUIT;
		private string Nombre;
		private string Apellido;
		private string Telefono;
        private string Direccion;
		private string Mail;
		private int ComprasRealizadas;

		public string getCUIT()
		{
			return CUIT;
		}

		public void setCUIT(string cuit)
		{
			CUIT = cuit;
		}

		public string getNombre()
		{
			return Nombre;
		}

		public void setNombre(string nom)
		{
			Nombre = nom;
		}

		public string getApellido()
		{
			return Apellido;
		}

		public void setApellido(string ape)
		{
			Apellido = ape;
		}

		public string getTelefono()
		{
			return Telefono;
		}

		public void setTelefono(string tel)
		{
			Telefono = tel;
		}

		public int getCompras()
		{
			return ComprasRealizadas;
		}

		public void setCompras(int CR)
		{
			ComprasRealizadas = CR;
		}

        public string getMail()
        {
            return Mail;
        }

        public void setMail(string mail)
        {
            Mail = mail;
        }

        public string getDireccion()
        {
            return Direccion;
        }

        public void setDireccion(string dir)
        {
            Direccion = dir;
        }
    }
}
