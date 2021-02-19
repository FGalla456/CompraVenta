using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
	public class Empleados
	{
		private string IdEmpleado;
		private string Nombre;
		private string Apellido;
		private string Telefono;
		private string Direccion;
		private string Mail;
		private float Sueldo;

		public string getIdEmpleado()
		{
			return IdEmpleado;
		}

		public void setIdEmpleado(string IE)
		{
			IdEmpleado = IE;
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

		public string getDireccion()
		{
			return Direccion;
		}

		public void setDireccion(string Dir)
		{
			Direccion = Dir;
		}

		public string getMail()
		{
			return Mail;
		}

		public void setMail(string mail)
		{
			Mail = mail;
		}

		public float getSueldo()
		{
			return Sueldo;
		}

		public void setSueldo(float suel)
		{
			Sueldo = suel;
		}
	}
}
