namespace WindowsFormsApp1
{
    partial class actualizarcat
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
			this.btn_aceptar = new System.Windows.Forms.Button();
			this.txtDet = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtIdCat = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnbuscar = new System.Windows.Forms.Button();
			this.btnprod = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_aceptar
			// 
			this.btn_aceptar.Location = new System.Drawing.Point(186, 126);
			this.btn_aceptar.Name = "btn_aceptar";
			this.btn_aceptar.Size = new System.Drawing.Size(166, 34);
			this.btn_aceptar.TabIndex = 13;
			this.btn_aceptar.Text = "Aceptar";
			this.btn_aceptar.UseVisualStyleBackColor = true;
			this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
			// 
			// txtDet
			// 
			this.txtDet.Location = new System.Drawing.Point(144, 82);
			this.txtDet.Name = "txtDet";
			this.txtDet.Size = new System.Drawing.Size(350, 20);
			this.txtDet.TabIndex = 12;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(348, 15);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(146, 20);
			this.txtNombre.TabIndex = 11;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
			// 
			// txtIdCat
			// 
			this.txtIdCat.Location = new System.Drawing.Point(88, 12);
			this.txtIdCat.Name = "txtIdCat";
			this.txtIdCat.Size = new System.Drawing.Size(129, 20);
			this.txtIdCat.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(295, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Nombre:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(63, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Descripción:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Id Categoria:";
			// 
			// btnbuscar
			// 
			this.btnbuscar.Location = new System.Drawing.Point(88, 38);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(129, 23);
			this.btnbuscar.TabIndex = 14;
			this.btnbuscar.Text = "Buscar Categoria";
			this.btnbuscar.UseVisualStyleBackColor = true;
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
			// 
			// btnprod
			// 
			this.btnprod.Image = global::WindowsFormsApp1.Properties.Resources._0404_09_search_LCl_icon;
			this.btnprod.Location = new System.Drawing.Point(223, 4);
			this.btnprod.Name = "btnprod";
			this.btnprod.Size = new System.Drawing.Size(33, 34);
			this.btnprod.TabIndex = 28;
			this.btnprod.UseVisualStyleBackColor = true;
			this.btnprod.Click += new System.EventHandler(this.btnprod_Click);
			// 
			// actualizarcat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(531, 182);
			this.Controls.Add(this.btnprod);
			this.Controls.Add(this.txtDet);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.btn_aceptar);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtIdCat);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "actualizarcat";
			this.Text = "Actualizar Categoria";
			this.Load += new System.EventHandler(this.actualizarcat_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txtDet;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnprod;
    }
}