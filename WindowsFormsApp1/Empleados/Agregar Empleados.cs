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
    public partial class agregar_empleado : Form
    {
        public agregar_empleado()
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
			if (txtApellido.Text != "" && txtDirec.Text != "" && txtNombre.Text != "" && txtIdEmpleado.Text != "" && txtMail.Text != "" && txtSueldo.Text != "" && txtTel.Text != "")
			{
				return true;
			}
			return false;
		}

		private void btn_aceptar_Click(object sender, EventArgs e)
		{
			N_Empleados empl = new N_Empleados();
			if (DatosCompletos() == true)
			{
				if (empl.ExisteEmp(txtIdEmpleado.Text.ToString()) == false)
				{
					Entidad.Empleados Emp = new Entidad.Empleados();
					Emp.setIdEmpleado(txtIdEmpleado.Text.ToString());
					Emp.setNombre(txtNombre.Text.ToString());
					Emp.setApellido(txtApellido.Text.ToString());
					Emp.setTelefono(txtTel.Text.ToString());
					Emp.setMail(txtMail.Text.ToString());
					Emp.setDireccion(txtDirec.Text.ToString());
					Emp.setSueldo(float.Parse(txtSueldo.Text.ToString()));
					empl.datosEmp(Emp);
					MessageBox.Show("El Empleado se Cargo Correctamente");
                    this.Close();
				}
				else
				{
					MessageBox.Show("Ya Existe un Empleado con ese ID");
				}
			}
			else
			{
				MessageBox.Show("Faltan Cargar Datos");
			}
        }

		private void txtIdEmpleado_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
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

		private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
            if (txtSueldo.Text == "")
            {
                if (e.KeyChar == '0')
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    e.Handled = true;
                }
            }
            if (txtSueldo.Text != "")
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    e.KeyChar = ',';
                    e.Handled = false;
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
