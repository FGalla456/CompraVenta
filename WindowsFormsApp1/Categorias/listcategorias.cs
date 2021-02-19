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

    public partial class listcategorias : Form
    {
        public string celda;
        public string var;
        public string nombre;
        public string descripcion;

        public listcategorias()
        {
            InitializeComponent();
        }

        private void listcategorias_Load(object sender, EventArgs e)
        {
            N_Categoria pro = new N_Categoria();
            dataGridView1.DataSource = pro.getTabla();
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            //string Celda;
            celda = Convert.ToString(row.Cells["Idcategoria"].Value);
            if (var == "modificar")
            {
                nombre = Convert.ToString(row.Cells["nombre"].Value);
                descripcion = Convert.ToString(row.Cells["detalle"].Value);
                //this.Close();
            }
            this.Close();
        }
    }
}
