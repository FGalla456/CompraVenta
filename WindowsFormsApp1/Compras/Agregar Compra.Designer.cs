namespace WindowsFormsApp1
{
	partial class Nueva_Compra
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
            this.txtIdProv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbMetodoPago = new System.Windows.Forms.ComboBox();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btnprod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIdProv
            // 
            this.txtIdProv.Location = new System.Drawing.Point(284, 81);
            this.txtIdProv.Name = "txtIdProv";
            this.txtIdProv.Size = new System.Drawing.Size(106, 20);
            this.txtIdProv.TabIndex = 59;
            this.txtIdProv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProv_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "ID Proveedor:";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(459, 37);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(52, 21);
            this.cbTipo.TabIndex = 54;
            this.cbTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTipo_KeyPress);
            // 
            // cbMetodoPago
            // 
            this.cbMetodoPago.FormattingEnabled = true;
            this.cbMetodoPago.Location = new System.Drawing.Point(274, 38);
            this.cbMetodoPago.Name = "cbMetodoPago";
            this.cbMetodoPago.Size = new System.Drawing.Size(106, 21);
            this.cbMetodoPago.TabIndex = 53;
            this.cbMetodoPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMetodoPago_KeyPress);
            // 
            // txtFactura
            // 
            this.txtFactura.Enabled = false;
            this.txtFactura.Location = new System.Drawing.Point(73, 38);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(100, 20);
            this.txtFactura.TabIndex = 52;
            this.txtFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFactura_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Metodo de Pago:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tipo: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nº Factura:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(78, 78);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(95, 20);
            this.dtpFecha.TabIndex = 57;
            this.dtpFecha.Value = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(585, 81);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 65;
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(517, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Descuento:";
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(585, 41);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(100, 20);
            this.txtInteres.TabIndex = 67;
            this.txtInteres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInteres_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(527, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "Interes:";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(270, 114);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(166, 34);
            this.btn_aceptar.TabIndex = 68;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btnprod
            // 
            this.btnprod.Image = global::WindowsFormsApp1.Properties.Resources._0404_09_search_LCl_icon;
            this.btnprod.Location = new System.Drawing.Point(396, 68);
            this.btnprod.Name = "btnprod";
            this.btnprod.Size = new System.Drawing.Size(40, 40);
            this.btnprod.TabIndex = 69;
            this.btnprod.UseVisualStyleBackColor = true;
            this.btnprod.Click += new System.EventHandler(this.btnprod_Click);
            // 
            // Nueva_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 160);
            this.Controls.Add(this.btnprod);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdProv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.cbMetodoPago);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Nueva_Compra";
            this.Text = "Agregar Compra";
            this.Load += new System.EventHandler(this.Nueva_Compra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtIdProv;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbTipo;
		private System.Windows.Forms.ComboBox cbMetodoPago;
		private System.Windows.Forms.TextBox txtFactura;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.TextBox txtDescuento;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtInteres;
		private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btnprod;
    }
}