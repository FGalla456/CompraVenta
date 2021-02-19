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
    public partial class actualizar_clientes : Form
    {
        public actualizar_clientes()
        {
            InitializeComponent();
        }
        private bool DatosCompletos()
        {
            if (txtApellido.Text != "" && txtCUIT.Text != "" && txtNombre.Text != "" && txtDirec.Text != "" && txtMail.Text != "" && txtTel.Text != "")
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

		private void btnbuscar_Click(object sender, EventArgs e)
        {
             N_Clientes cli = new N_Clientes();
            if (cli.ExisteCli(txtCUIT.Text.ToString()) == true)
            {
                groupBox1.Enabled = true;
                txtCUIT.Enabled = false;
                btnbuscar.Enabled = false;
                btnprod.Enabled = false;
            }
            else
            {
                MessageBox.Show("cliente inexistente ");
                
                return;
            }
        }

        private void actualizar_clientes_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            txtCUIT.Enabled = false;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (DatosCompletos() == true)
            {
                Entidad.Clientes cli = new Entidad.Clientes();
                cli.setApellido(txtApellido.Text.ToString());
                cli.setDireccion(txtDirec.Text.ToString());
                cli.setMail(txtMail.Text.ToString());
                cli.setTelefono(txtTel.Text.ToString());
                cli.setNombre(txtNombre.Text.ToString());
                cli.setCUIT(txtCUIT.Text.ToString());
                N_Clientes clie = new N_Clientes();
                clie.modificarcliente(cli);
                MessageBox.Show("Modificado con exito ");
                this.Close();
                return;
            }
            else { MessageBox.Show("Complete todos los campos "); return; }
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            listaClientes lis = new listaClientes();
            lis.var = "modificar";
            lis.ShowDialog();
            txtNombre.Text = lis.nombre;
            txtDirec.Text = lis.direccion;
            txtApellido.Text = lis.apellido;
            txtMail.Text = lis.mail;
            txtTel.Text = lis.telefono;
            txtCUIT.Text = lis.celda;
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

		private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloLetras(sender, e);
		}

		private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloLetras(sender, e);
		}

		private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}
	}
}
