using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;



namespace WindowsFormsApp1
{
    public partial class Detalle_Compra1 : Form
    {
        static public DataTable lista = new DataTable();
        static public bool var = new bool();
        
        public Detalle_Compra1()
        {
            InitializeComponent();
        }

        private void PermitirSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void NoPermitirEscribir(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void PermitirSoloLetras(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Detalle_Compra1_Load(object sender, EventArgs e)
        {
            lista.Clear();
			grdcompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			txtNFactura.Enabled = false;
            // lista.Reset();
            if (lista.Columns.Contains("id factura") == false)
            {
                lista.Columns.Add("id factura", typeof(string));
                lista.Columns.Add("cantidad", typeof(int));
                lista.Columns.Add("id producto", typeof(string));
                lista.Columns.Add("precio", typeof(float));
            }
            button1.Enabled = false;
            N_DetalleCompra det = new N_DetalleCompra();
            if (var == true)
            {
                
                txtNFactura.Text= (det.incremetarfact().ToString());
                btnfact.Visible=false;
            }
            
            txtIdProd.Enabled = false;
            txtPrecio.Enabled = false;
        }

		private bool DatosCompletos()
		{
			if (txtNFactura.Text != "" && txtCantidad.Text != "" && txtIdProd.Text != "" && txtPrecio.Text != "")
			{
				return true;
			}
			return false;
		}

		private void btAceptar_Click(object sender, EventArgs e)
        {
            
            Detalle_x_Compra DC = new Detalle_x_Compra();



            if (DatosCompletos() == true)
			{
                Detalle_x_Compra dc = new Detalle_x_Compra();
                foreach (DataRow row in lista.Rows)
                {
                    if (row["Id producto"].ToString() == txtIdProd.Text.ToString())
                    {
                        MessageBox.Show("Ya cargado si quiere ingresar mas cantidad cierre e ingrese de nuevo");
                        return;
                    }
                }
                if (Convert.ToInt32(txtCantidad.Text.ToString()) <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad mayor a 0");
                    return;
                }
                lista.Rows.Add(txtNFactura.Text.ToString(), (Int32.Parse(txtCantidad.Text)),
                txtIdProd.Text.ToString(), float.Parse(txtPrecio.Text.ToString()));
                //MessageBox.Show("Se cargo correctamente");
                grdcompras.DataSource = lista;
                button1.Enabled = true;
            }
			else
			{
				MessageBox.Show("Faltan Cargar Datos");
			}
        }

        private void button1_Click(object sender, EventArgs e)
        {
			if (DatosCompletos() == true)
			{
                if (var == true)
                {
                    Nueva_Compra nuev = new Nueva_Compra();
                    nuev.ShowDialog();
                    this.Close();
                }
                else
                {
                    N_DetalleCompra det = new N_DetalleCompra();
                    try
                    {
                        det.datosDC(Detalle_Compra1.lista);
                        MessageBox.Show("Articulo/s cargado/s en factura");
                        this.Close();
                    }
                    catch (Exception es) { MessageBox.Show("Articulo/s ya cargado/s en factura , por favor eliminelo de detalle de factura y cargelo de nuevo"); }


                }
            }
            else { MessageBox.Show("Faltan Cargar Datos");}
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            Listaprod lis = new Listaprod();
            lis.ShowDialog();
            txtIdProd.Text = lis.celda;
            txtPrecio.Text = lis.precio.ToString();
        }

        private void btnfact_Click(object sender, EventArgs e)
        {
            ListaCom listcom = new ListaCom();
            listcom.ShowDialog();
            txtNFactura.Text = listcom.celda;
        }

        private void grdcompras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grdcompras.CurrentRow;
            DataRow ar = lista.Rows[grdcompras.CurrentCell.RowIndex];
            ar.Delete();
            if(lista.Rows.Count == 0){ button1.Enabled = false; };
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            PermitirSoloNumeros(sender, e);
            if (txtPrecio.Text == "")
            {
                if (e.KeyChar == '0')
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    e.Handled = true;
                }
            }
            if (txtPrecio.Text != "")
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    e.KeyChar = ',';
                    e.Handled = false;
                }
            }
        }
    }

}
