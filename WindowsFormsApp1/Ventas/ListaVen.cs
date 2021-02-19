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
    public partial class ListaVen : Form
    {
        public string celda;
        public ListaVen()
        {
            InitializeComponent();
        }

        private void ListaVen_Load(object sender, EventArgs e)
        {
            N_Ventas comp = new N_Ventas();
            dataGridView1.DataSource = comp.getTabla();
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}


        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            celda = Convert.ToString(row.Cells[0].Value);
            this.Close();
        }
    }
}
