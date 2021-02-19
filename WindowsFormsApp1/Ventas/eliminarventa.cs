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
    public partial class eliminarventa : Form
    {
        public eliminarventa()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string cod;
            cod = txtIDPROV.Text.ToString();
            N_Ventas pro = new N_Ventas();
            try { pro.eliminar(cod);
                MessageBox.Show("Se borro correctamente");
            }
            catch (Exception) { MessageBox.Show("No se puede eliminar"); return; }
            this.Close();
        }
    }
}
