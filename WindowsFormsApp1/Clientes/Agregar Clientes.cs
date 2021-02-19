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
    public partial class AGREGARCLIENTES : Form
    {
        public AGREGARCLIENTES()
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
			if (txtApellido.Text != "" && txtCUIT.Text != "" && txtDirec.Text != "" && txtMail.Text != "" && txtNombre.Text != "" && txtTel.Text != "")
			{
				return true;
			}
			return false;
		}


		private void btn_aceptar_Click(object sender, EventArgs e)
		{
			N_Clientes clie = new N_Clientes();
			if(DatosCompletos() == true)
			{
				if (clie.ExisteCli(txtCUIT.Text.ToString()) == false)
				{
					Entidad.Clientes Cli = new Entidad.Clientes();
					Cli.setCUIT(txtCUIT.Text.ToString());
					Cli.setNombre(txtNombre.Text.ToString());
					Cli.setApellido(txtApellido.Text.ToString());
					Cli.setTelefono(txtTel.Text.ToString());
					Cli.setMail(txtMail.Text.ToString());
					Cli.setDireccion(txtDirec.Text.ToString());
					clie.datosCli(Cli);
					MessageBox.Show("El Cliente se Cargo Correctamente");
                    this.Close();
				}
				else
				{
					MessageBox.Show("Ya existe un Cliente con ese CUIT");
				}
			}
			else
			{
				MessageBox.Show("Faltan Cargar Datos");
			}
        }

		private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender,e);
		}

		private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloLetras(sender,e);
		}

		private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloLetras(sender, e);
		}

		private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

		private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
		{
				if (Char.IsSeparator(e.KeyChar))
				{
					e.Handled = true;
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
	}
}
