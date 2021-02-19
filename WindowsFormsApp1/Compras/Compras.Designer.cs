namespace WindowsFormsApp1
{
	partial class Compras
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
			this.btn_agregar = new System.Windows.Forms.Button();
			this.btFiltrar = new System.Windows.Forms.Button();
			this.Grilla = new System.Windows.Forms.DataGridView();
			this.btnagregar = new System.Windows.Forms.Button();
			this.btneliminardet = new System.Windows.Forms.Button();
			this.cbFecha = new System.Windows.Forms.ComboBox();
			this.cbBono = new System.Windows.Forms.ComboBox();
			this.txtBono = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbTotal = new System.Windows.Forms.ComboBox();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cbTipo = new System.Windows.Forms.ComboBox();
			this.cbMP = new System.Windows.Forms.ComboBox();
			this.txtFactura = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_agregar
			// 
			this.btn_agregar.Location = new System.Drawing.Point(13, 471);
			this.btn_agregar.Name = "btn_agregar";
			this.btn_agregar.Size = new System.Drawing.Size(219, 91);
			this.btn_agregar.TabIndex = 43;
			this.btn_agregar.Text = "Agregar Compra";
			this.btn_agregar.UseVisualStyleBackColor = true;
			this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
			// 
			// btFiltrar
			// 
			this.btFiltrar.Location = new System.Drawing.Point(986, 388);
			this.btFiltrar.Name = "btFiltrar";
			this.btFiltrar.Size = new System.Drawing.Size(112, 58);
			this.btFiltrar.TabIndex = 42;
			this.btFiltrar.Text = "Filtrar";
			this.btFiltrar.UseVisualStyleBackColor = true;
			this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
			// 
			// Grilla
			// 
			this.Grilla.AllowUserToAddRows = false;
			this.Grilla.AllowUserToDeleteRows = false;
			this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grilla.Location = new System.Drawing.Point(13, 13);
			this.Grilla.Name = "Grilla";
			this.Grilla.Size = new System.Drawing.Size(1085, 369);
			this.Grilla.TabIndex = 31;
			this.Grilla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla_CellDoubleClick);
			// 
			// btnagregar
			// 
			this.btnagregar.Location = new System.Drawing.Point(425, 471);
			this.btnagregar.Name = "btnagregar";
			this.btnagregar.Size = new System.Drawing.Size(219, 91);
			this.btnagregar.TabIndex = 48;
			this.btnagregar.Text = "Agregar Detalle de Compra";
			this.btnagregar.UseVisualStyleBackColor = true;
			this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
			// 
			// btneliminardet
			// 
			this.btneliminardet.Location = new System.Drawing.Point(855, 471);
			this.btneliminardet.Name = "btneliminardet";
			this.btneliminardet.Size = new System.Drawing.Size(219, 91);
			this.btneliminardet.TabIndex = 49;
			this.btneliminardet.Text = "Eliminar Detalle de Compra";
			this.btneliminardet.UseVisualStyleBackColor = true;
			this.btneliminardet.Click += new System.EventHandler(this.btneliminardet_Click);
			// 
			// cbFecha
			// 
			this.cbFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFecha.FormattingEnabled = true;
			this.cbFecha.Location = new System.Drawing.Point(815, 408);
			this.cbFecha.Name = "cbFecha";
			this.cbFecha.Size = new System.Drawing.Size(62, 21);
			this.cbFecha.TabIndex = 64;
			this.cbFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
			// 
			// cbBono
			// 
			this.cbBono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBono.FormattingEnabled = true;
			this.cbBono.Location = new System.Drawing.Point(654, 408);
			this.cbBono.Name = "cbBono";
			this.cbBono.Size = new System.Drawing.Size(62, 21);
			this.cbBono.TabIndex = 63;
			this.cbBono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
			// 
			// txtBono
			// 
			this.txtBono.Location = new System.Drawing.Point(722, 408);
			this.txtBono.Name = "txtBono";
			this.txtBono.Size = new System.Drawing.Size(41, 20);
			this.txtBono.TabIndex = 62;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(614, 411);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 61;
			this.label6.Text = "Bono:";
			// 
			// cbTotal
			// 
			this.cbTotal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTotal.FormattingEnabled = true;
			this.cbTotal.Location = new System.Drawing.Point(453, 408);
			this.cbTotal.Name = "cbTotal";
			this.cbTotal.Size = new System.Drawing.Size(62, 21);
			this.cbTotal.TabIndex = 60;
			this.cbTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(885, 408);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(95, 20);
			this.dtpFecha.TabIndex = 59;
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(521, 408);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(87, 20);
			this.txtTotal.TabIndex = 58;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(413, 411);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 13);
			this.label5.TabIndex = 57;
			this.label5.Text = "Total:";
			// 
			// cbTipo
			// 
			this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTipo.FormattingEnabled = true;
			this.cbTipo.Location = new System.Drawing.Point(373, 408);
			this.cbTipo.Name = "cbTipo";
			this.cbTipo.Size = new System.Drawing.Size(34, 21);
			this.cbTipo.TabIndex = 56;
			this.cbTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
			// 
			// cbMP
			// 
			this.cbMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMP.FormattingEnabled = true;
			this.cbMP.Location = new System.Drawing.Point(238, 408);
			this.cbMP.Name = "cbMP";
			this.cbMP.Size = new System.Drawing.Size(89, 21);
			this.cbMP.TabIndex = 55;
			this.cbMP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
			// 
			// txtFactura
			// 
			this.txtFactura.Location = new System.Drawing.Point(79, 408);
			this.txtFactura.Name = "txtFactura";
			this.txtFactura.Size = new System.Drawing.Size(55, 20);
			this.txtFactura.TabIndex = 54;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(143, 411);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 13);
			this.label4.TabIndex = 53;
			this.label4.Text = "Metodo de Pago:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(333, 411);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 52;
			this.label3.Text = "Tipo: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(769, 411);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 51;
			this.label2.Text = "Fecha:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 411);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 50;
			this.label1.Text = "Nº Factura:";
			// 
			// Compras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1110, 574);
			this.Controls.Add(this.cbFecha);
			this.Controls.Add(this.cbBono);
			this.Controls.Add(this.txtBono);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cbTotal);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cbTipo);
			this.Controls.Add(this.cbMP);
			this.Controls.Add(this.txtFactura);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btneliminardet);
			this.Controls.Add(this.btnagregar);
			this.Controls.Add(this.btn_agregar);
			this.Controls.Add(this.btFiltrar);
			this.Controls.Add(this.Grilla);
			this.Name = "Compras";
			this.Text = "Compras";
			this.Load += new System.EventHandler(this.Compras_Load);
			((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btn_agregar;
		private System.Windows.Forms.Button btFiltrar;
		private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneliminardet;
		private System.Windows.Forms.ComboBox cbFecha;
		private System.Windows.Forms.ComboBox cbBono;
		private System.Windows.Forms.TextBox txtBono;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbTotal;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbTipo;
		private System.Windows.Forms.ComboBox cbMP;
		private System.Windows.Forms.TextBox txtFactura;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}