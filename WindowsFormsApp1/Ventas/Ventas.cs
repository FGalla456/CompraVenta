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
	public partial class Ventas : Form
	{
		public Ventas()
		{
			InitializeComponent();
		}

		private void ConstruirClausulaSQL(string NombreCampo,
								  string Operador,
								  string Valor,
								  ref string Clausula)
		{
			string d1 = "";  //Delimitador 1
			string d2 = ""; //Delimitador 2
			if (Clausula == "")
				Clausula = Clausula + " WHERE ";
			else
				Clausula = Clausula + " AND ";
			switch (Operador)
			{
				case "Igual a:":
					d1 = " = ";
					d2 = "";
					break;
				case "Mayor a:":
					d1 = " > ";
					d2 = "";
					break;
				case "Menor a:":
					d1 = " < ";
					d2 = "";
					break;
			}
			Clausula =
				Clausula + NombreCampo + d1 + Valor + d2;
		}

		private void PermitirSoloNumeros(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar))
			{
				e.Handled = true;
			}
			else if (Char.IsDigit(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsSeparator(e.KeyChar))
			{
				e.Handled = true;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void PermitirSoloLetras(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
			else if (Char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsSeparator(e.KeyChar))
			{
				e.Handled = true;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void NoPermitirEscribir(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar))
			{
				e.Handled = true;
			}
			else if (Char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
			else if (Char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
			else if (Char.IsSeparator(e.KeyChar))
			{
				e.Handled = true;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void btn_agregar_Click(object sender, EventArgs e)
        {
            Detalle_Venta var = new Detalle_Venta();
            Detalle_Venta.var = true;//selecciona boton agregar producto
            var.ShowDialog();
            var.Close();
            N_Ventas n_com = new N_Ventas();
            Grilla.DataSource = n_com.getTabla();
        }

		private void CargarComboBox()
		{
			cbMP.Items.Add("");
			cbMP.Items.Add("Efectivo");
			cbMP.Items.Add("Credito");
			cbMP.Items.Add("Debito");
			cbTipo.Items.Add("");
			cbTipo.Items.Add("A");
			cbTipo.Items.Add("B");
			cbTipo.Items.Add("C");
			cbFecha.Items.Add("");
			cbFecha.Items.Add("Mayor a:");
			cbFecha.Items.Add("Igual a:");
			cbFecha.Items.Add("Menor a:");
			cbTotal.Items.Add("");
			cbTotal.Items.Add("Mayor a:");
			cbTotal.Items.Add("Igual a:");
			cbTotal.Items.Add("Menor a:");
			cbBono.Items.Add("");
			cbBono.Items.Add("Interes:");
			cbBono.Items.Add("Descuento:");
		}

		private void Ventas_Load(object sender, EventArgs e)
		{
			N_Ventas n_ven = new N_Ventas();
			Grilla.DataSource = n_ven.getTabla();
			CargarComboBox();
			dtpFecha.Text = DateTime.Today.ToString();
			Grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		private void txtIdProd_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

		private void txtFactura_KeyPress(object sender, KeyPressEventArgs e)
		{
			PermitirSoloNumeros(sender, e);
		}

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            eliminarventa eli = new eliminarventa();
            eli.ShowDialog();
            N_Ventas n_ven = new N_Ventas();
            Grilla.DataSource = n_ven.getTabla();
        }

        private void btnagregardetalle_Click(object sender, EventArgs e)
        {
            Detalle_Venta det = new Detalle_Venta();
            Detalle_Venta.var = false;
            det.ShowDialog();
            N_Ventas n_com = new N_Ventas();
            Grilla.DataSource = n_com.getTabla();
        }

		private void btn_filtrar_Click(object sender, EventArgs e)
		{
			string ClausulaSQL = "";
			if (txtFactura.Text != "")
			{
				ClausulaSQL = " WHERE " + ClausulaSQL + " Nro_Factura = '" + txtFactura.Text + "' ";
			}
			if (cbMP.Text != "")
			{
				if (ClausulaSQL != "")
				{
					ClausulaSQL = ClausulaSQL + " AND " + " Metodo_Pago = '" + cbMP.Text + "' ";
				}
				else
				{
					ClausulaSQL = " WHERE " + ClausulaSQL + " Metodo_Pago = '" + cbMP.Text + "' ";
				}
			}
			if (cbTipo.Text != "")
			{
				if (ClausulaSQL != "")
				{
					ClausulaSQL = ClausulaSQL + " AND " + " Tipo = '" + cbTipo.Text + "' ";
				}
				else
				{
					ClausulaSQL = " WHERE " + ClausulaSQL + " Tipo = '" + cbTipo.Text + "' ";
				}
			}
			if (cbTotal.Text != "" && txtTotal.Text != "")
			{
				ConstruirClausulaSQL("Total",
									 cbTotal.Text,
									 txtTotal.Text,
									 ref ClausulaSQL);
			}
			if (cbBono.Text != "" && txtBono.Text != "")
			{
				///Con Interes/Descuento Especifico
				if (cbBono.Text == "Interes" && txtBono.Text != "")
				{
					if (ClausulaSQL != "")
					{
						ClausulaSQL = ClausulaSQL + " AND " + " Interes = '" + txtBono.Text + "' ";
					}
					else
					{
						ClausulaSQL = "WHERE " + ClausulaSQL + " Interes = '" + txtBono.Text + "' ";
					}
				}
				if (cbBono.Text == "Descuento" && txtBono.Text != "")
				{
					if (ClausulaSQL != "")
					{
						ClausulaSQL = ClausulaSQL + " AND " + " Interes = '-" + txtBono.Text + "' ";
					}
					else
					{
						ClausulaSQL = "WHERE " + ClausulaSQL + " Interes = '-" + txtBono.Text + "' ";
					}
				}

				///Con Interes/Descuento Sin Especificar
				if (cbBono.Text == "Interes" && txtBono.Text == "")
				{
					if (ClausulaSQL != "")
					{
						ClausulaSQL = ClausulaSQL + " AND " + " Interes > '0' ";
					}
					else
					{
						ClausulaSQL = "WHERE " + ClausulaSQL + " Interes > '0' ";
					}
				}
				if (cbBono.Text == "Descuento" && txtBono.Text != "")
				{
					if (ClausulaSQL != "")
					{
						ClausulaSQL = ClausulaSQL + " AND " + " Interes < '0' ";
					}
					else
					{
						ClausulaSQL = "WHERE " + ClausulaSQL + " Interes < '0' ";
					}
				}
			}
			string Fecha = "'"+dtpFecha.Value.ToString("dd")+"/"+ dtpFecha.Value.ToString("MM")+"/"+ dtpFecha.Value.ToString("yyyy")+"'";
			if (cbFecha.Text != "")
			{
				ConstruirClausulaSQL("Fecha",
									 cbFecha.Text,
									 Fecha,
									 ref ClausulaSQL);
			}



			N_Ventas n_ven = new N_Ventas();
			Grilla.DataSource = n_ven.Filtrar(ClausulaSQL);
		}

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            EliminarDetalleVenta eli = new EliminarDetalleVenta();
            eli.ShowDialog();
            N_Ventas n_ven = new N_Ventas();
            Grilla.DataSource = n_ven.getTabla();
        }

		private void Grilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = Grilla.CurrentRow;
			string Celda;
			Celda = Convert.ToString(row.Cells["Numero de factura"].Value);
			string Consulta;
			Consulta = "select Detalle_x_Venta.IdProd as 'Id Producto',Productos.Nombre as 'Nombre producto',Nro_Factura as 'Numero factura',Cantidad,Detalle_x_Venta.Precio_x_Unidad 'Precio x unidad'  from Detalle_x_Venta inner join Productos on Productos.IdProd = Detalle_x_Venta.IdProd where nro_factura = '" + Celda + "'";
			TDV td = new TDV();
			td.RecibeNFac(Consulta);
			td.Show();
		}
	}
	
}
