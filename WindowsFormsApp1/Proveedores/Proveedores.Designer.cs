namespace WindowsFormsApp1
{
    partial class Proveedores
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
			this.btneliminarprov = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btFiltrar = new System.Windows.Forms.Button();
			this.txtProv = new System.Windows.Forms.TextBox();
			this.txtCuit = new System.Windows.Forms.TextBox();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.actualizarprov = new System.Windows.Forms.Button();
			this.Grilla = new System.Windows.Forms.DataGridView();
			this.cbProv = new System.Windows.Forms.ComboBox();
			this.cbCuit = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_agregar
			// 
			this.btn_agregar.Location = new System.Drawing.Point(16, 503);
			this.btn_agregar.Name = "btn_agregar";
			this.btn_agregar.Size = new System.Drawing.Size(219, 91);
			this.btn_agregar.TabIndex = 1;
			this.btn_agregar.Text = "Agregar Proveedor";
			this.btn_agregar.UseVisualStyleBackColor = true;
			this.btn_agregar.Click += new System.EventHandler(this.button1_Click);
			// 
			// btneliminarprov
			// 
			this.btneliminarprov.Location = new System.Drawing.Point(870, 503);
			this.btneliminarprov.Name = "btneliminarprov";
			this.btneliminarprov.Size = new System.Drawing.Size(223, 91);
			this.btneliminarprov.TabIndex = 2;
			this.btneliminarprov.Text = "Eliminar Proveedor";
			this.btneliminarprov.UseVisualStyleBackColor = true;
			this.btneliminarprov.Click += new System.EventHandler(this.btneliminarprov_Click);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(72, 437);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(163, 20);
			this.txtNombre.TabIndex = 3;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 440);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Nombre:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(241, 440);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "ID Proveedor:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(488, 441);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "CUIT:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(693, 441);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Telefóno:";
			// 
			// btFiltrar
			// 
			this.btFiltrar.Location = new System.Drawing.Point(948, 415);
			this.btFiltrar.Name = "btFiltrar";
			this.btFiltrar.Size = new System.Drawing.Size(145, 62);
			this.btFiltrar.TabIndex = 8;
			this.btFiltrar.Text = "Filtrar";
			this.btFiltrar.UseVisualStyleBackColor = true;
			this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
			// 
			// txtProv
			// 
			this.txtProv.Location = new System.Drawing.Point(392, 438);
			this.txtProv.Name = "txtProv";
			this.txtProv.Size = new System.Drawing.Size(90, 20);
			this.txtProv.TabIndex = 9;
			this.txtProv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProv_KeyPress);
			// 
			// txtCuit
			// 
			this.txtCuit.Location = new System.Drawing.Point(600, 437);
			this.txtCuit.Name = "txtCuit";
			this.txtCuit.Size = new System.Drawing.Size(87, 20);
			this.txtCuit.TabIndex = 10;
			this.txtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUIT_KeyPress);
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(751, 437);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(184, 20);
			this.txtTel.TabIndex = 11;
			this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
			// 
			// label5
			// 
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Location = new System.Drawing.Point(12, 480);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(1085, 1);
			this.label5.TabIndex = 12;
			// 
			// actualizarprov
			// 
			this.actualizarprov.Location = new System.Drawing.Point(457, 503);
			this.actualizarprov.Name = "actualizarprov";
			this.actualizarprov.Size = new System.Drawing.Size(219, 91);
			this.actualizarprov.TabIndex = 13;
			this.actualizarprov.Text = "Actualizar Datos ";
			this.actualizarprov.UseVisualStyleBackColor = true;
			this.actualizarprov.Click += new System.EventHandler(this.actualizarprov_Click);
			// 
			// Grilla
			// 
			this.Grilla.AllowUserToAddRows = false;
			this.Grilla.AllowUserToDeleteRows = false;
			this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grilla.Location = new System.Drawing.Point(13, 13);
			this.Grilla.Name = "Grilla";
			this.Grilla.ReadOnly = true;
			this.Grilla.Size = new System.Drawing.Size(1084, 396);
			this.Grilla.TabIndex = 14;
			// 
			// cbProv
			// 
			this.cbProv.FormattingEnabled = true;
			this.cbProv.Location = new System.Drawing.Point(320, 438);
			this.cbProv.Name = "cbProv";
			this.cbProv.Size = new System.Drawing.Size(66, 21);
			this.cbProv.TabIndex = 15;
			this.cbProv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
			// 
			// cbCuit
			// 
			this.cbCuit.FormattingEnabled = true;
			this.cbCuit.Location = new System.Drawing.Point(529, 437);
			this.cbCuit.Name = "cbCuit";
			this.cbCuit.Size = new System.Drawing.Size(65, 21);
			this.cbCuit.TabIndex = 16;
			this.cbCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
			// 
			// Proveedores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1105, 606);
			this.Controls.Add(this.cbCuit);
			this.Controls.Add(this.cbProv);
			this.Controls.Add(this.Grilla);
			this.Controls.Add(this.actualizarprov);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtTel);
			this.Controls.Add(this.txtCuit);
			this.Controls.Add(this.txtProv);
			this.Controls.Add(this.btFiltrar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.btneliminarprov);
			this.Controls.Add(this.btn_agregar);
			this.Name = "Proveedores";
			this.Text = "Proveedores";
			this.Load += new System.EventHandler(this.Proveedores_Load);
			((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btneliminarprov;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.TextBox txtProv;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button actualizarprov;
		private System.Windows.Forms.DataGridView Grilla;
		private System.Windows.Forms.ComboBox cbProv;
		private System.Windows.Forms.ComboBox cbCuit;
	}
}