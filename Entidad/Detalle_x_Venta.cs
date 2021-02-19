using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
	public class Detalle_x_Venta
	{
		private string NroFactura;
		private string IdProd;
		private int Cantidad;
		private float PrecioUnitario;
		

		public string getFactura()
		{
			return NroFactura;
		}

		public void setFactura(string fac)
		{
			NroFactura = fac;
		}

		public string getIdProd()
		{
			return IdProd;
		}

		public void setIdProd(string IP)
		{
			IdProd = IP;
		}

		public int getCantidad()
		{
			return Cantidad;
		}

		public void setCantidad(int can)
		{
			Cantidad = can;
		}

		public float getPrecio()
		{
			return PrecioUnitario;
		}

		public void setPrecio(float PU)
		{
			PrecioUnitario = PU;
		}
	}
}
