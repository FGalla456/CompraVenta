namespace WindowsFormsApp1
{
    partial class eliminarempl
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
            this.txtIDPROV = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnprod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Eliminar Empleado";
            // 
            // txtIDPROV
            // 
            this.txtIDPROV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPROV.Location = new System.Drawing.Point(350, 84);
            this.txtIDPROV.Name = "txtIDPROV";
            this.txtIDPROV.Size = new System.Drawing.Size(188, 26);
            this.txtIDPROV.TabIndex = 30;
            this.txtIDPROV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDPROV_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(311, 125);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 32);
            this.btnAceptar.TabIndex = 29;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Id Empleado:";
            // 
            // btnprod
            // 
            this.btnprod.Image = global::WindowsFormsApp1.Properties.Resources._0404_09_search_LCl_icon;
            this.btnprod.Location = new System.Drawing.Point(544, 66);
            this.btnprod.Name = "btnprod";
            this.btnprod.Size = new System.Drawing.Size(57, 44);
            this.btnprod.TabIndex = 51;
            this.btnprod.UseVisualStyleBackColor = true;
            this.btnprod.Click += new System.EventHandler(this.btnprod_Click);
            // 
            // eliminarempl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 164);
            this.Controls.Add(this.btnprod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDPROV);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Name = "eliminarempl";
            this.Text = "Eliminar Empleado";
            this.Load += new System.EventHandler(this.eliminarempl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDPROV;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnprod;
    }
}