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
    public partial class eliminar_proveedor : Form
    {
        public eliminar_proveedor()
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

		private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            string cod;
            cod = txtIDPROV.Text.ToString();
			if (txtIDPROV.Text != "")
			{
				N_Proveedor pro = new N_Proveedor();
				try { pro.eliminar(cod); MessageBox.Show("Se borro correctamente"); }
				catch (Exception) { MessageBox.Show("No se puede eliminar"); return; }
				this.Close();
			}
			else
			{
				MessageBox.Show("El Campo Esta Vacio");
			}
		}

		private void txtIDPROV_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

        private void eliminar_proveedor_Load(object sender, EventArgs e)
        {
            txtIDPROV.Enabled = false;
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            listarprov lis = new listarprov();
            lis.var = "modificar";
            lis.ShowDialog();
            txtIDPROV.Text = lis.celda;
        }
    }
}
