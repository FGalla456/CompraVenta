namespace WindowsFormsApp1
{
    partial class EliminarDetalleVenta
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
			this.btnfac = new System.Windows.Forms.Button();
			this.txtIDPROV = new System.Windows.Forms.TextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtfac = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(122, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(246, 24);
			this.label3.TabIndex = 41;
			this.label3.Text = "Eliminar Detalle de Venta";
			// 
			// btnfac
			// 
			this.btnfac.Image = global::WindowsFormsApp1.Properties.Resources._0404_09_search_LCl_icon;
			this.btnfac.Location = new System.Drawing.Point(353, 77);
			this.btnfac.Name = "btnfac";
			this.btnfac.Size = new System.Drawing.Size(82, 86);
			this.btnfac.TabIndex = 47;
			this.btnfac.UseVisualStyleBackColor = true;
			this.btnfac.Click += new System.EventHandler(this.btnfac_Click);
			// 
			// txtIDPROV
			// 
			this.txtIDPROV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIDPROV.Location = new System.Drawing.Point(150, 137);
			this.txtIDPROV.Name = "txtIDPROV";
			this.txtIDPROV.Size = new System.Drawing.Size(188, 26);
			this.txtIDPROV.TabIndex = 46;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Location = new System.Drawing.Point(192, 169);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(110, 32);
			this.btnAceptar.TabIndex = 45;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(48, 140);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 20);
			this.label1.TabIndex = 44;
			this.label1.Text = "ID Producto:";
			// 
			// txtfac
			// 
			this.txtfac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtfac.Location = new System.Drawing.Point(150, 84);
			this.txtfac.Name = "txtfac";
			this.txtfac.Size = new System.Drawing.Size(188, 26);
			this.txtfac.TabIndex = 43;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(48, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 20);
			this.label2.TabIndex = 42;
			this.label2.Text = "Nro Factura:";
			// 
			// EliminarDetalleVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(496, 222);
			this.Controls.Add(this.btnfac);
			this.Controls.Add(this.txtIDPROV);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtfac);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Name = "EliminarDetalleVenta";
			this.Text = "Eliminar Detalle de Venta";
			this.Load += new System.EventHandler(this.EliminarDetalleVenta_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnfac;
        private System.Windows.Forms.TextBox txtIDPROV;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfac;
        private System.Windows.Forms.Label label2;
    }
}