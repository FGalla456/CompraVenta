namespace WindowsFormsApp1
{
	partial class Agregar_Producto
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
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtIdProd = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.cbCat = new System.Windows.Forms.ComboBox();
			this.btn_aceptar = new System.Windows.Forms.Button();
			this.txtprecio = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(63, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID Producto:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(313, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nombre:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(621, 25);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "ID Categoria:";
			// 
			// txtIdProd
			// 
			this.txtIdProd.Location = new System.Drawing.Point(137, 25);
			this.txtIdProd.Name = "txtIdProd";
			this.txtIdProd.Size = new System.Drawing.Size(153, 20);
			this.txtIdProd.TabIndex = 6;
			this.txtIdProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProd_KeyPress);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(388, 22);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(186, 20);
			this.txtNombre.TabIndex = 8;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
			// 
			// cbCat
			// 
			this.cbCat.FormattingEnabled = true;
			this.cbCat.Location = new System.Drawing.Point(710, 21);
			this.cbCat.Name = "cbCat";
			this.cbCat.Size = new System.Drawing.Size(186, 21);
			this.cbCat.TabIndex = 11;
			this.cbCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCat_KeyPress);
			// 
			// btn_aceptar
			// 
			this.btn_aceptar.Location = new System.Drawing.Point(524, 48);
			this.btn_aceptar.Name = "btn_aceptar";
			this.btn_aceptar.Size = new System.Drawing.Size(166, 34);
			this.btn_aceptar.TabIndex = 12;
			this.btn_aceptar.Text = "Aceptar";
			this.btn_aceptar.UseVisualStyleBackColor = true;
			this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
			// 
			// txtprecio
			// 
			this.txtprecio.Location = new System.Drawing.Point(1007, 22);
			this.txtprecio.Name = "txtprecio";
			this.txtprecio.Size = new System.Drawing.Size(126, 20);
			this.txtprecio.TabIndex = 13;
			this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(927, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Precio Unitario:";
			// 
			// Agregar_Producto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1152, 94);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtprecio);
			this.Controls.Add(this.btn_aceptar);
			this.Controls.Add(this.cbCat);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtIdProd);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "Agregar_Producto";
			this.Text = "Agregar Producto";
			this.Load += new System.EventHandler(this.Agregar_Producto_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtIdProd;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label2;
    }
}