namespace WindowsFormsApp1
{
    partial class Empleados
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
			this.txtSueldo = new System.Windows.Forms.TextBox();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.btFiltrar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.btn_agregar = new System.Windows.Forms.Button();
			this.cbSueldo = new System.Windows.Forms.ComboBox();
			this.Grilla = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.cbIdEm = new System.Windows.Forms.ComboBox();
			this.txtIdEmpleado = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
			this.SuspendLayout();
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(480, 513);
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
			this.label5.Location = new System.Drawing.Point(35, 490);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(1085, 1);
			this.label5.TabIndex = 26;
			// 
			// txtSueldo
			// 
			this.txtSueldo.Location = new System.Drawing.Point(869, 447);
			this.txtSueldo.Name = "txtSueldo";
			this.txtSueldo.Size = new System.Drawing.Size(96, 20);
			this.txtSueldo.TabIndex = 25;
			this.txtSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldo_KeyPress);
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(620, 447);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(109, 20);
			this.txtTel.TabIndex = 24;
			this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdTel_KeyPress);
			// 
			// btFiltrar
			// 
			this.btFiltrar.Location = new System.Drawing.Point(971, 425);
			this.btFiltrar.Name = "btFiltrar";
			this.btFiltrar.Size = new System.Drawing.Size(145, 62);
			this.btFiltrar.TabIndex = 22;
			this.btFiltrar.Text = "Filtrar";
			this.btFiltrar.UseVisualStyleBackColor = true;
			this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(735, 450);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 21;
			this.label4.Text = "Sueldo:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(565, 450);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 20;
			this.label3.Text = "Teléfono:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 450);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 18;
			this.label1.Text = "Nombre:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(65, 447);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(101, 20);
			this.txtNombre.TabIndex = 17;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(893, 513);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(223, 91);
			this.button2.TabIndex = 16;
			this.button2.Text = "Eliminar Empleado";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btn_agregar
			// 
			this.btn_agregar.Location = new System.Drawing.Point(39, 513);
			this.btn_agregar.Name = "btn_agregar";
			this.btn_agregar.Size = new System.Drawing.Size(219, 91);
			this.btn_agregar.TabIndex = 15;
			this.btn_agregar.Text = "Agregar Empleado";
			this.btn_agregar.UseVisualStyleBackColor = true;
			this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
			// 
			// cbSueldo
			// 
			this.cbSueldo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSueldo.FormattingEnabled = true;
			this.cbSueldo.Location = new System.Drawing.Point(784, 447);
			this.cbSueldo.Name = "cbSueldo";
			this.cbSueldo.Size = new System.Drawing.Size(79, 21);
			this.cbSueldo.TabIndex = 28;
			this.cbSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
			// 
			// Grilla
			// 
			this.Grilla.AllowUserToAddRows = false;
			this.Grilla.AllowUserToDeleteRows = false;
			this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grilla.Location = new System.Drawing.Point(13, 22);
			this.Grilla.Name = "Grilla";
			this.Grilla.ReadOnly = true;
			this.Grilla.Size = new System.Drawing.Size(1112, 386);
			this.Grilla.TabIndex = 29;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(172, 450);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 13);
			this.label6.TabIndex = 31;
			this.label6.Text = "Apellido:";
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(225, 447);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(101, 20);
			this.txtApellido.TabIndex = 30;
			this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
			// 
			// cbIdEm
			// 
			this.cbIdEm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbIdEm.FormattingEnabled = true;
			this.cbIdEm.Location = new System.Drawing.Point(409, 447);
			this.cbIdEm.Name = "cbIdEm";
			this.cbIdEm.Size = new System.Drawing.Size(70, 21);
			this.cbIdEm.TabIndex = 35;
			this.cbIdEm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPermitirEscribir);
			// 
			// txtIdEmpleado
			// 
			this.txtIdEmpleado.Location = new System.Drawing.Point(487, 447);
			this.txtIdEmpleado.Name = "txtIdEmpleado";
			this.txtIdEmpleado.Size = new System.Drawing.Size(72, 20);
			this.txtIdEmpleado.TabIndex = 34;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(332, 450);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 33;
			this.label2.Text = "ID Empleado:";
			// 
			// Empleados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1137, 613);
			this.Controls.Add(this.cbIdEm);
			this.Controls.Add(this.txtIdEmpleado);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.Grilla);
			this.Controls.Add(this.cbSueldo);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtSueldo);
			this.Controls.Add(this.txtTel);
			this.Controls.Add(this.btFiltrar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btn_agregar);
			this.Name = "Empleados";
			this.Text = "Empleados";
			this.Load += new System.EventHandler(this.EMPLEADOS_Load);
			((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ComboBox cbSueldo;
		private System.Windows.Forms.DataGridView Grilla;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.ComboBox cbIdEm;
		private System.Windows.Forms.TextBox txtIdEmpleado;
		private System.Windows.Forms.Label label2;
	}
}