using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
	public class Ventas
	{
		private string NroFactura;
		private string Tipo;
		private float Total;
		private string MetodoPago;
		private string CUIT_Cliente;
		private int Interes;
		private float TotalIVA;
        private string Fecha;
        private string IdEmpleado;

        public string getFecha()
        {
            return Fecha;
        }

        public void setFecha(string fec)
        {
            Fecha = fec;
        }


        public string getFactura()
		{
			return NroFactura;
		}

		public void setFactura(string NF)
		{
			NroFactura = NF;
		}

		public string getTipo()
		{
			return Tipo;
		}

		public void setTipo(string tipo)
		{
			Tipo = tipo;
		}

		public float getTotal()
		{
			return Total;
		}

		public void setTotal(float tot)
		{
			Total = tot;
		}

		public string getMetodo()
		{
			return MetodoPago;
		}

		public void setMetodo(string MP)
		{
			MetodoPago = MP;
		}

		public string getCUIT()
		{
			return CUIT_Cliente;
		}

		public void setCUIT(string CC)
		{
			CUIT_Cliente = CC;
		}

		public int getInteres()
		{
			return Interes;
		}

		public void setInteres(int inter)
		{
			Interes = inter;
		}

		public float getTotIVA()
		{
			return TotalIVA;
		}

		public void setTotIVA(float TIVA)
		{
			TotalIVA = TIVA;
		}

		public string getIdEmpleado()
		{
			return IdEmpleado;
		}

		public void setIdEmpleado(string idem)
		{
			IdEmpleado = idem;
		}
	}
}
