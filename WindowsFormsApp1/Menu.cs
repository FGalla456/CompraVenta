using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word; //Libreria COM de Microsoft Word.

namespace WindowsFormsApp1
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btn_articulos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productos cli = new Productos();
            cli.ShowDialog();
            this.Show();
        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compras cli = new Compras();
            cli.ShowDialog();
            this.Show();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventas cli = new Ventas();
            cli.ShowDialog();
            this.Show();
        }

        private void btn_categorias_Click(object sender, EventArgs e)
        {
            this.Hide();
            Categorias cli = new Categorias();
            cli.ShowDialog();
            this.Show();
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empleados cli = new Empleados();
            cli.ShowDialog();
            this.Show();
        }

        private void btn_prov_Click(object sender, EventArgs e)
        {
            this.Hide();
            Proveedores cli = new Proveedores();
            cli.ShowDialog();
            this.Show();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes cli = new Clientes();
            cli.ShowDialog();
            this.Show();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Informes inf = new Informes();
            inf.ShowDialog();
            this.Show();
        }

		private void btManUsu_Click(object sender, EventArgs e)
		{
		//		Word.Application objWord = (Word.Application)Activator.CreateInstance(Type.GetTypeFromProgID("Word.Application"));
			//	object missing = System.Reflection.Missing.Value;

				string ruta = Application.StartupPath;
			//object abrirDoc = ruta +@"\Manual de Usuario 1.docx";
			//object readOnly = false;
			//object isVisible = true;

			System.Diagnostics.Process.Start(ruta + @"\Manual de Usuario 1.docx");
			//	objWord.Documents.Open(ref abrirDoc, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref isVisible, ref missing, ref missing, ref missing, ref missing);

		}
		
	}

}
