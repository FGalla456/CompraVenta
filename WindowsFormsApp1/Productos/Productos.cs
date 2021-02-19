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
	public partial class Productos : Form
	{
		public Productos()
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

		private void btn_agregar_Click(object sender, EventArgs e)
        {
            Agregar_Producto var = new Agregar_Producto();
            N_Productos n_prod = new N_Productos();
            var.ShowDialog();
            Grilla.DataSource = n_prod.getTabla();
        }

		private void Productos_Load(object sender, EventArgs e)
		{
			N_Productos n_prod = new N_Productos();
			Grilla.DataSource = n_prod.getTabla();
			cbProd.Items.Add("");
			cbProd.Items.Add("Mayor a:");
			cbProd.Items.Add("Igual a:");
			cbProd.Items.Add("Menor a:");
			cbStock.Items.Add("");
			cbStock.Items.Add("Mayor a:");
			cbStock.Items.Add("Igual a:");
			cbStock.Items.Add("Menor a:");
			N_Categoria cat = new N_Categoria();
            cbCat.DataSource = cat.getTabla();
			cbCat.ValueMember = "IdCategoria";
			cbCat.DisplayMember = "Nombre";
			Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

		}

		private void txtProv_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

		private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
			if(e.KeyChar == '.')
			{
				e.Handled = false;
			}
		}

		private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

		private void txtIddProd_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

        private void button2_Click(object sender, EventArgs e)
        {
            eliminarprod eli = new eliminarprod();
            N_Productos n_prod = new N_Productos();
            eli.ShowDialog();
            Grilla.DataSource = n_prod.getTabla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            actualizar_productos prod = new actualizar_productos();
            N_Productos n_prod = new N_Productos();
            prod.ShowDialog();
            Grilla.DataSource = n_prod.getTabla();
        }

		private void btFiltrar_Click(object sender, EventArgs e)
		{
			string ClausulaSQL = "";
			if (cbProd.Text != "" && txtIdProd.Text != "")
			{
				ConstruirClausulaSQL("IdProd",
									 cbProd.Text,
									 txtIdProd.Text,
									 ref ClausulaSQL);
			}
			if (cbStock.Text != "" && txtStock.Text != "")
			{
				ConstruirClausulaSQL("Stock",
									 cbStock.Text,
									 txtStock.Text,
									 ref ClausulaSQL);
			}
			if (cbCat.Text != "")
			{
                try
                {
                    if (ClausulaSQL != "")
                    {
                        ClausulaSQL = ClausulaSQL + " AND " + " IdCat = '" + cbCat.SelectedValue.ToString() + "' ";
                    }
                    else
                    {
                        ClausulaSQL = "WHERE " + ClausulaSQL + " IdCat = '" + cbCat.SelectedValue.ToString() + "' ";
                    }
                }
                catch (Exception pe)
                { MessageBox.Show("Error al filtrar,Ingrese categoria valida ");return; };
            }

			N_Productos n_prod = new N_Productos();
            try
            { Grilla.DataSource = n_prod.Filtrar(ClausulaSQL);}
            catch(Exception pe)
            { MessageBox.Show("Error al filtrar"); };
		}
	}
}
