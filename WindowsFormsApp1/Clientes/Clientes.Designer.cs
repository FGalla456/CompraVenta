namespace WindowsFormsApp1
{
    partial class Clientes
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
			this.label5 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.btn_agregar = new System.Windows.Forms.Button();
			this.Grilla = new System.Windows.Forms.DataGridView();
			this.cbCuit = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.cbCC = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCC = new System.Windows.Forms.TextBox();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.txtCUIT = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
			this.SuspendLayout();
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(459, 497);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(219, 91);
			this.button4.TabIndex = 27;
			this.button4.Text = "Actualizar Datos ";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label5
			// 
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Location = new System.Drawing.Point(14, 474);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(1085, 1);
			this.label5.TabIndex = 26;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(955, 409);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(140, 62);
			this.button3.TabIndex = 22;
			this.button3.Text = "Filtrar";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(497, 435);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 13);
			this.label3.TabIndex = 20;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(872, 497);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(223, 91);
			this.button2.TabIndex = 16;
			this.button2.Text = "Eliminar Cliente";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btn_agregar
			// 
			this.btn_agregar.Location = new System.Drawing.Point(18, 497);
			this.btn_agregar.Name = "btn_agregar";
			this.btn_agregar.Size = new System.Drawing.Size(219, 91);
			this.btn_agregar.TabIndex = 15;
			this.btn_agregar.Text = "Agregar Clientes";
			this.btn_agregar.UseVisualStyleBackColor = true;
			this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
			// 
			// Grilla
			// 
			this.Grilla.AllowUserToAddRows = false;
			this.Grilla.AllowUserToDeleteRows = false;
			this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grilla.Location = new System.Drawing.Point(10, 22);
			this.Grilla.Name = "Grilla";
			this.Grilla.ReadOnly = true;
			this.Grilla.Size = new System.Drawing.Size(1090, 381);
			this.Grilla.TabIndex = 30;
			// 
			// cbCuit
			// 
			this.cbCuit.FormattingEnabled = true;
			this.cbCuit.Location = new System.Drawing.Point(346, 431);
			this.cbCuit.Name = "cbCuit";
			this.cbCuit.Size = new System.Drawing.Size(68, 21);
			this.cbCuit.TabIndex = 45;
			this.cbCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(166, 434);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 13);
			this.label7.TabIndex = 44;
			this.label7.Text = "Apellido:";
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(219, 431);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(80, 20);
			this.txtApellido.TabIndex = 43;
			// 
			// cbCC
			// 
			this.cbCC.FormattingEnabled = true;
			this.cbCC.Location = new System.Drawing.Point(810, 430);
			this.cbCC.Name = "cbCC";
			this.cbCC.Size = new System.Drawing.Size(68, 21);
			this.cbCC.TabIndex = 42;
			this.cbCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(515, 434);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 13);
			this.label6.TabIndex = 41;
			this.label6.Text = "Teléfono:";
			// 
			// txtCC
			// 
			this.txtCC.Location = new System.Drawing.Point(884, 431);
			this.txtCC.Name = "txtCC";
			this.txtCC.Size = new System.Drawing.Size(65, 20);
			this.txtCC.TabIndex = 40;
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(573, 431);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(115, 20);
			this.txtTel.TabIndex = 39;
			// 
			// txtCUIT
			// 
			this.txtCUIT.Location = new System.Drawing.Point(420, 431);
			this.txtCUIT.Name = "txtCUIT";
			this.txtCUIT.Size = new System.Drawing.Size(89, 20);
			this.txtCUIT.TabIndex = 38;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(694, 434);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 13);
			this.label4.TabIndex = 37;
			this.label4.Text = "Cantidad de Compras:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(305, 434);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 36;
			this.label2.Text = "CUIT:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 434);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 35;
			this.label1.Text = "Nombre:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(60, 431);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 20);
			this.txtNombre.TabIndex = 34;
			// 
			// Clientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1112, 610);
			this.Controls.Add(this.cbCuit);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.cbCC);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtCC);
			this.Controls.Add(this.txtTel);
			this.Controls.Add(this.txtCUIT);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.Grilla);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btn_agregar);
			this.Name = "Clientes";
			this.Text = "Clientes";
			this.Load += new System.EventHandler(this.clientes_Load);
			((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_agregar;
		private System.Windows.Forms.DataGridView Grilla;
		private System.Windows.Forms.ComboBox cbCuit;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.ComboBox cbCC;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCC;
		private System.Windows.Forms.TextBox txtTel;
		private System.Windows.Forms.TextBox txtCUIT;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombre;
	}
}