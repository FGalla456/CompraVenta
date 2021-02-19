namespace WindowsFormsApp1
{
    partial class actualizar_productos
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
			this.txtIdProd = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnbuscar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtprecio = new System.Windows.Forms.TextBox();
			this.btn_aceptar = new System.Windows.Forms.Button();
			this.cbCat = new System.Windows.Forms.ComboBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnprod = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtIdProd
			// 
			this.txtIdProd.Location = new System.Drawing.Point(92, 37);
			this.txtIdProd.Name = "txtIdProd";
			this.txtIdProd.Size = new System.Drawing.Size(153, 20);
			this.txtIdProd.TabIndex = 18;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "ID Producto:";
			// 
			// btnbuscar
			// 
			this.btnbuscar.Location = new System.Drawing.Point(92, 75);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(151, 52);
			this.btnbuscar.TabIndex = 25;
			this.btnbuscar.Text = "Buscar Producto";
			this.btnbuscar.UseVisualStyleBackColor = true;
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtprecio);
			this.groupBox1.Controls.Add(this.btn_aceptar);
			this.groupBox1.Controls.Add(this.cbCat);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(330, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(812, 125);
			this.groupBox1.TabIndex = 26;
			this.groupBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(598, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 13);
			this.label2.TabIndex = 34;
			this.label2.Text = "Precio Unitario:";
			// 
			// txtprecio
			// 
			this.txtprecio.Location = new System.Drawing.Point(678, 32);
			this.txtprecio.Name = "txtprecio";
			this.txtprecio.Size = new System.Drawing.Size(126, 20);
			this.txtprecio.TabIndex = 33;
			this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
			// 
			// btn_aceptar
			// 
			this.btn_aceptar.Location = new System.Drawing.Point(245, 81);
			this.btn_aceptar.Name = "btn_aceptar";
			this.btn_aceptar.Size = new System.Drawing.Size(186, 34);
			this.btn_aceptar.TabIndex = 32;
			this.btn_aceptar.Text = "Aceptar";
			this.btn_aceptar.UseVisualStyleBackColor = true;
			this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
			// 
			// cbCat
			// 
			this.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCat.FormattingEnabled = true;
			this.cbCat.Location = new System.Drawing.Point(408, 28);
			this.cbCat.Name = "cbCat";
			this.cbCat.Size = new System.Drawing.Size(186, 21);
			this.cbCat.TabIndex = 31;
			this.cbCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCat_KeyPress);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(86, 29);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(186, 20);
			this.txtNombre.TabIndex = 29;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(319, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 13);
			this.label4.TabIndex = 26;
			this.label4.Text = "ID Categoria:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 25;
			this.label3.Text = "Nombre:";
			// 
			// btnprod
			// 
			this.btnprod.Image = global::WindowsFormsApp1.Properties.Resources._0404_09_search_LCl_icon;
			this.btnprod.Location = new System.Drawing.Point(267, 27);
			this.btnprod.Name = "btnprod";
			this.btnprod.Size = new System.Drawing.Size(57, 44);
			this.btnprod.TabIndex = 27;
			this.btnprod.UseVisualStyleBackColor = true;
			this.btnprod.Click += new System.EventHandler(this.btnprod_Click);
			// 
			// actualizar_productos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1146, 146);
			this.Controls.Add(this.btnprod);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.txtIdProd);
			this.Controls.Add(this.label1);
			this.Name = "actualizar_productos";
			this.Text = "Actualizar Productos";
			this.Load += new System.EventHandler(this.actualizar_productos_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnprod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprecio;
    }
}