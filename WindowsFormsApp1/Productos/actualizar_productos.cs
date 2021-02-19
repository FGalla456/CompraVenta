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
    public partial class actualizar_productos : Form
    {
        public actualizar_productos()
        {
            InitializeComponent();
        }

        private void actualizar_productos_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            txtIdProd.Enabled = false;
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
           N_Productos neg = new N_Productos();
            if (neg.ExisteProd(txtIdProd.Text.ToString()) == true)
            {

				//dataGridViewpro.DataSource = neg.getTabla(txtidemp.Text);
				groupBox1.Enabled = true;
				N_Categoria cat = new N_Categoria();
				cbCat.DataSource = cat.getTabla();
				cbCat.ValueMember = "IdCategoria";
				cbCat.DisplayMember = "Nombre";
				btnbuscar.Enabled = false;
                txtIdProd.Enabled = false;
                btnprod.Enabled = false;
                //txtIdProv.Enabled = false;
            }
            else
            {
                MessageBox.Show("Articulo inexistente");
                return;
            }
        }

		private bool DatosCompletos()
		{
			if (txtIdProd.Text != "" && txtNombre.Text != "" && txtprecio.Text != "")
			{
				return true;
			}
			return false;
		}


		private void btn_aceptar_Click(object sender, EventArgs e)
        {
			if (DatosCompletos() == true)
			{
				Entidad.prodssotck cli = new Entidad.prodssotck();
				cli.setIdProducto(txtIdProd.Text.ToString());
				cli.setNombre(txtNombre.Text.ToString());
                cli.setPrecio(float.Parse(txtprecio.Text.ToString()));
				//cli.setIdProv(txtIdProv.Text.ToString());
                cli.setIdCat(cbCat.SelectedValue.ToString());
				N_Productos empl = new N_Productos();
				empl.modificarprod(cli);
				MessageBox.Show("Modificado con exito ");
				this.Close();
				return;
			}
			else
			{
				MessageBox.Show("Faltan Cargar Datos");
			}
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            Listaprod lis = new Listaprod();
            lis.var = "modificar";
            lis.ShowDialog();
            txtIdProd.Text = lis.idprod;
            txtNombre.Text = lis.nombre;
            txtprecio.Text = lis.precio.ToString();
           // txtIdProv.Text = lis.idprov;
            cbCat.ValueMember = lis.idcat;

        }

		private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (txtNombre.Text == "")
			{
				if (Char.IsSeparator(e.KeyChar))
				{
					e.Handled = true;
				}
			}
		}

		private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
            if (txtprecio.Text == "")
            {
                if (e.KeyChar == '0')
                {
                    e.Handled = true;
                }
            }
        }

		private void cbCat_KeyPress(object sender, KeyPressEventArgs e)
		{
			NoPermitirEscribir(sender, e);
		}
	}
}
