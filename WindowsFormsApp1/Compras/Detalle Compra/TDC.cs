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
    public partial class TDC : Form
    {
        public string celda;
        public string lo;
        public TDC()
        {
            InitializeComponent();
        }
        eliminar_detalle_compra eli = new eliminar_detalle_compra();
        public int prueba;

		public void RecibeNFac(string Con)
		{
			N_DetalleCompra n_ven = new N_DetalleCompra();
			Grilla.DataSource = n_ven.Filtrar(Con);
		}

		private void TDC_Load(object sender, EventArgs e)
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

        private void Grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
