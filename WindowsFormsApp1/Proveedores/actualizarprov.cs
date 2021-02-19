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
    public partial class actualizarprov : Form
    {
        public actualizarprov()
        {
            InitializeComponent();
        }

        private void actualizarprov_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtidpro;
            gp1.Enabled = false;
            txtidpro.Enabled = false;

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

		private void btn_aceptar_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Proveedor prove = new Proveedor();
            N_Proveedor n_prov = new N_Proveedor();
            if(txtidpro.Text != "" && txtidpro.Text != " ")
            {
                gp1.Enabled = true;
                btnbuscar.Enabled = false;
                btnprod.Enabled = false;
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
		private bool DatosCompletos()
		{
			if (txtCUIT.Text != "" && txtDirec.Text != "" && txtEmpresa.Text != "" && txtMail.Text != "" && txtTel.Text != "")
			{
				return true;
			}
			return false;
		}


		private void btn_aceptar_Click_1(object sender, EventArgs e)
        {
			if (DatosCompletos() == true)
			{
				N_Proveedor prov = new N_Proveedor();
				Proveedor prove = new Proveedor();
				// string cod;
				//prov.eliminar(txtidpro.Text);
				prove.setCUIT(txtCUIT.Text.ToString());
				prove.setTelefono(txtTel.Text.ToString());
				prove.setNombre(txtEmpresa.Text.ToString());
				prove.setDireccion(txtDirec.Text.ToString());
				prove.setMail(txtMail.Text.ToString());
				prove.setIdProv(txtidpro.Text);
				N_Proveedor proved = new N_Proveedor();
				proved.modificarpro(prove);
				MessageBox.Show("El Proveedor se actualizo Correctamente");
				this.Close();
			}
			else
			{
				MessageBox.Show("Faltan Cargar Datos");
			}
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            listarprov lis = new listarprov();
            lis.var = "modificar";
            lis.ShowDialog();
            txtCUIT.Text = lis.cuit;
            txtDirec.Text = lis.direccion;
            txtEmpresa.Text = lis.empresa;
            txtMail.Text = lis.mail;
            txtTel.Text = lis.telefono;
            txtidpro.Text = lis.celda;
        }

		private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (txtEmpresa.Text == "")
			{
				if (Char.IsSeparator(e.KeyChar))
				{
					e.Handled = true;
				}
			}
		}

		private void txtTel_KeyPress_1(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

		private void txtCUIT_KeyPress_1(object sender, KeyPressEventArgs e)
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
