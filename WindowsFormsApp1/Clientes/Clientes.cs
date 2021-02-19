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
    public partial class Clientes : Form
    {
        public Clientes()
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

		private void clientes_Load(object sender, EventArgs e)
		{
			N_Clientes n_cli = new N_Clientes();
			Grilla.DataSource = n_cli.getTabla();
			cbCC.Items.Add("");
			cbCC.Items.Add("Mayor a:");
			cbCC.Items.Add("Igual a:");
			cbCC.Items.Add("Menor a:");
			cbCuit.Items.Add("");
			cbCuit.Items.Add("Mayor a:");
			cbCuit.Items.Add("Igual a:");
			cbCuit.Items.Add("Menor a:");
			Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AGREGARCLIENTES var = new AGREGARCLIENTES();
            var.ShowDialog();
            N_Clientes n_cli = new N_Clientes();
            Grilla.DataSource = n_cli.getTabla();
        }

		private void txtCC_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

		private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

		private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

		private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

		private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

        private void button2_Click(object sender, EventArgs e)
        {
            elimiarcliente eli = new elimiarcliente();
            eli.ShowDialog();
            N_Clientes n_cli = new N_Clientes();
            Grilla.DataSource = n_cli.getTabla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            actualizar_clientes act = new actualizar_clientes();
             act.ShowDialog();
            N_Clientes n_cli = new N_Clientes();
            Grilla.DataSource = n_cli.getTabla();
        }

		private void button3_Click(object sender, EventArgs e)
		{
			string ClausulaSQL = "";
			if (txtNombre.Text != "")
			{
				ClausulaSQL = "WHERE " + ClausulaSQL + " Nombre = '" + txtNombre.Text + "' ";
			}
			if (txtApellido.Text != "")
			{
				if (ClausulaSQL != "")
				{
					ClausulaSQL = ClausulaSQL + " AND " + " Apellido = '" + txtApellido.Text + "' ";
				}
				else
				{
					ClausulaSQL = " WHERE " + ClausulaSQL + " Apellido = '" + txtApellido.Text + "' ";
				}
			}
			if (cbCuit.Text != "" && txtCUIT.Text != "")
			{
				ConstruirClausulaSQL("CUIT",
									 cbCuit.Text,
									 txtCUIT.Text,
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
					ClausulaSQL = " WHERE " + ClausulaSQL + " Telefono = '" + txtTel.Text + "' ";
				}
			}
			if (cbCC.Text != "" && txtCC.Text != "")
			{
				ConstruirClausulaSQL("Compras_Realizadas",
									 cbCC.Text,
									 txtCC.Text,
									 ref ClausulaSQL);
			}
			N_Clientes n_cli = new N_Clientes();
			Grilla.DataSource = n_cli.Filtrar(ClausulaSQL);
		}
	}
}
