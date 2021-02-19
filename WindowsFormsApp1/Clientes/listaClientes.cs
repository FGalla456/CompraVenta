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
    public partial class listaClientes : Form
    {
        public string celda;
        public string var;
        public string nombre;
        public string apellido;
        public string telefono;
        public string mail;
        public string direccion;
        public string cuit;

        public listaClientes()
        {
            InitializeComponent();
        }

        private void listaClientes_Load(object sender, EventArgs e)
        {
            N_Clientes pro = new N_Clientes();
            dataGridView1.DataSource = pro.getTabla();
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            //string Celda;
            celda = Convert.ToString(row.Cells["cuit"].Value);
            this.Close();
            if (var == "modificar")
            {
                nombre = Convert.ToString(row.Cells["nombre"].Value);
                apellido = Convert.ToString(row.Cells["Apellido"].Value);
                telefono = Convert.ToString(row.Cells["Telefono"].Value);
                mail = Convert.ToString(row.Cells["mail"].Value);
                direccion = Convert.ToString(row.Cells["Direccion"].Value);
                this.Close();
            }
        }
    }
}
