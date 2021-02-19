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
    public partial class listaempleados : Form
    {
        public string celda;
        public string var;

        public string nombre;
        public string apellido;
        public string direccion;
        public string telefono;
        public string mail;
        public float sueldo;

        public listaempleados()
        {
            InitializeComponent();
        }

        private void listaempleados_Load(object sender, EventArgs e)
        {
            N_Empleados pro = new N_Empleados();
            dataGridView1.DataSource = pro.getTabla();
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            //string Celda;
            celda = Convert.ToString(row.Cells["IdEmpleado"].Value);
            if (var == "modificar")
            {
                nombre = Convert.ToString(row.Cells["nombre"].Value);
                telefono = Convert.ToString(row.Cells["Telefono"].Value);
                apellido = Convert.ToString(row.Cells["apellido"].Value);
                mail = Convert.ToString(row.Cells["Mail"].Value);
                direccion = Convert.ToString(row.Cells["Direccion"].Value);
                sueldo = float.Parse(row.Cells["sueldo"].Value.ToString());
                //this.Close();
            }
            this.Close();
        }
    }
}
