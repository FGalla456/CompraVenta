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

namespace WindowsFormsApp1
{
    public partial class eliminarempl : Form
    {
        public eliminarempl()
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

		private void btnAceptar_Click(object sender, EventArgs e)
        {
            string cod;
            cod = txtIDPROV.Text.ToString();
			if (txtIDPROV.Text != "")
			{
				N_Empleados pro = new N_Empleados();
				if (txtIDPROV.Text == "" || txtIDPROV.Text == " ") { MessageBox.Show("Ingrese datos"); return; }
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

        private void btnprod_Click(object sender, EventArgs e)
        {
            listaempleados lis = new listaempleados();
            lis.ShowDialog();
            txtIDPROV.Text = lis.celda;
        }

        private void eliminarempl_Load(object sender, EventArgs e)
        {
            txtIDPROV.Enabled = false;
        }
    }
}
