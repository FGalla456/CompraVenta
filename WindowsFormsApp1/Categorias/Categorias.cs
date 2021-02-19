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
	public partial class Categorias : Form
	{
		public Categorias()
		{
			InitializeComponent();
		}
        N_Categoria n_cat = new N_Categoria();

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Agregar_Categoria var =new  Agregar_Categoria();
            var.ShowDialog();
            Grilla.DataSource = n_cat.getTabla();
        }

		private void Categorias_Load(object sender, EventArgs e)
		{
			Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			N_Categoria n_cat = new N_Categoria();
			Grilla.DataSource = n_cat.getTabla();
		}

        private void button2_Click(object sender, EventArgs e)
        {
            eliminarcat eli = new eliminarcat();
            eli.ShowDialog();
            Grilla.DataSource = n_cat.getTabla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            actualizarcat act = new actualizarcat();
            N_Categoria n_cat = new N_Categoria();
            act.ShowDialog();
            Grilla.DataSource = n_cat.getTabla();
        }
    }
}
