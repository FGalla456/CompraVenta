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
    public partial class Listaprod : Form
    {
        public string celda;
        public string var;
        public int stock;
        public string nombre;
        public string idprov;
        public string idcat;
        public string idprod;
        public float precio;
        public Listaprod()
        
        {
            InitializeComponent();
        }

        private void Listaprod_Load(object sender, EventArgs e)
        {
            N_Productos pro = new N_Productos();
            dataGridView1.DataSource = pro.getTabla();
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            //string Celda;
            celda = Convert.ToString(row.Cells["Id producto"].Value);
            stock = Convert.ToInt32(row.Cells["Stock"].Value);
            precio = (float.Parse(row.Cells["precio unitario"].Value.ToString()));
            this.Close();
            if (var == "modificar")
            {
                nombre = Convert.ToString(row.Cells["nombre"].Value);
                //idprov = Convert.ToString(row.Cells["idprov"].Value);
                idcat = Convert.ToString(row.Cells["Id Categoria"].Value);
                idprod = Convert.ToString(row.Cells[0].Value);
                
                this.Close();
            }
        }
    }
}
