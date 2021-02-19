namespace WindowsFormsApp1
{
    partial class actualizar_clientes
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
			this.txtCUIT = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnbuscar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_aceptar = new System.Windows.Forms.Button();
			this.txtDirec = new System.Windows.Forms.TextBox();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnprod = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtCUIT
			// 
			this.txtCUIT.Location = new System.Drawing.Point(112, 60);
			this.txtCUIT.Name = "txtCUIT";
			this.txtCUIT.Size = new System.Drawing.Size(106, 20);
			this.txtCUIT.TabIndex = 43;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(71, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 51;
			this.label3.Text = "CUIT:";
			// 
			// btnbuscar
			// 
			this.btnbuscar.Location = new System.Drawing.Point(112, 91);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(144, 34);
			this.btnbuscar.TabIndex = 53;
			this.btnbuscar.Text = "Buscar Cliente";
			this.btnbuscar.UseVisualStyleBackColor = true;
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtApellido);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btn_aceptar);
			this.groupBox1.Controls.Add(this.txtDirec);
			this.groupBox1.Controls.Add(this.txtMail);
			this.groupBox1.Controls.Add(this.txtTel);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(301, 23);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(702, 153);
			this.groupBox1.TabIndex = 54;
			this.groupBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(5, 68);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 13);
			this.label6.TabIndex = 63;
			this.label6.Text = "Mail:";
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(280, 19);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(163, 20);
			this.txtApellido.TabIndex = 62;
			this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(227, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 61;
			this.label2.Text = "Apellido:";
			// 
			// btn_aceptar
			// 
			this.btn_aceptar.Location = new System.Drawing.Point(262, 100);
			this.btn_aceptar.Name = "btn_aceptar";
			this.btn_aceptar.Size = new System.Drawing.Size(166, 34);
			this.btn_aceptar.TabIndex = 60;
			this.btn_aceptar.Text = "Aceptar";
			this.btn_aceptar.UseVisualStyleBackColor = true;
			this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
			// 
			// txtDirec
			// 
			this.txtDirec.Location = new System.Drawing.Point(404, 68);
			this.txtDirec.Name = "txtDirec";
			this.txtDirec.Size = new System.Drawing.Size(298, 20);
			this.txtDirec.TabIndex = 59;
			this.txtDirec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDirec_KeyPress);
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(58, 65);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(247, 20);
			this.txtMail.TabIndex = 58;
			this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(507, 19);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(185, 20);
			this.txtTel.TabIndex = 57;
			this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(58, 19);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(163, 20);
			this.txtNombre.TabIndex = 56;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(311, 68);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 55;
			this.label5.Text = "Dirección:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(449, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 54;
			this.label4.Text = "Teléfono:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 53;
			this.label1.Text = "Nombre:";
			// 
			// btnprod
			// 
			this.btnprod.Image = global::WindowsFormsApp1.Properties.Resources._0404_09_search_LCl_icon;
			this.btnprod.Location = new System.Drawing.Point(224, 53);
			this.btnprod.Name = "btnprod";
			this.btnprod.Size = new System.Drawing.Size(32, 32);
			this.btnprod.TabIndex = 55;
			this.btnprod.UseVisualStyleBackColor = true;
			this.btnprod.Click += new System.EventHandler(this.btnprod_Click);
			// 
			// actualizar_clientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1032, 190);
			this.Controls.Add(this.btnprod);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCUIT);
			this.Name = "actualizar_clientes";
			this.Text = "Actualizar Cliente";
			this.Load += new System.EventHandler(this.actualizar_clientes_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnprod;
    }
}