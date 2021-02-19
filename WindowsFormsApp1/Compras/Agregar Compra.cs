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
	public partial class Nueva_Compra : Form
	{
        DataTable lista = new DataTable();
        Detalle_Compra1 det = new Detalle_Compra1();
        public Nueva_Compra()
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

		private bool DatosCompletos()
		{
			if (txtFactura.Text != "" && txtIdProv.Text != "")
			{
				if (txtDescuento.Text != "" || txtInteres.Text != "")
				{
                    return true;
				}
                else
                {
                    txtInteres.Text = "0";
                }
			}
			return false;
		}

		private void btn_aceptar_Click(object sender, EventArgs e)
		{
			N_Compras Com = new N_Compras();
            N_DetalleCompra detco = new N_DetalleCompra();
			if(DatosCompletos()== true)
			{
				if (Com.ExisteCom(txtFactura.Text.ToString()) == false)
				{
					Entidad.Compras Comp = new Entidad.Compras();
					Comp.setFactura(txtFactura.Text.ToString());
					Comp.setIdProveedor(txtIdProv.Text.ToString());
					Comp.setMetodo(cbMetodoPago.Text.ToString());
					Comp.setTipo(cbTipo.Text.ToString());
					Comp.setFecha(dtpFecha.Text.ToString());
					if (txtInteres.Text == "")
					{
						string Desc = "-" + txtDescuento.Text.ToString();
						Comp.setInteres(Int32.Parse(Desc));
					}
					if (txtDescuento.Text == "")
					{
						Comp.setInteres(Int32.Parse(txtInteres.Text.ToString()));
					}
					Comp.setTotal(0);
					Comp.setTotIVA(0);
					Com.datosCom(Comp);
					detco.datosDC(Detalle_Compra1.lista);
					MessageBox.Show("La Compra se Cargo Correctamente");
					this.Close();
				}    
			}
			else
			{
				MessageBox.Show("Faltan Cargar Datos");
			}
		}

		private void Nueva_Compra_Load(object sender, EventArgs e)
		{
            N_Compras Com = new N_Compras();
            dtpFecha.Text = DateTime.Today.ToString();
            cbMetodoPago.Items.Add("Efectivo");
            cbMetodoPago.Items.Add("Credito");
            cbMetodoPago.Items.Add("Debito");
            cbTipo.Items.Add("A");
            cbTipo.Items.Add("B");
            cbTipo.Items.Add("C");
            cbMetodoPago.Text = "Efectivo";
            cbTipo.Text = "A";
            txtFactura.Text = Com.incremetarfact().ToString();
            dtpFecha.Text = DateTime.Today.ToString();
            btn_aceptar.Enabled = true;
            lista.Columns.Add("idfac", typeof(string));
            lista.Columns.Add("cant", typeof(int));
            lista.Columns.Add("idprod", typeof(string));
            lista.Columns.Add("precio", typeof(float));
            txtIdProv.Enabled = false;


        }

        private void txtFactura_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

		private void txtInteres_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (txtDescuento.Text.ToString() != "")
			{
				txtDescuento.Text = "";
			}
			PermitirSoloNumeros(sender, e);
		}

		private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (txtInteres.Text.ToString() != "")
			{
				txtInteres.Text = "";
			}
			PermitirSoloNumeros(sender, e);
		}

		private void txtIdProv_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

		private void cbMetodoPago_KeyPress(object sender, KeyPressEventArgs e)
		{
			NoPermitirEscribir(sender, e);
		}

		private void cbTipo_KeyPress(object sender, KeyPressEventArgs e)
		{
			NoPermitirEscribir(sender, e);
		}

        private void agregardetalle_Click(object sender, EventArgs e)
        {
            Detalle_Compra1 det = new Detalle_Compra1();
            det.Show();
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            listarprov lis = new listarprov();
            lis.ShowDialog();
            txtIdProv.Text = lis.celda;
        }
    }
}
