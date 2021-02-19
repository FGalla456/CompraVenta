namespace WindowsFormsApp1
{
    partial class actualizar_empleados
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
			this.gp1 = new System.Windows.Forms.GroupBox();
			this.txtsueldo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_aceptar = new System.Windows.Forms.Button();
			this.txtDirec = new System.Windows.Forms.TextBox();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnbuscar = new System.Windows.Forms.Button();
			this.txtidemp = new System.Windows.Forms.TextBox();
			this.LbIdProv = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnprod = new System.Windows.Forms.Button();
			this.gp1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gp1
			// 
			this.gp1.Controls.Add(this.txtsueldo);
			this.gp1.Controls.Add(this.label2);
			this.gp1.Controls.Add(this.btn_aceptar);
			this.gp1.Controls.Add(this.txtDirec);
			this.gp1.Controls.Add(this.txtMail);
			this.gp1.Controls.Add(this.txtApellido);
			this.gp1.Controls.Add(this.txtTel);
			this.gp1.Controls.Add(this.label4);
			this.gp1.Controls.Add(this.txtNombre);
			this.gp1.Controls.Add(this.label7);
			this.gp1.Controls.Add(this.label6);
			this.gp1.Controls.Add(this.label5);
			this.gp1.Controls.Add(this.label1);
			this.gp1.Location = new System.Drawing.Point(282, 14);
			this.gp1.Name = "gp1";
			this.gp1.Size = new System.Drawing.Size(844, 131);
			this.gp1.TabIndex = 49;
			this.gp1.TabStop = false;
			// 
			// txtsueldo
			// 
			this.txtsueldo.Location = new System.Drawing.Point(464, 94);
			this.txtsueldo.Name = "txtsueldo";
			this.txtsueldo.Size = new System.Drawing.Size(166, 20);
			this.txtsueldo.TabIndex = 51;
			this.txtsueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsueldo_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(411, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 50;
			this.label2.Text = "Sueldo:";
			// 
			// btn_aceptar
			// 
			this.btn_aceptar.Location = new System.Drawing.Point(672, 13);
			this.btn_aceptar.Name = "btn_aceptar";
			this.btn_aceptar.Size = new System.Drawing.Size(143, 101);
			this.btn_aceptar.TabIndex = 49;
			this.btn_aceptar.Text = "Aceptar";
			this.btn_aceptar.UseVisualStyleBackColor = true;
			this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
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
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(464, 13);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(166, 20);
			this.txtApellido.TabIndex = 46;
			this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(147, 53);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(229, 20);
			this.txtTel.TabIndex = 45;
			this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(83, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 40;
			this.label4.Text = "Teléfono:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(147, 13);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(229, 20);
			this.txtNombre.TabIndex = 44;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(410, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 13);
			this.label7.TabIndex = 43;
			this.label7.Text = "Apellido:";
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(83, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 39;
			this.label1.Text = "Nombre:";
			// 
			// btnbuscar
			// 
			this.btnbuscar.Location = new System.Drawing.Point(158, 111);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(75, 23);
			this.btnbuscar.TabIndex = 48;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.UseVisualStyleBackColor = true;
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// txtidemp
			// 
			this.txtidemp.Location = new System.Drawing.Point(149, 33);
			this.txtidemp.Name = "txtidemp";
			this.txtidemp.Size = new System.Drawing.Size(100, 20);
			this.txtidemp.TabIndex = 47;
			// 
			// LbIdProv
			// 
			this.LbIdProv.AutoSize = true;
			this.LbIdProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LbIdProv.Location = new System.Drawing.Point(233, 40);
			this.LbIdProv.Name = "LbIdProv";
			this.LbIdProv.Size = new System.Drawing.Size(0, 13);
			this.LbIdProv.TabIndex = 45;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(70, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 44;
			this.label3.Text = "ID Empleado:";
			// 
			// btnprod
			// 
			this.btnprod.Image = global::WindowsFormsApp1.Properties.Resources._0404_09_search_LCl_icon;
			this.btnprod.Location = new System.Drawing.Point(167, 59);
			this.btnprod.Name = "btnprod";
			this.btnprod.Size = new System.Drawing.Size(57, 44);
			this.btnprod.TabIndex = 50;
			this.btnprod.UseVisualStyleBackColor = true;
			this.btnprod.Click += new System.EventHandler(this.btnprod_Click);
			// 
			// actualizar_empleados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1159, 157);
			this.Controls.Add(this.btnprod);
			this.Controls.Add(this.gp1);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.txtidemp);
			this.Controls.Add(this.LbIdProv);
			this.Controls.Add(this.label3);
			this.Name = "actualizar_empleados";
			this.Text = "Actualizar Empleado";
			this.Load += new System.EventHandler(this.actualizar_empleados_Load);
			this.gp1.ResumeLayout(false);
			this.gp1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gp1;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtidemp;
        private System.Windows.Forms.Label LbIdProv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsueldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnprod;
    }
}