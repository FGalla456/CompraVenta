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
    public partial class Informes : Form
    {
        public Informes()
        {
            InitializeComponent();
        }
        public string checkeado;

        private void BtnBuscarArt_Click(object sender, EventArgs e)
        {
            N_Productos prod = new N_Productos();
            string clausula = "where Stock < " + txtStock.Text.ToString();
            if ( txtStock.Text.ToString() == "" || txtStock.Text.ToString()==" ") { MessageBox.Show("Ingrese valor valido");return; }
            if (Convert.ToInt32(txtStock.Text) < 0) { MessageBox.Show("Ingrese valor valido"); return; }
            dataGridView1.DataSource= prod.Filtrar(clausula);
        }

        private void btnBuscarEmpleadomasventas_Click(object sender, EventArgs e)
        {
            N_Empleados emp = new N_Empleados();
            string clausula = "SELECT TOP(" +NumeroTopemp.Value+") empleados.IdEmpleado AS [DNI EMPLEADO],Empleados.Apellido,Empleados.Nombre, count(Nro_Factura) AS [TOTAL VENTAS] FROM Ventas inner join Empleados on Ventas.IdEmpleado = Empleados.IdEmpleado GROUP BY empleados.IdEmpleado,Empleados.Apellido,Empleados.Nombre ORDER BY[TOTAL VENTAS] DESC";
            dataGridView1.DataSource = emp.Reportestabla(clausula);
        }

        private void btnProdvendido_Click(object sender, EventArgs e)
        {
            N_Productos emp = new N_Productos();
            string clausula = "SELECT TOP(" + NumProdven.Value + ") Productos.IdProd AS [ID PRODUCTO],productos.Nombre,IdCat as 'Id Categoria',Categoria.Nombre as 'Nombre Categoria', sum(cast(detalle_x_venta.Cantidad as int)) AS [TOTAL VENDIDOS] FROM Productos INNER JOIN Detalle_x_Venta on Detalle_x_Venta.IdProd = Productos.IdProd inner join Categoria on Categoria.IdCategoria = Productos.IdCat GROUP BY Productos.IdProd ,Productos.Nombre,IdCat,Categoria.Nombre,(productos.IdProd)ORDER BY[TOTAL VENDIDOS] DESC";
            dataGridView1.DataSource = emp.Reportestabla(clausula);
        }

        private void Btnmasrecaudacion_Click(object sender, EventArgs e)
        {
            N_Empleados emp = new N_Empleados();
            string clausula = "select Top(" + numrecaudacion.Value + ") empleados.IdEmpleado as 'Id Empleado', Nombre , Apellido ,SUM(ventas.Total) as 'Total Ventas' from Empleados inner join Ventas on Empleados.IdEmpleado = Ventas.IdEmpleado group by Empleados.IdEmpleado,Nombre,Apellido order by 'Total Ventas' DESC";
            dataGridView1.DataSource = emp.Reportestabla(clausula);
        }

        private void btnBuscarfecha_Click(object sender, EventArgs e)
        {
            if(rdCompra.Checked == true)
            {
                N_Compras comp = new N_Compras();
                string fechain = "'" + dtpFecha.Value.ToString("dd") + "/" + dtpFecha.Value.ToString("MM") + "/" + dtpFecha.Value.ToString("yyyy") + "'";
                string fechafin = "'" + FechaHasta.Value.ToString("dd") + "/" + FechaHasta.Value.ToString("MM") + "/" + FechaHasta.Value.ToString("yyyy") + "'";
                checkeado = "compra";
                dataGridView1.DataSource=comp.Reportestabla("SELECT * FROM Compras WHERE fecha BETWEEN " + fechain + " AND " + fechafin);
                    
            }
            if (rdVenta.Checked == true) {
                N_Ventas comp = new N_Ventas();
                string fechain = "'" + dtpFecha.Value.ToString("dd") + "/" + dtpFecha.Value.ToString("MM") + "/" + dtpFecha.Value.ToString("yyyy") + "'";
                string fechafin = "'" + FechaHasta.Value.ToString("dd") + "/" + FechaHasta.Value.ToString("MM") + "/" + FechaHasta.Value.ToString("yyyy") + "'";
                checkeado = "venta";
                dataGridView1.DataSource = comp.Reportestabla("SELECT * FROM ventas WHERE fecha BETWEEN " + fechain + " AND " + fechafin);
            }
        }

        private void Informes_Load(object sender, EventArgs e)
        {
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkeado == "venta")
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                string Celda;
                string Consulta;
                Celda = Convert.ToString(row.Cells["nro_factura"].Value);
                Consulta = "select Detalle_x_Venta.IdProd as 'Id Producto',Productos.Nombre as 'Nombre producto',Nro_Factura as 'Numero factura',Cantidad,Detalle_x_Venta.Precio_x_Unidad 'Precio x unidad'  from Detalle_x_Venta inner join Productos on Productos.IdProd = Detalle_x_Venta.IdProd WHERE Nro_Factura = '" + Celda + "'";
                TDV td = new TDV();
                td.RecibeNFac(Consulta);
                td.Show();
            }
            if(checkeado == "compra")
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                string Celda;
                Celda = Convert.ToString(row.Cells["Nro_factura"].Value);
                string Consulta;
                Consulta = "select Detalle_x_Compra.IdProd as 'Id Producto',Nombre,Nro_Factura as 'Numero factura',Cantidad,Detalle_x_Compra.Precio_x_Unidad 'Precio x unidad'  from Detalle_x_Compra inner join Productos on Productos.IdProd = Detalle_x_Compra.IdProd WHERE Nro_Factura = '" + Celda + "'";
                TDC td = new TDC();
                td.RecibeNFac(Consulta);
                td.Show();
            }
        }
    }
}
