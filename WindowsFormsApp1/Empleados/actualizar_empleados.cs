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
    public partial class actualizar_empleados : Form
    {
        public actualizar_empleados()
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

		private void actualizar_empleados_Load(object sender, EventArgs e)
        {
            gp1.Enabled = false;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            N_Empleados neg = new N_Empleados();
            if (neg.ExisteEmp(txtidemp.Text.ToString()) == true)
            {
                //dataGridViewpro.DataSource = neg.getTabla(txtidemp.Text);
                gp1.Enabled = true;
                btnbuscar.Enabled = false;
                txtidemp.Enabled = false;
                btnprod.Enabled = false;
            }
            else
            {
                MessageBox.Show("Empleado inexistente ");
                return;
            }
        }

		private bool DatosCompletos()
		{
			if (txtApellido.Text != "" && txtDirec.Text != "" && txtNombre.Text != "" && txtMail.Text != "" && txtsueldo.Text != "" && txtTel.Text != "")
			{
				return true;
			}
			return false;
		}


		private void btn_aceptar_Click(object sender, EventArgs e)
        {
			if (DatosCompletos() == true)
			{
				Entidad.Empleados cli = new Entidad.Empleados();
				cli.setApellido(txtApellido.Text.ToString());
				cli.setDireccion(txtDirec.Text.ToString());
				cli.setMail(txtMail.Text.ToString());
				cli.setTelefono(txtTel.Text.ToString());
				cli.setNombre(txtNombre.Text.ToString());
				cli.setIdEmpleado(txtidemp.Text.ToString());
				cli.setSueldo((float)Convert.ToDouble(txtsueldo.Text));
				N_Empleados empl = new N_Empleados();
				empl.modificaremp(cli);
				MessageBox.Show("Modificado con exito ");
				this.Close();
				return;
			}
			else
			{
				MessageBox.Show("Fatan Cargar Datos");
			}
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            listaempleados lis = new listaempleados();
            lis.var = "modificar";
            lis.ShowDialog();
            txtNombre.Text = lis.nombre;
            txtDirec.Text = lis.direccion;
            txtApellido.Text = lis.apellido;
            txtMail.Text = lis.mail;
            txtTel.Text = lis.telefono;
            txtidemp.Text = lis.celda;
            txtsueldo.Text = lis.sueldo.ToString();
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

		private void txtsueldo_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
			if (e.KeyChar == '.')
			{
				e.Handled = false;
			}
		}
	}
}
