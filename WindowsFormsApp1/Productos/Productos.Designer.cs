namespace WindowsFormsApp1
{
	partial class Productos
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
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cbStock = new System.Windows.Forms.ComboBox();
            this.cbProd = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(316, 471);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 91);
            this.button4.TabIndex = 62;
            this.button4.Text = "Actualizar Datos ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(597, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 91);
            this.button2.TabIndex = 61;
            this.button2.Text = "Eliminar Producto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(13, 471);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(219, 91);
            this.btn_agregar.TabIndex = 60;
            this.btn_agregar.Text = "Agregar Producto";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(708, 388);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(112, 58);
            this.btFiltrar.TabIndex = 59;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(620, 408);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(81, 20);
            this.txtStock.TabIndex = 57;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 56;
            // 
            // cbCat
            // 
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(351, 408);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(106, 21);
            this.cbCat.TabIndex = 54;
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(175, 408);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(74, 20);
            this.txtIdProd.TabIndex = 53;
            this.txtIdProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIddProd_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Categoria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "ID Producto:";
            // 
            // Grilla
            // 
            this.Grilla.AllowUserToAddRows = false;
            this.Grilla.AllowUserToDeleteRows = false;
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Location = new System.Drawing.Point(13, 13);
            this.Grilla.Name = "Grilla";
            this.Grilla.ReadOnly = true;
            this.Grilla.Size = new System.Drawing.Size(807, 369);
            this.Grilla.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Stock:";
            // 
            // cbStock
            // 
            this.cbStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStock.FormattingEnabled = true;
            this.cbStock.Location = new System.Drawing.Point(533, 408);
            this.cbStock.Name = "cbStock";
            this.cbStock.Size = new System.Drawing.Size(81, 21);
            this.cbStock.TabIndex = 68;
            this.cbStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
            // 
            // cbProd
            // 
            this.cbProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProd.FormattingEnabled = true;
            this.cbProd.Location = new System.Drawing.Point(88, 408);
            this.cbProd.Name = "cbProd";
            this.cbProd.Size = new System.Drawing.Size(81, 21);
            this.cbProd.TabIndex = 69;
            this.cbProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 574);
            this.Controls.Add(this.cbProd);
            this.Controls.Add(this.cbStock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btFiltrar);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.txtIdProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grilla);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btn_agregar;
		private System.Windows.Forms.Button btFiltrar;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbCat;
		private System.Windows.Forms.TextBox txtIdProd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView Grilla;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbStock;
		private System.Windows.Forms.ComboBox cbProd;
	}
}