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
    public partial class Detalle_Venta : Form
    {
        public float precioa;
        static public DataTable lista = new DataTable();
        static public bool var = new bool();
        public Detalle_Venta()
        {
            InitializeComponent();
        }

        private bool DatosCompletos()
        {
            if (txtCantidad.Text != "" && txtIdProd.Text != "" && txtNFactura.Text != "" && numericUpDown1.Text != "")
            {
                return true;
            }
            return false;
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

        private void btnfact_Click(object sender, EventArgs e)
        {
            ListaVen li = new ListaVen();
            li.ShowDialog();
            txtNFactura.Text = li.celda;
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            Listaprod prod = new Listaprod();
            prod.ShowDialog();
            txtIdProd.Text = prod.celda;
            txtstock.Text = ((prod.stock).ToString());
            numericUpDown1.Text = prod.precio.ToString() ;
            precioa = prod.precio;
        }

        private void Detalle_Venta_Load(object sender, EventArgs e)
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
            N_DetalleVenta det = new N_DetalleVenta();
            if (var == true)
            {
                txtNFactura.Text = (det.incremetarfact().ToString());
                btnfact.Visible = false;
            }
            txtstock.Enabled = false;
            txtIdProd.Enabled = false;
        }

        private void btAceptar_Click_1(object sender, EventArgs e)
        {
            Listaprod prod = new Listaprod();
            Detalle_x_Compra DC = new Detalle_x_Compra();
            if (DatosCompletos() == true)
            {
                Detalle_x_Venta dc = new Detalle_x_Venta();
                foreach (DataRow row in lista.Rows)
                {
                    if (row["id producto"].ToString() == txtIdProd.Text.ToString())
                    {
                        MessageBox.Show("Ya cargado si quiere ingresar mas cantidad cierre e ingrese de nuevo");
                        return;
                    }
                }
                if (Convert.ToInt32(txtstock.Text.ToString()) - Convert.ToInt32(txtCantidad.Text.ToString()) < 0) {
                    MessageBox.Show("Stock insuficiente");
                    return;
                }
                if (float.Parse(numericUpDown1.Text.ToString()) <= precioa)
                {
                    MessageBox.Show("El precio Venta no puede ser menor al de compra ");
                    return;
                }

                if (Convert.ToInt32(txtCantidad.Text.ToString()) <= 0) { MessageBox.Show("Ingrese una cantidad mayor a 0");return; }
                lista.Rows.Add(txtNFactura.Text.ToString(), (Int32.Parse(txtCantidad.Text)),
                txtIdProd.Text.ToString(), float.Parse(numericUpDown1.Text.ToString()));
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
                    Nueva_Venta nuev = new Nueva_Venta();
                    nuev.ShowDialog();
                    this.Close();
                }
                else
                {
                    N_DetalleVenta det = new N_DetalleVenta();
                    try
                    {
                        det.datosDC(Detalle_Venta.lista);
                        MessageBox.Show("Articulo/s cargado/s en factura");
                        this.Close();
                    }
                    catch (Exception es) { MessageBox.Show("Articulo/s ya cargado/s en factura , por favor eliminelo de detalle de factura y cargelo de nuevo"); }


                }
            }
            else { MessageBox.Show("Faltan Cargar Datos"); }
        }

        private void grdcompras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grdcompras.CurrentRow;
            DataRow ar = lista.Rows[grdcompras.CurrentCell.RowIndex];
            ar.Delete();
            if (lista.Rows.Count == 0) { button1.Enabled = false; };
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
