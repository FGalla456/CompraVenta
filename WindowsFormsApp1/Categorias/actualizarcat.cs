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
    public partial class actualizarcat : Form
    {
        public actualizarcat()
        {
            InitializeComponent();
        }

		private bool DatosCompletos()
		{
			if (txtDet.Text != "" && txtIdCat.Text != "" && txtNombre.Text != "")
			{
				return true;
			}
			return false;
		}

		private void btnbuscar_Click(object sender, EventArgs e)
        {
            N_Categoria neg = new N_Categoria();
            if (neg.ExisteCat(txtIdCat.Text.ToString()) == true)
            {
                txtNombre.Enabled = true;
                txtDet.Enabled = true;
                txtIdCat.Enabled = false;

            }
            else
            {
                MessageBox.Show("Categoria inexistente ");
                return;
            }
        }

        private void actualizarcat_Load(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtDet.Enabled = false;
            txtIdCat.Enabled = false;
        }

		private void btn_aceptar_Click(object sender, EventArgs e)
		{
			if (DatosCompletos() == true)
			{
			Categoria Cat = new Categoria();
			N_Categoria neg = new N_Categoria();
			Cat.setIdCategoria(txtIdCat.Text.ToString());
			Cat.setNombre(txtNombre.Text.ToString());
			Cat.setDetalle(txtDet.Text.ToString());
			neg.modificarcate(Cat);
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
            listcategorias lis = new listcategorias();
            lis.var = "modificar";
            lis.ShowDialog();
            txtIdCat.Text = lis.celda;
            txtNombre.Text = lis.nombre;
            txtDet.Text = lis.descripcion;

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
	}
}
