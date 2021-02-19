namespace WindowsFormsApp1
{
    partial class Detalle_Venta
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
            this.btnfact = new System.Windows.Forms.Button();
            this.btnprod = new System.Windows.Forms.Button();
            this.grdcompras = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.txtNFactura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.grdcompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnfact
            // 
            this.btnfact.Image = global::WindowsFormsApp1.Properties.Resources._0404_09_search_LCl_icon;
            this.btnfact.Location = new System.Drawing.Point(224, 17);
            this.btnfact.Name = "btnfact";
            this.btnfact.Size = new System.Drawing.Size(57, 44);
            this.btnfact.TabIndex = 34;
            this.btnfact.UseVisualStyleBackColor = true;
            this.btnfact.Click += new System.EventHandler(this.btnfact_Click);
            // 
            // btnprod
            // 
            this.btnprod.Image = global::WindowsFormsApp1.Properties.Resources._0404_09_search_LCl_icon;
            this.btnprod.Location = new System.Drawing.Point(491, 17);
            this.btnprod.Name = "btnprod";
            this.btnprod.Size = new System.Drawing.Size(57, 44);
            this.btnprod.TabIndex = 33;
            this.btnprod.UseVisualStyleBackColor = true;
            this.btnprod.Click += new System.EventHandler(this.btnprod_Click);
            // 
            // grdcompras
            // 
            this.grdcompras.AllowUserToAddRows = false;
            this.grdcompras.AllowUserToDeleteRows = false;
            this.grdcompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdcompras.Location = new System.Drawing.Point(576, 30);
            this.grdcompras.Name = "grdcompras";
            this.grdcompras.ReadOnly = true;
            this.grdcompras.Size = new System.Drawing.Size(401, 150);
            this.grdcompras.TabIndex = 32;
            this.grdcompras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdcompras_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 48);
            this.button1.TabIndex = 31;
            this.button1.Text = "Finalizar Agregar Items";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(85, 134);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(135, 48);
            this.btAceptar.TabIndex = 30;
            this.btAceptar.Text = "Agregar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click_1);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(85, 95);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(133, 20);
            this.txtCantidad.TabIndex = 28;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PermitirSoloNumeros);
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(352, 30);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(133, 20);
            this.txtIdProd.TabIndex = 27;
            this.txtIdProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PermitirSoloNumeros);
            // 
            // txtNFactura
            // 
            this.txtNFactura.Location = new System.Drawing.Point(85, 30);
            this.txtNFactura.Name = "txtNFactura";
            this.txtNFactura.Size = new System.Drawing.Size(133, 20);
            this.txtNFactura.TabIndex = 26;
            this.txtNFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PermitirSoloNumeros);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Precio por Unidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Id Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nro Factura:";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(352, 67);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(133, 20);
            this.txtstock.TabIndex = 35;
            this.txtstock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PermitirSoloNumeros);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Stock:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(582, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Doble click para eliminar detalle venta";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(352, 101);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(133, 20);
            this.numericUpDown1.TabIndex = 38;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Detalle_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 194);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.btnfact);
            this.Controls.Add(this.btnprod);
            this.Controls.Add(this.grdcompras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtIdProd);
            this.Controls.Add(this.txtNFactura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Detalle_Venta";
            this.Text = "Agregar Detalle de Venta";
            this.Load += new System.EventHandler(this.Detalle_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdcompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfact;
        private System.Windows.Forms.Button btnprod;
        private System.Windows.Forms.DataGridView grdcompras;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.TextBox txtNFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}