using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Compras
    {
        private String NroFactura;
        private string Tipo; ///Tipo de Factura (A,B o C)
		private float Total;
        private string MetodoPago; ///Forma de Pago (Efectivo,Credito,etc)
		private string IdProveedor;
        private int Interes; ///Positivo si es interes, negativo si es descuento
		private float TotalIVA; /// Total + Descuento/Interes + IVA
        private string Fecha;

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

        public string getIdProveedor()
        {
            return IdProveedor;
        }

        public void setIdProveedor(string idpro)
        {
            IdProveedor = idpro;
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
    }
}
