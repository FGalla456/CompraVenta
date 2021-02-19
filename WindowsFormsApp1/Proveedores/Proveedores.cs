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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }


		private void ConstruirClausulaSQL(string NombreCampo,
								  string Operador,
								  string Valor,
								  ref string Clausula)
		{
			string d1 = "";  //Delimitador 1
			string d2 = ""; //Delimitador 2
			if (Clausula == "")
				Clausula = Clausula + " WHERE ";
			else
				Clausula = Clausula + " AND ";
			switch (Operador)
			{
				case "Igual a:":
					d1 = " = ";
					d2 = "";
					break;
				case "Mayor a:":
					d1 = " > ";
					d2 = "";
					break;
				case "Menor a:":
					d1 = " < ";
					d2 = "";
					break;
			}
			Clausula =
				Clausula + NombreCampo + d1 + Valor + d2;
		}

		N_Proveedor n_prov = new N_Proveedor();
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

		private void Proveedores_Load(object sender, EventArgs e)
        {
			cbCuit.Items.Add("");
			cbCuit.Items.Add("Mayor a:");
			cbCuit.Items.Add("Igual a:");
			cbCuit.Items.Add("Menor a:");
			cbProv.Items.Add("");
			cbProv.Items.Add("Mayor a:");
			cbProv.Items.Add("Igual a:");
			cbProv.Items.Add("Menor a:");
			Grilla.DataSource = n_prov.getTabla();
			Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

        private void button1_Click(object sender, EventArgs e)
        {
            agregar_proveedor var = new agregar_proveedor();
            var.ShowDialog();
            Grilla.DataSource = null;
            Grilla.DataSource = n_prov.getTabla();
        }

		private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

		private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

		private void txtProv_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

        private void btneliminarprov_Click(object sender, EventArgs e)
        {
            eliminar_proveedor eli = new eliminar_proveedor();
            eli.ShowDialog();
            Grilla.DataSource = null;
            Grilla.DataSource = n_prov.getTabla();
        }

        private void actualizarprov_Click(object sender, EventArgs e)
        {
            actualizarprov mod = new actualizarprov();
            mod.ShowDialog();
            Grilla.DataSource = null;
            Grilla.DataSource = n_prov.getTabla();
        }

		private void btFiltrar_Click(object sender, EventArgs e)
		{
			string ClausulaSQL = "";
			if (txtNombre.Text != "")
			{
				ClausulaSQL = "WHERE " + ClausulaSQL + " Nombre = '" + txtNombre.Text + "' ";
			}
			if (cbProv.Text != "" && txtProv.Text != "")
			{
				ConstruirClausulaSQL("IdProv",
									 cbProv.Text,
									 txtProv.Text,
									 ref ClausulaSQL);
			}
			if (cbCuit.Text != "" && txtCuit.Text != "")
			{
				ConstruirClausulaSQL("Cuit",
									 cbCuit.Text,
									 txtCuit.Text,
									 ref ClausulaSQL);
			}
			if (txtTel.Text != "")
			{
				if (ClausulaSQL != "")
				{
					ClausulaSQL = ClausulaSQL + " AND " + " Telefono = '" + txtTel.Text + "' ";
				}
				else
				{
					ClausulaSQL = "WHERE " + ClausulaSQL + " Telefono = '" + txtTel.Text + "' ";
				}
			}
			N_Proveedor n_prov = new N_Proveedor();
			Grilla.DataSource = n_prov.Filtrar(ClausulaSQL);
		}

		private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(txtNombre.Text == "")
			{
				if (Char.IsSeparator(e.KeyChar))
				{
					e.Handled = true;
				}
			}
		}
	}
}
