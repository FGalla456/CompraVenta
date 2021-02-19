using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidad;

namespace WindowsFormsApp1
{
    public partial class EliminarDetalleVenta : Form
    {
        public string celdafact;
        public string celdaprod;
        public DataTable dat;
        public EliminarDetalleVenta()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string cod;
            cod = txtIDPROV.Text.ToString();
            N_DetalleVenta pro = new N_DetalleVenta();
            //try { pro.eliminar(cod, txtfac.Text.ToString()); }
            //catch (Exception) { MessageBox.Show("No se puede eliminar"); return; }
            pro.eliminar(cod, txtfac.Text.ToString());
            MessageBox.Show("Se elimino correctamente");
            this.Close();
        }

        private void btnfac_Click(object sender, EventArgs e)
        {
            TDV td = new TDV();
            ListaVen listcom = new ListaVen();
            listcom.ShowDialog();
            txtfac.Text = listcom.celda;
            //DataGridViewRow row = Grilla.CurrentRow;
            //string Celda;
            //celdaprod = Convert.ToString(row.Cells["Nro_Factura"].Value);
            string Consulta;
            Consulta = "select IdProd as 'Id Producto',Nro_Factura as 'Numero factura',Cantidad,Precio_x_Unidad 'Precio x unidad'  from Detalle_x_Venta WHERE Nro_Factura = '" + txtfac.Text.ToString() + "'";
            TDV tda = new TDV();
            tda.prueba = 1;
            tda.RecibeNFac(Consulta);
            tda.ShowDialog();
            txtIDPROV.Text = tda.celda;
            tda.Close();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            string cod;
            string cantidad;
            N_Ventas com = new N_Ventas();

            N_DetalleVenta pro = new N_DetalleVenta();
            pro.eliminar(txtIDPROV.Text.ToString(), txtfac.Text.ToString());
            //try { pro.eliminar(cod, txtfac.Text.ToString()); }
            //catch (Exception) { MessageBox.Show("No se puede eliminar"); return; }
            string Consulta = "Select * from Detalle_x_Venta WHERE Nro_Factura = '" + txtfac.Text.ToString() + "'";
            dat = pro.Filtrar(Consulta);
            MessageBox.Show("Se elimino correctamente");
            cantidad = (dat.Rows.Count).ToString();
            if (cantidad == "0") { com.eliminar(txtfac.Text.ToString()); }
            this.Close();
        }

        private void EliminarDetalleVenta_Load(object sender, EventArgs e)
        {
            txtIDPROV.Enabled = false;
            txtfac.Enabled = false;
        }
    }
}
