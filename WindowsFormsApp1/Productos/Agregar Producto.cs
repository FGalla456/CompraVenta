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
	public partial class Agregar_Producto : Form
	{
		public Agregar_Producto()
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

		private bool DatosCompletos()
		{
			if (txtIdProd.Text != "" && txtNombre.Text != "" && txtprecio.Text != "")
			{
				return true;
			}
			return false;
		}


		private void btn_aceptar_Click(object sender, EventArgs e)
		{
			N_Productos pro = new N_Productos();
			if (DatosCompletos() == true)
			{
				if (pro.ExisteProd(txtIdProd.Text.ToString()) == false)
				{
					Entidad.Productos Prod = new Entidad.Productos();
					Prod.setIdCat(cbCat.SelectedValue.ToString());
					Prod.setIdProducto(txtIdProd.Text.ToString());
					//Prod.setIdProv(cbProv.SelectedValue.ToString());
					Prod.setNombre(txtNombre.Text.ToString());
					Prod.setPrecio(float.Parse(txtprecio.Text.ToString()));
					Prod.setStock("0");
					pro.datosProd(Prod);
					MessageBox.Show("El Producto se Cargo Correctamente");
					this.Close();
				}
				else
				{
					MessageBox.Show("Ya Existe un Producto con ese ID");
				}
			}
			else
			{
				MessageBox.Show("Faltan Cargar Datos");
			}
        }

		private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
            if (txtprecio.Text == "")
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
            if (txtprecio.Text != "")
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    e.KeyChar = ',';
                    e.Handled = false;
                }
            }
        }

		private void txtIdProd_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

		private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (txtNombre.Text == "")
			{
				if (Char.IsSeparator(e.KeyChar))
				{
					e.Handled = true;
				}
			}
		}

        private void Agregar_Producto_Load(object sender, EventArgs e)
        {
            N_Categoria cat = new N_Categoria();
            cbCat.DataSource = cat.getTabla();
            cbCat.ValueMember = "IdCategoria";
            cbCat.DisplayMember = "Nombre";
			N_Proveedor pro = new N_Proveedor();
			//cbProv.DataSource = pro.getTabla();
           // cbProv.ValueMember = "IdProv";
           //cbProv.DisplayMember = "Nombre";
        }

		private void cbCat_KeyPress(object sender, KeyPressEventArgs e)
		{
			NoPermitirEscribir(sender, e);
		}
	}
}
