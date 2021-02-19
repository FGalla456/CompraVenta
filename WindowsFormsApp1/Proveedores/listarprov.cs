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
    public partial class listarprov : Form
    {
        public string celda;
        public string var;
        
        public string empresa;
        public string cuit;
        public string direccion;
        public string telefono;
        public string mail;

        public listarprov()
        {
            InitializeComponent();
        }

        private void listarprov_Load(object sender, EventArgs e)
        {
            N_Proveedor pro = new N_Proveedor();
            dataGridView1.DataSource = pro.getTabla();
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            //string Celda;
            celda = Convert.ToString(row.Cells["Id proveedor"].Value);
            this.Close();
            if (var == "modificar")
            {
                empresa = Convert.ToString(row.Cells["nombre"].Value);
                telefono = Convert.ToString(row.Cells["Telefono"].Value);
                cuit = Convert.ToString(row.Cells["CUIT"].Value);
                mail = Convert.ToString(row.Cells["Mail o Web"].Value);
                direccion= Convert.ToString(row.Cells["Direccion"].Value);
                this.Close();
            }
        }
    }
}
