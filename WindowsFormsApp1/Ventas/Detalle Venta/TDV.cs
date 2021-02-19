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
    public partial class TDV : Form
    {
        public string celda;
        public string lo;
        public TDV()
        {
            InitializeComponent();
        }
        EliminarDetalleVenta eli = new EliminarDetalleVenta();
        public int prueba;

        public void RecibeNFac(string Con)
		{
			N_DetalleVenta n_ven = new N_DetalleVenta();
			Grilla.DataSource = n_ven.Filtrar(Con);
		}

        private void TDV_Load(object sender, EventArgs e)
        {
			Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

        private void Grilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (prueba == 1)
            {
                DataGridViewRow row = Grilla.CurrentRow;

                celda = Convert.ToString(row.Cells["Id producto"].Value);
                this.Close();
            }
        }
    }
}
