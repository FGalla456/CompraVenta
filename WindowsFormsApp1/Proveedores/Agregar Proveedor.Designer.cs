namespace WindowsFormsApp1
{
    partial class agregar_proveedor
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
			this.txtCUIT = new System.Windows.Forms.TextBox();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.txtEmpresa = new System.Windows.Forms.TextBox();
			this.txtIdProv = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_aceptar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtDirec
			// 
			this.txtDirec.Location = new System.Drawing.Point(632, 71);
			this.txtDirec.Name = "txtDirec";
			this.txtDirec.Size = new System.Drawing.Size(229, 20);
			this.txtDirec.TabIndex = 24;
			this.txtDirec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDirec_KeyPress);
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(315, 71);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(229, 20);
			this.txtMail.TabIndex = 23;
			this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
			// 
			// txtCUIT
			// 
			this.txtCUIT.Location = new System.Drawing.Point(89, 71);
			this.txtCUIT.Name = "txtCUIT";
			this.txtCUIT.Size = new System.Drawing.Size(142, 20);
			this.txtCUIT.TabIndex = 22;
			this.txtCUIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUIT_KeyPress);
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(632, 16);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(181, 20);
			this.txtTel.TabIndex = 21;
			this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
			// 
			// txtEmpresa
			// 
			this.txtEmpresa.Location = new System.Drawing.Point(315, 16);
			this.txtEmpresa.Name = "txtEmpresa";
			this.txtEmpresa.Size = new System.Drawing.Size(229, 20);
			this.txtEmpresa.TabIndex = 20;
			this.txtEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpresa_KeyPress);
			// 
			// txtIdProv
			// 
			this.txtIdProv.Location = new System.Drawing.Point(95, 16);
			this.txtIdProv.Name = "txtIdProv";
			this.txtIdProv.Size = new System.Drawing.Size(106, 20);
			this.txtIdProv.TabIndex = 19;
			this.txtIdProv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProv_KeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(25, 74);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 13);
			this.label7.TabIndex = 18;
			this.label7.Text = "C.U.I.T:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(262, 71);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "Mail:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(568, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "Dirección:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(568, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "Teléfono:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "ID Proveedor:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(240, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "Empresa:";
			// 
			// btn_aceptar
			// 
			this.btn_aceptar.Location = new System.Drawing.Point(378, 97);
			this.btn_aceptar.Name = "btn_aceptar";
			this.btn_aceptar.Size = new System.Drawing.Size(166, 34);
			this.btn_aceptar.TabIndex = 25;
			this.btn_aceptar.Text = "Aceptar";
			this.btn_aceptar.UseVisualStyleBackColor = true;
			this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
			// 
			// agregar_proveedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(913, 138);
			this.Controls.Add(this.btn_aceptar);
			this.Controls.Add(this.txtDirec);
			this.Controls.Add(this.txtMail);
			this.Controls.Add(this.txtCUIT);
			this.Controls.Add(this.txtTel);
			this.Controls.Add(this.txtEmpresa);
			this.Controls.Add(this.txtIdProv);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "agregar_proveedor";
			this.Text = "Agregar Proveedor";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtIdProv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_aceptar;
    }
}