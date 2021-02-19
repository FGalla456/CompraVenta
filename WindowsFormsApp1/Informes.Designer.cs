namespace WindowsFormsApp1
{
    partial class Informes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.BtnBuscarArt = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBuscarEmpleadomasventas = new System.Windows.Forms.Button();
			this.NumeroTopemp = new System.Windows.Forms.NumericUpDown();
			this.btnProdvendido = new System.Windows.Forms.Button();
			this.NumProdven = new System.Windows.Forms.NumericUpDown();
			this.numrecaudacion = new System.Windows.Forms.NumericUpDown();
			this.Btnmasrecaudacion = new System.Windows.Forms.Button();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.FechaHasta = new System.Windows.Forms.DateTimePicker();
			this.FechaDesde = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.rdCompra = new System.Windows.Forms.RadioButton();
			this.rdVenta = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnBuscarfecha = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumeroTopemp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumProdven)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numrecaudacion)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnBuscarArt
			// 
			this.BtnBuscarArt.Location = new System.Drawing.Point(12, 12);
			this.BtnBuscarArt.Name = "BtnBuscarArt";
			this.BtnBuscarArt.Size = new System.Drawing.Size(217, 84);
			this.BtnBuscarArt.TabIndex = 0;
			this.BtnBuscarArt.Text = "Buscar Articulos con Stock Menor a";
			this.BtnBuscarArt.UseVisualStyleBackColor = true;
			this.BtnBuscarArt.Click += new System.EventHandler(this.BtnBuscarArt_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(235, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(972, 403);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// txtStock
			// 
			this.txtStock.Location = new System.Drawing.Point(172, 102);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(57, 20);
			this.txtStock.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 105);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Stock a Buscar:";
			// 
			// btnBuscarEmpleadomasventas
			// 
			this.btnBuscarEmpleadomasventas.Location = new System.Drawing.Point(12, 128);
			this.btnBuscarEmpleadomasventas.Name = "btnBuscarEmpleadomasventas";
			this.btnBuscarEmpleadomasventas.Size = new System.Drawing.Size(154, 84);
			this.btnBuscarEmpleadomasventas.TabIndex = 4;
			this.btnBuscarEmpleadomasventas.Text = "Buscar Top Empleados con mas Ventas";
			this.btnBuscarEmpleadomasventas.UseVisualStyleBackColor = true;
			this.btnBuscarEmpleadomasventas.Click += new System.EventHandler(this.btnBuscarEmpleadomasventas_Click);
			// 
			// NumeroTopemp
			// 
			this.NumeroTopemp.Location = new System.Drawing.Point(172, 162);
			this.NumeroTopemp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumeroTopemp.Name = "NumeroTopemp";
			this.NumeroTopemp.Size = new System.Drawing.Size(57, 20);
			this.NumeroTopemp.TabIndex = 5;
			this.NumeroTopemp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// btnProdvendido
			// 
			this.btnProdvendido.Location = new System.Drawing.Point(12, 331);
			this.btnProdvendido.Name = "btnProdvendido";
			this.btnProdvendido.Size = new System.Drawing.Size(154, 84);
			this.btnProdvendido.TabIndex = 6;
			this.btnProdvendido.Text = "Buscar top Producto mas Vendido";
			this.btnProdvendido.UseVisualStyleBackColor = true;
			this.btnProdvendido.Click += new System.EventHandler(this.btnProdvendido_Click);
			// 
			// NumProdven
			// 
			this.NumProdven.Location = new System.Drawing.Point(172, 365);
			this.NumProdven.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumProdven.Name = "NumProdven";
			this.NumProdven.Size = new System.Drawing.Size(57, 20);
			this.NumProdven.TabIndex = 7;
			this.NumProdven.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numrecaudacion
			// 
			this.numrecaudacion.Location = new System.Drawing.Point(172, 265);
			this.numrecaudacion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numrecaudacion.Name = "numrecaudacion";
			this.numrecaudacion.Size = new System.Drawing.Size(57, 20);
			this.numrecaudacion.TabIndex = 9;
			this.numrecaudacion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// Btnmasrecaudacion
			// 
			this.Btnmasrecaudacion.Location = new System.Drawing.Point(12, 231);
			this.Btnmasrecaudacion.Name = "Btnmasrecaudacion";
			this.Btnmasrecaudacion.Size = new System.Drawing.Size(154, 84);
			this.Btnmasrecaudacion.TabIndex = 8;
			this.Btnmasrecaudacion.Text = "Buscar Top Empleado mas Recaudacion";
			this.Btnmasrecaudacion.UseVisualStyleBackColor = true;
			this.Btnmasrecaudacion.Click += new System.EventHandler(this.Btnmasrecaudacion_Click);
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(12, 465);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(95, 20);
			this.dtpFecha.TabIndex = 45;
			// 
			// FechaHasta
			// 
			this.FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.FechaHasta.Location = new System.Drawing.Point(134, 465);
			this.FechaHasta.Name = "FechaHasta";
			this.FechaHasta.Size = new System.Drawing.Size(95, 20);
			this.FechaHasta.TabIndex = 46;
			// 
			// FechaDesde
			// 
			this.FechaDesde.AutoSize = true;
			this.FechaDesde.Location = new System.Drawing.Point(25, 446);
			this.FechaDesde.Name = "FechaDesde";
			this.FechaDesde.Size = new System.Drawing.Size(38, 13);
			this.FechaDesde.TabIndex = 47;
			this.FechaDesde.Text = "Desde";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(169, 446);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 48;
			this.label3.Text = "Hasta";
			// 
			// rdCompra
			// 
			this.rdCompra.AutoSize = true;
			this.rdCompra.Location = new System.Drawing.Point(6, 19);
			this.rdCompra.Name = "rdCompra";
			this.rdCompra.Size = new System.Drawing.Size(61, 17);
			this.rdCompra.TabIndex = 49;
			this.rdCompra.Text = "Compra";
			this.rdCompra.UseVisualStyleBackColor = true;
			// 
			// rdVenta
			// 
			this.rdVenta.AutoSize = true;
			this.rdVenta.Location = new System.Drawing.Point(122, 19);
			this.rdVenta.Name = "rdVenta";
			this.rdVenta.Size = new System.Drawing.Size(53, 17);
			this.rdVenta.TabIndex = 50;
			this.rdVenta.Text = "Venta";
			this.rdVenta.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdVenta);
			this.groupBox1.Controls.Add(this.rdCompra);
			this.groupBox1.Location = new System.Drawing.Point(12, 491);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(217, 56);
			this.groupBox1.TabIndex = 51;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tipo dato a buscar";
			// 
			// btnBuscarfecha
			// 
			this.btnBuscarfecha.Location = new System.Drawing.Point(12, 553);
			this.btnBuscarfecha.Name = "btnBuscarfecha";
			this.btnBuscarfecha.Size = new System.Drawing.Size(217, 68);
			this.btnBuscarfecha.TabIndex = 52;
			this.btnBuscarfecha.Text = "Buscar";
			this.btnBuscarfecha.UseVisualStyleBackColor = true;
			this.btnBuscarfecha.Click += new System.EventHandler(this.btnBuscarfecha_Click);
			// 
			// Informes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1219, 633);
			this.Controls.Add(this.btnBuscarfecha);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.FechaDesde);
			this.Controls.Add(this.FechaHasta);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.numrecaudacion);
			this.Controls.Add(this.Btnmasrecaudacion);
			this.Controls.Add(this.NumProdven);
			this.Controls.Add(this.btnProdvendido);
			this.Controls.Add(this.NumeroTopemp);
			this.Controls.Add(this.btnBuscarEmpleadomasventas);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtStock);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.BtnBuscarArt);
			this.Name = "Informes";
			this.Text = "Informes";
			this.Load += new System.EventHandler(this.Informes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumeroTopemp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumProdven)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numrecaudacion)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscarArt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarEmpleadomasventas;
        private System.Windows.Forms.NumericUpDown NumeroTopemp;
        private System.Windows.Forms.Button btnProdvendido;
        private System.Windows.Forms.NumericUpDown NumProdven;
        private System.Windows.Forms.NumericUpDown numrecaudacion;
        private System.Windows.Forms.Button Btnmasrecaudacion;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker FechaHasta;
        private System.Windows.Forms.Label FechaDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdCompra;
        private System.Windows.Forms.RadioButton rdVenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarfecha;
    }
}