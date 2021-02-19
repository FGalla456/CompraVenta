namespace WindowsFormsApp1
{
    partial class AGREGARCLIENTES
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
			this.txtDirec = new System.Windows.Forms.TextBox();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtCUIT = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_aceptar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtDirec
			// 
			this.txtDirec.Location = new System.Drawing.Point(530, 66);
			this.txtDirec.Name = "txtDirec";
			this.txtDirec.Size = new System.Drawing.Size(298, 20);
			this.txtDirec.TabIndex = 36;
			this.txtDirec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDirec_KeyPress);
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(92, 66);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(332, 20);
			this.txtMail.TabIndex = 35;
			this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(680, 16);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(185, 20);
			this.txtTel.TabIndex = 33;
			this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(231, 16);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(163, 20);
			this.txtNombre.TabIndex = 32;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
			// 
			// txtCUIT
			// 
			this.txtCUIT.Location = new System.Drawing.Point(66, 16);
			this.txtCUIT.Name = "txtCUIT";
			this.txtCUIT.Size = new System.Drawing.Size(106, 20);
			this.txtCUIT.TabIndex = 31;
			this.txtCUIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUIT_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(49, 69);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 13);
			this.label6.TabIndex = 29;
			this.label6.Text = "Mail:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(449, 69);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 28;
			this.label5.Text = "Dirección:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(622, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 27;
			this.label4.Text = "Teléfono:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 26;
			this.label3.Text = "CUIT:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(178, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 25;
			this.label1.Text = "Nombre:";
			// 
			// btn_aceptar
			// 
			this.btn_aceptar.Location = new System.Drawing.Point(359, 92);
			this.btn_aceptar.Name = "btn_aceptar";
			this.btn_aceptar.Size = new System.Drawing.Size(166, 34);
			this.btn_aceptar.TabIndex = 37;
			this.btn_aceptar.Text = "Aceptar";
			this.btn_aceptar.UseVisualStyleBackColor = true;
			this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(400, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 38;
			this.label2.Text = "Apellido:";
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(453, 16);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(163, 20);
			this.txtApellido.TabIndex = 39;
			this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
			// 
			// AGREGARCLIENTES
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(877, 135);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_aceptar);
			this.Controls.Add(this.txtDirec);
			this.Controls.Add(this.txtMail);
			this.Controls.Add(this.txtTel);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtCUIT);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "AGREGARCLIENTES";
			this.Text = "Agregar Clientes";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_aceptar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtApellido;
	}
}