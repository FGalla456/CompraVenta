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
    public partial class agregar_proveedor : Form
    {
        public agregar_proveedor()
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
		private bool DatosCompletos()
		{
			if (txtCUIT.Text != "" && txtDirec.Text != "" && txtEmpresa.Text != "" && txtIdProv.Text != "" && txtMail.Text != "" && txtTel.Text != "")
			{
				return true;
			}
			return false;
		}


		private void btn_aceptar_Click(object sender, EventArgs e)
		{
			N_Proveedor pro = new N_Proveedor();
			if (DatosCompletos() == true)
			{
				if (pro.ExisteProv(txtIdProv.Text.ToString()) == false)
				{
					Proveedor prov = new Proveedor();
					prov.setCUIT(txtCUIT.Text.ToString());
					prov.setTelefono(txtTel.Text.ToString());
					prov.setNombre(txtEmpresa.Text.ToString());
					prov.setDireccion(txtDirec.Text.ToString());
					prov.setMail(txtMail.Text.ToString());
					prov.setIdProv(txtIdProv.Text.ToString());
					pro.datosProv(prov);
					MessageBox.Show("El Proveedor se Cargo Correctamente");
					this.Close();
				}
				else
				{
					MessageBox.Show("El Cliente Ya existe con ese cuit");
				}
			}
			else
			{
				MessageBox.Show("Faltan Cargar Datos");
			}
        }

		private void txtIdProv_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

		private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

		private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

		private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (txtEmpresa.Text == "") {
				if (Char.IsSeparator(e.KeyChar))
				{
					e.Handled = true;
				}
			}
		}

		private void txtDirec_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (txtDirec.Text == "")
			{
				if (Char.IsSeparator(e.KeyChar))
				{
					e.Handled = true;
				}
			}
		}

		private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
		{
				if (Char.IsSeparator(e.KeyChar))
				{
					e.Handled = true;
				}
		}
	}
}
