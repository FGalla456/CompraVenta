namespace WindowsFormsApp1
{
    partial class eliminar_detalle_compra
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
			this.txtfac = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtIDPROV = new System.Windows.Forms.TextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnfac = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtfac
			// 
			this.txtfac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtfac.Location = new System.Drawing.Point(315, 97);
			this.txtfac.Name = "txtfac";
			this.txtfac.Size = new System.Drawing.Size(188, 26);
			this.txtfac.TabIndex = 31;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(213, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 20);
			this.label2.TabIndex = 30;
			this.label2.Text = "Nro Factura:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(238, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(265, 24);
			this.label3.TabIndex = 35;
			this.label3.Text = "Eliminar Detalle de Compra";
			// 
			// txtIDPROV
			// 
			this.txtIDPROV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIDPROV.Location = new System.Drawing.Point(315, 150);
			this.txtIDPROV.Name = "txtIDPROV";
			this.txtIDPROV.Size = new System.Drawing.Size(188, 26);
			this.txtIDPROV.TabIndex = 34;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Location = new System.Drawing.Point(291, 188);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(110, 32);
			this.btnAceptar.TabIndex = 33;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(213, 153);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 20);
			this.label1.TabIndex = 32;
			this.label1.Text = "ID Producto:";
			// 
			// btnfac
			// 
			this.btnfac.Image = global::WindowsFormsApp1.Properties.Resources._0404_09_search_LCl_icon;
			this.btnfac.Location = new System.Drawing.Point(518, 90);
			this.btnfac.Name = "btnfac";
			this.btnfac.Size = new System.Drawing.Size(82, 86);
			this.btnfac.TabIndex = 36;
			this.btnfac.UseVisualStyleBackColor = true;
			this.btnfac.Click += new System.EventHandler(this.btnfac_Click);
			// 
			// eliminar_detalle_compra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(712, 287);
			this.Controls.Add(this.btnfac);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtIDPROV);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtfac);
			this.Controls.Add(this.label2);
			this.Name = "eliminar_detalle_compra";
			this.Text = "Eliminar Detalle Compra";
			this.Load += new System.EventHandler(this.eliminar_detalle_compra_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDPROV;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnfac;
    }
}