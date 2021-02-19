namespace WindowsFormsApp1
{
	partial class Nueva_Venta
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
			this.label10 = new System.Windows.Forms.Label();
			this.txtDescuento = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtIdCli = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.cbTipo = new System.Windows.Forms.ComboBox();
			this.cbMetodoPago = new System.Windows.Forms.ComboBox();
			this.txtFactura = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtInteres = new System.Windows.Forms.TextBox();
			this.btn_aceptar = new System.Windows.Forms.Button();
			this.txtEmpleado = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.btncli = new System.Windows.Forms.Button();
			this.btnemp = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(575, 19);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(42, 13);
			this.label10.TabIndex = 85;
			this.label10.Text = "Interes:";
			// 
			// txtDescuento
			// 
			this.txtDescuento.Location = new System.Drawing.Point(613, 67);
			this.txtDescuento.Name = "txtDescuento";
			this.txtDescuento.Size = new System.Drawing.Size(100, 20);
			this.txtDescuento.TabIndex = 84;
			this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(555, 69);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(62, 13);
			this.label9.TabIndex = 83;
			this.label9.Text = "Descuento:";
			// 
			// txtIdCli
			// 
			this.txtIdCli.Location = new System.Drawing.Point(192, 64);
			this.txtIdCli.Name = "txtIdCli";
			this.txtIdCli.Size = new System.Drawing.Size(85, 20);
			this.txtIdCli.TabIndex = 78;
			this.txtIdCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCli_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(193, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 13);
			this.label6.TabIndex = 77;
			this.label6.Text = "CUIT Cliente";
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(55, 64);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(95, 20);
			this.dtpFecha.TabIndex = 76;
			// 
			// cbTipo
			// 
			this.cbTipo.FormattingEnabled = true;
			this.cbTipo.Location = new System.Drawing.Point(481, 14);
			this.cbTipo.Name = "cbTipo";
			this.cbTipo.Size = new System.Drawing.Size(52, 21);
			this.cbTipo.TabIndex = 73;
			this.cbTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTipo_KeyPress);
			// 
			// cbMetodoPago
			// 
			this.cbMetodoPago.FormattingEnabled = true;
			this.cbMetodoPago.Location = new System.Drawing.Point(293, 14);
			this.cbMetodoPago.Name = "cbMetodoPago";
			this.cbMetodoPago.Size = new System.Drawing.Size(106, 21);
			this.cbMetodoPago.TabIndex = 72;
			this.cbMetodoPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMetodoPago_KeyPress);
			// 
			// txtFactura
			// 
			this.txtFactura.Location = new System.Drawing.Point(69, 19);
			this.txtFactura.Name = "txtFactura";
			this.txtFactura.Size = new System.Drawing.Size(100, 20);
			this.txtFactura.TabIndex = 71;
			this.txtFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFactura_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(198, 17);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 13);
			this.label4.TabIndex = 70;
			this.label4.Text = "Metodo de Pago:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(424, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 69;
			this.label3.Text = "Tipo: ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 70);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 68;
			this.label7.Text = "Fecha:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(2, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 67;
			this.label1.Text = "Nº Factura:";
			// 
			// txtInteres
			// 
			this.txtInteres.Location = new System.Drawing.Point(613, 15);
			this.txtInteres.Name = "txtInteres";
			this.txtInteres.Size = new System.Drawing.Size(100, 20);
			this.txtInteres.TabIndex = 86;
			this.txtInteres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInteres_KeyPress);
			// 
			// btn_aceptar
			// 
			this.btn_aceptar.Location = new System.Drawing.Point(293, 96);
			this.btn_aceptar.Name = "btn_aceptar";
			this.btn_aceptar.Size = new System.Drawing.Size(166, 34);
			this.btn_aceptar.TabIndex = 87;
			this.btn_aceptar.Text = "Aceptar";
			this.btn_aceptar.UseVisualStyleBackColor = true;
			this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
			// 
			// txtEmpleado
			// 
			this.txtEmpleado.Location = new System.Drawing.Point(396, 64);
			this.txtEmpleado.Name = "txtEmpleado";
			this.txtEmpleado.Size = new System.Drawing.Size(100, 20);
			this.txtEmpleado.TabIndex = 89;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(408, 48);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(71, 13);
			this.label11.TabIndex = 88;
			this.label11.Text = "ID Empleado:";
			// 
			// btncli
			// 
			this.btncli.Image = global::WindowsFormsApp1.Properties.Resources._0404_09_search_LCl_icon;
			this.btncli.Location = new System.Drawing.Point(278, 54);
			this.btncli.Name = "btncli";
			this.btncli.Size = new System.Drawing.Size(35, 33);
			this.btncli.TabIndex = 90;
			this.btncli.UseVisualStyleBackColor = true;
			this.btncli.Click += new System.EventHandler(this.btncli_Click);
			// 
			// btnemp
			// 
			this.btnemp.Image = global::WindowsFormsApp1.Properties.Resources._0404_09_search_LCl_icon;
			this.btnemp.Location = new System.Drawing.Point(498, 51);
			this.btnemp.Name = "btnemp";
			this.btnemp.Size = new System.Drawing.Size(35, 33);
			this.btnemp.TabIndex = 91;
			this.btnemp.UseVisualStyleBackColor = true;
			this.btnemp.Click += new System.EventHandler(this.btnemp_Click);
			// 
			// Nueva_Venta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(725, 142);
			this.Controls.Add(this.btnemp);
			this.Controls.Add(this.btncli);
			this.Controls.Add(this.txtEmpleado);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.btn_aceptar);
			this.Controls.Add(this.txtInteres);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtDescuento);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtIdCli);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.cbTipo);
			this.Controls.Add(this.cbMetodoPago);
			this.Controls.Add(this.txtFactura);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label1);
			this.Name = "Nueva_Venta";
			this.Text = "Agregar Venta";
			this.Load += new System.EventHandler(this.Nueva_Venta_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtDescuento;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtIdCli;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.ComboBox cbTipo;
		private System.Windows.Forms.ComboBox cbMetodoPago;
		private System.Windows.Forms.TextBox txtFactura;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btncli;
        private System.Windows.Forms.Button btnemp;
    }
}