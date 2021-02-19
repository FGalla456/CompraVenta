using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class prodssotck
    {
            private string IdProducto;
            private string Nombre;
            private string IdCat;
            private float PrecioUnitario;
            private string IdProv;

            public string getIdProducto()
            {
                return IdProducto;
            }

            public void setIdProducto(string prod)
            {
                IdProducto = prod;
            }

            public string getNombre()
            {
                return Nombre;
            }

            public void setNombre(string nom)
            {
                Nombre = nom;
            }

            public string getIdCat()
            {
                return IdCat;
            }

            public void setIdCat(string cat)
            {
                IdCat = cat;
            }

            public float getPrecio()
            {
                return PrecioUnitario;
            }

            public void setPrecio(float PU)
            {
                PrecioUnitario = PU;
            }

            public string getIdProv()
            {
                return IdProv;
            }

            public void setIdProv(string IP)
            {
                IdProv = IP;
            }
        
    }
}
