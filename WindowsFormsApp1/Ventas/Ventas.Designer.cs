namespace WindowsFormsApp1
{
	partial class Ventas
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
			this.Grilla = new System.Windows.Forms.DataGridView();
			this.btn_filtrar = new System.Windows.Forms.Button();
			this.btn_actualizar = new System.Windows.Forms.Button();
			this.btn_agregar = new System.Windows.Forms.Button();
			this.btnagregardetalle = new System.Windows.Forms.Button();
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
			this.cbFecha = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
			this.SuspendLayout();
			// 
			// Grilla
			// 
			this.Grilla.AllowUserToAddRows = false;
			this.Grilla.AllowUserToDeleteRows = false;
			this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grilla.Location = new System.Drawing.Point(13, 13);
			this.Grilla.Name = "Grilla";
			this.Grilla.ReadOnly = true;
			this.Grilla.Size = new System.Drawing.Size(1085, 369);
			this.Grilla.TabIndex = 0;
			this.Grilla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla_CellDoubleClick);
			// 
			// btn_filtrar
			// 
			this.btn_filtrar.Location = new System.Drawing.Point(986, 388);
			this.btn_filtrar.Name = "btn_filtrar";
			this.btn_filtrar.Size = new System.Drawing.Size(112, 58);
			this.btn_filtrar.TabIndex = 11;
			this.btn_filtrar.Text = "Filtrar";
			this.btn_filtrar.UseVisualStyleBackColor = true;
			this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
			// 
			// btn_actualizar
			// 
			this.btn_actualizar.Location = new System.Drawing.Point(855, 471);
			this.btn_actualizar.Name = "btn_actualizar";
			this.btn_actualizar.Size = new System.Drawing.Size(219, 91);
			this.btn_actualizar.TabIndex = 30;
			this.btn_actualizar.Text = "Eliminar Detalle de Venta";
			this.btn_actualizar.UseVisualStyleBackColor = true;
			this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
			// 
			// btn_agregar
			// 
			this.btn_agregar.Location = new System.Drawing.Point(15, 471);
			this.btn_agregar.Name = "btn_agregar";
			this.btn_agregar.Size = new System.Drawing.Size(219, 91);
			this.btn_agregar.TabIndex = 28;
			this.btn_agregar.Text = "Agregar Venta";
			this.btn_agregar.UseVisualStyleBackColor = true;
			this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
			// 
			// btnagregardetalle
			// 
			this.btnagregardetalle.Location = new System.Drawing.Point(430, 471);
			this.btnagregardetalle.Name = "btnagregardetalle";
			this.btnagregardetalle.Size = new System.Drawing.Size(219, 91);
			this.btnagregardetalle.TabIndex = 31;
			this.btnagregardetalle.Text = "Agregar Detalle de Venta";
			this.btnagregardetalle.UseVisualStyleBackColor = true;
			this.btnagregardetalle.Click += new System.EventHandler(this.btnagregardetalle_Click);
			// 
			// cbBono
			// 
			this.cbBono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBono.FormattingEnabled = true;
			this.cbBono.Location = new System.Drawing.Point(654, 408);
			this.cbBono.Name = "cbBono";
			this.cbBono.Size = new System.Drawing.Size(62, 21);
			this.cbBono.TabIndex = 48;
			this.cbBono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
			// 
			// txtBono
			// 
			this.txtBono.Location = new System.Drawing.Point(722, 408);
			this.txtBono.Name = "txtBono";
			this.txtBono.Size = new System.Drawing.Size(41, 20);
			this.txtBono.TabIndex = 47;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(614, 411);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 46;
			this.label6.Text = "Bono:";
			// 
			// cbTotal
			// 
			this.cbTotal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTotal.FormattingEnabled = true;
			this.cbTotal.Location = new System.Drawing.Point(453, 408);
			this.cbTotal.Name = "cbTotal";
			this.cbTotal.Size = new System.Drawing.Size(62, 21);
			this.cbTotal.TabIndex = 45;
			this.cbTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(885, 408);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(95, 20);
			this.dtpFecha.TabIndex = 44;
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(521, 408);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(87, 20);
			this.txtTotal.TabIndex = 43;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(413, 411);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 13);
			this.label5.TabIndex = 42;
			this.label5.Text = "Total:";
			// 
			// cbTipo
			// 
			this.cbTipo.FormattingEnabled = true;
			this.cbTipo.Location = new System.Drawing.Point(373, 408);
			this.cbTipo.Name = "cbTipo";
			this.cbTipo.Size = new System.Drawing.Size(34, 21);
			this.cbTipo.TabIndex = 41;
			// 
			// cbMP
			// 
			this.cbMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMP.FormattingEnabled = true;
			this.cbMP.Location = new System.Drawing.Point(238, 408);
			this.cbMP.Name = "cbMP";
			this.cbMP.Size = new System.Drawing.Size(89, 21);
			this.cbMP.TabIndex = 40;
			this.cbMP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
			// 
			// txtFactura
			// 
			this.txtFactura.Location = new System.Drawing.Point(79, 408);
			this.txtFactura.Name = "txtFactura";
			this.txtFactura.Size = new System.Drawing.Size(55, 20);
			this.txtFactura.TabIndex = 39;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(143, 411);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 13);
			this.label4.TabIndex = 38;
			this.label4.Text = "Metodo de Pago:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(333, 411);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 37;
			this.label3.Text = "Tipo: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(769, 411);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 36;
			this.label2.Text = "Fecha:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 411);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 35;
			this.label1.Text = "Nº Factura:";
			// 
			// cbFecha
			// 
			this.cbFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFecha.FormattingEnabled = true;
			this.cbFecha.Location = new System.Drawing.Point(815, 408);
			this.cbFecha.Name = "cbFecha";
			this.cbFecha.Size = new System.Drawing.Size(62, 21);
			this.cbFecha.TabIndex = 49;
			this.cbFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
			// 
			// Ventas
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
			this.Controls.Add(this.btnagregardetalle);
			this.Controls.Add(this.btn_actualizar);
			this.Controls.Add(this.btn_agregar);
			this.Controls.Add(this.btn_filtrar);
			this.Controls.Add(this.Grilla);
			this.Name = "Ventas";
			this.Text = "Ventas";
			this.Load += new System.EventHandler(this.Ventas_Load);
			((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView Grilla;
		private System.Windows.Forms.Button btn_filtrar;
		private System.Windows.Forms.Button btn_actualizar;
		private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btnagregardetalle;
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
		private System.Windows.Forms.ComboBox cbFecha;
	}
}