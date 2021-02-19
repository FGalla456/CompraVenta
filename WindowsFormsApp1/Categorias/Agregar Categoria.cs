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
	public partial class Agregar_Categoria : Form
	{
		public Agregar_Categoria()
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
			if (txtDet.Text != "" && txtIdCat.Text != "" && txtNombre.Text != "") 
			{
				return true;
			}
			return false;
		}

		private void btn_aceptar_Click(object sender, EventArgs e)
		{
			N_Categoria cat = new N_Categoria();
			if(DatosCompletos() == true)
			{
				if (cat.ExisteCat(txtIdCat.Text.ToString()) == false)
				{
					Categoria Cat = new Categoria();
					Cat.setIdCategoria(txtIdCat.Text.ToString());
					Cat.setNombre(txtNombre.Text.ToString());
					Cat.setDetalle(txtDet.Text.ToString());
					cat.datosCat(Cat);
					MessageBox.Show("La Categoria se Cargo Correctamente");
					this.Close();
				}
				else
				{
					MessageBox.Show("Imposible Cargar, Id Categoria Ya Existente");
				}
			}
			else
			{
				MessageBox.Show("Faltan Datos por Cargar");
			}
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

        private void Agregar_Categoria_Load(object sender, EventArgs e)
        {

        }
    }
}
