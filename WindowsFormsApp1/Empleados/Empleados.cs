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
    public partial class Empleados : Form
    {
        public Empleados()
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
            agregar_empleado var = new agregar_empleado();
            var.ShowDialog();
            N_Empleados n_emp = new N_Empleados();
            Grilla.DataSource = n_emp.getTabla();
        }

		private void EMPLEADOS_Load(object sender, EventArgs e)
		{
			N_Empleados n_emp = new N_Empleados();
			Grilla.DataSource = n_emp.getTabla();
			cbSueldo.Items.Add("");
			cbSueldo.Items.Add("Mayor a:");
			cbSueldo.Items.Add("Igual a:");
			cbSueldo.Items.Add("Menor a:");
			cbIdEm.Items.Add("");
			cbIdEm.Items.Add("Mayor a:");
			cbIdEm.Items.Add("Igual a:");
			cbIdEm.Items.Add("Menor a:");
			Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
			if (e.KeyChar == '.')
			{
				e.Handled = false;
			}
		}

		private void txtIdTel_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

		private void txtIdEmpleado_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

		private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloLetras(sender, e);
		}

		private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloLetras(sender, e);
		}

        private void button2_Click(object sender, EventArgs e)
        {
            eliminarempl eli = new eliminarempl();
            eli.ShowDialog();
            N_Empleados n_emp = new N_Empleados();
            Grilla.DataSource = n_emp.getTabla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            actualizar_empleados emp = new actualizar_empleados();
            emp.ShowDialog();
            N_Empleados n_emp = new N_Empleados();
            Grilla.DataSource = n_emp.getTabla();
        }

		private void btFiltrar_Click(object sender, EventArgs e)
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
					ClausulaSQL = "WHERE " + ClausulaSQL + " Apellido = '" + txtApellido.Text + "' ";
				}
			}
			if (cbSueldo.Text != "" && txtSueldo.Text != "")
			{
				ConstruirClausulaSQL("Sueldo",
									 cbSueldo.Text,
									 txtSueldo.Text,
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
			if (cbIdEm.Text != "" && txtIdEmpleado.Text != "")
			{
				ConstruirClausulaSQL("IdEmpleado",
									 cbIdEm.Text,
									 txtIdEmpleado.Text,
									 ref ClausulaSQL);
			}
			N_Empleados n_emp = new N_Empleados();
			Grilla.DataSource = n_emp.Filtrar(ClausulaSQL);
		}
	}
}
