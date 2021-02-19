namespace WindowsFormsApp1
{
    partial class actualizarprov
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
			this.label3 = new System.Windows.Forms.Label();
			this.LbIdProv = new System.Windows.Forms.Label();
			this.txtidpro = new System.Windows.Forms.TextBox();
			this.btnbuscar = new System.Windows.Forms.Button();
			this.gp1 = new System.Windows.Forms.GroupBox();
			this.btn_aceptar = new System.Windows.Forms.Button();
			this.txtDirec = new System.Windows.Forms.TextBox();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.txtCUIT = new System.Windows.Forms.TextBox();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.txtEmpresa = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnprod = new System.Windows.Forms.Button();
			this.gp1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 27;
			this.label3.Text = "ID Proveedor:";
			// 
			// LbIdProv
			// 
			this.LbIdProv.AutoSize = true;
			this.LbIdProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LbIdProv.Location = new System.Drawing.Point(181, 28);
			this.LbIdProv.Name = "LbIdProv";
			this.LbIdProv.Size = new System.Drawing.Size(0, 13);
			this.LbIdProv.TabIndex = 39;
			// 
			// txtidpro
			// 
			this.txtidpro.Location = new System.Drawing.Point(118, 21);
			this.txtidpro.Name = "txtidpro";
			this.txtidpro.Size = new System.Drawing.Size(100, 20);
			this.txtidpro.TabIndex = 41;
			// 
			// btnbuscar
			// 
			this.btnbuscar.Location = new System.Drawing.Point(118, 103);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(75, 23);
			this.btnbuscar.TabIndex = 42;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.UseVisualStyleBackColor = true;
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// gp1
			// 
			this.gp1.Controls.Add(this.btn_aceptar);
			this.gp1.Controls.Add(this.txtDirec);
			this.gp1.Controls.Add(this.txtMail);
			this.gp1.Controls.Add(this.txtCUIT);
			this.gp1.Controls.Add(this.txtTel);
			this.gp1.Controls.Add(this.txtEmpresa);
			this.gp1.Controls.Add(this.label7);
			this.gp1.Controls.Add(this.label6);
			this.gp1.Controls.Add(this.label5);
			this.gp1.Controls.Add(this.label4);
			this.gp1.Controls.Add(this.label1);
			this.gp1.Location = new System.Drawing.Point(224, 12);
			this.gp1.Name = "gp1";
			this.gp1.Size = new System.Drawing.Size(759, 131);
			this.gp1.TabIndex = 43;
			this.gp1.TabStop = false;
			// 
			// btn_aceptar
			// 
			this.btn_aceptar.Location = new System.Drawing.Point(464, 94);
			this.btn_aceptar.Name = "btn_aceptar";
			this.btn_aceptar.Size = new System.Drawing.Size(166, 34);
			this.btn_aceptar.TabIndex = 49;
			this.btn_aceptar.Text = "Aceptar";
			this.btn_aceptar.UseVisualStyleBackColor = true;
			this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click_1);
			// 
			// txtDirec
			// 
			this.txtDirec.Location = new System.Drawing.Point(147, 94);
			this.txtDirec.Name = "txtDirec";
			this.txtDirec.Size = new System.Drawing.Size(229, 20);
			this.txtDirec.TabIndex = 48;
			this.txtDirec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDirec_KeyPress);
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(464, 56);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(166, 20);
			this.txtMail.TabIndex = 47;
			this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
			// 
			// txtCUIT
			// 
			this.txtCUIT.Location = new System.Drawing.Point(147, 56);
			this.txtCUIT.Name = "txtCUIT";
			this.txtCUIT.Size = new System.Drawing.Size(229, 20);
			this.txtCUIT.TabIndex = 46;
			this.txtCUIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUIT_KeyPress_1);
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(464, 13);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(166, 20);
			this.txtTel.TabIndex = 45;
			this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress_1);
			// 
			// txtEmpresa
			// 
			this.txtEmpresa.Location = new System.Drawing.Point(147, 13);
			this.txtEmpresa.Name = "txtEmpresa";
			this.txtEmpresa.Size = new System.Drawing.Size(229, 20);
			this.txtEmpresa.TabIndex = 44;
			this.txtEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpresa_KeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(83, 59);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 13);
			this.label7.TabIndex = 43;
			this.label7.Text = "C.U.I.T:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(411, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 13);
			this.label6.TabIndex = 42;
			this.label6.Text = "Mail:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(83, 97);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 41;
			this.label5.Text = "Dirección:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(400, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 40;
			this.label4.Text = "Teléfono:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(72, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 39;
			this.label1.Text = "Empresa:";
			// 
			// btnprod
			// 
			this.btnprod.Image = global::WindowsFormsApp1.Properties.Resources._0404_09_search_LCl_icon;
			this.btnprod.Location = new System.Drawing.Point(124, 52);
			this.btnprod.Name = "btnprod";
			this.btnprod.Size = new System.Drawing.Size(57, 44);
			this.btnprod.TabIndex = 44;
			this.btnprod.UseVisualStyleBackColor = true;
			this.btnprod.Click += new System.EventHandler(this.btnprod_Click);
			// 
			// actualizarprov
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1037, 149);
			this.Controls.Add(this.btnprod);
			this.Controls.Add(this.gp1);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.txtidpro);
			this.Controls.Add(this.LbIdProv);
			this.Controls.Add(this.label3);
			this.Name = "actualizarprov";
			this.Text = "Actualizar Proveedor";
			this.Load += new System.EventHandler(this.actualizarprov_Load);
			this.gp1.ResumeLayout(false);
			this.gp1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbIdProv;
        private System.Windows.Forms.TextBox txtidpro;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.GroupBox gp1;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnprod;
    }
}