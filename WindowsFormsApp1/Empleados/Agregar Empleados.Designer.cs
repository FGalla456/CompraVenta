namespace WindowsFormsApp1
{
    partial class agregar_empleado
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
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtIdEmpleado = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.txtSueldo = new System.Windows.Forms.TextBox();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.txtDirec = new System.Windows.Forms.TextBox();
			this.btn_aceptar = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(398, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Apellido:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "ID Empleado:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(604, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Teléfono:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(544, 86);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Dirección:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(251, 86);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Mail: ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(21, 86);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Sueldo:";
			// 
			// txtIdEmpleado
			// 
			this.txtIdEmpleado.Location = new System.Drawing.Point(89, 31);
			this.txtIdEmpleado.Name = "txtIdEmpleado";
			this.txtIdEmpleado.Size = new System.Drawing.Size(106, 20);
			this.txtIdEmpleado.TabIndex = 7;
			this.txtIdEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdEmpleado_KeyPress);
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(451, 31);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(147, 20);
			this.txtApellido.TabIndex = 8;
			this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(662, 31);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(181, 20);
			this.txtTel.TabIndex = 9;
			this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
			// 
			// txtSueldo
			// 
			this.txtSueldo.Location = new System.Drawing.Point(83, 83);
			this.txtSueldo.Name = "txtSueldo";
			this.txtSueldo.Size = new System.Drawing.Size(142, 20);
			this.txtSueldo.TabIndex = 10;
			this.txtSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldo_KeyPress);
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(309, 83);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(229, 20);
			this.txtMail.TabIndex = 11;
			this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
			// 
			// txtDirec
			// 
			this.txtDirec.Location = new System.Drawing.Point(614, 83);
			this.txtDirec.Name = "txtDirec";
			this.txtDirec.Size = new System.Drawing.Size(229, 20);
			this.txtDirec.TabIndex = 12;
			this.txtDirec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDirec_KeyPress);
			// 
			// btn_aceptar
			// 
			this.btn_aceptar.Location = new System.Drawing.Point(363, 118);
			this.btn_aceptar.Name = "btn_aceptar";
			this.btn_aceptar.Size = new System.Drawing.Size(166, 34);
			this.btn_aceptar.TabIndex = 13;
			this.btn_aceptar.Text = "Aceptar";
			this.btn_aceptar.UseVisualStyleBackColor = true;
			this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(254, 31);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(138, 20);
			this.txtNombre.TabIndex = 15;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(201, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Nombre:";
			// 
			// agregar_empleado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(881, 154);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_aceptar);
			this.Controls.Add(this.txtDirec);
			this.Controls.Add(this.txtMail);
			this.Controls.Add(this.txtSueldo);
			this.Controls.Add(this.txtTel);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtIdEmpleado);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "agregar_empleado";
			this.Text = "Agregar Empleado";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.Button btn_aceptar;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label2;
	}
}