namespace WindowsFormsApp1
{
    partial class menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.btn_articulos = new System.Windows.Forms.Button();
			this.btn_compras = new System.Windows.Forms.Button();
			this.btn_ventas = new System.Windows.Forms.Button();
			this.btn_prov = new System.Windows.Forms.Button();
			this.btn_empleados = new System.Windows.Forms.Button();
			this.btn_clientes = new System.Windows.Forms.Button();
			this.btn_categorias = new System.Windows.Forms.Button();
			this.btnInformes = new System.Windows.Forms.Button();
			this.btManUsu = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_articulos
			// 
			this.btn_articulos.Location = new System.Drawing.Point(759, 12);
			this.btn_articulos.Name = "btn_articulos";
			this.btn_articulos.Size = new System.Drawing.Size(198, 87);
			this.btn_articulos.TabIndex = 0;
			this.btn_articulos.Text = "Productos";
			this.btn_articulos.UseVisualStyleBackColor = true;
			this.btn_articulos.Click += new System.EventHandler(this.btn_articulos_Click);
			// 
			// btn_compras
			// 
			this.btn_compras.Location = new System.Drawing.Point(12, 120);
			this.btn_compras.Name = "btn_compras";
			this.btn_compras.Size = new System.Drawing.Size(198, 87);
			this.btn_compras.TabIndex = 1;
			this.btn_compras.Text = "Compras";
			this.btn_compras.UseVisualStyleBackColor = true;
			this.btn_compras.Click += new System.EventHandler(this.btn_compras_Click);
			// 
			// btn_ventas
			// 
			this.btn_ventas.Location = new System.Drawing.Point(390, 229);
			this.btn_ventas.Name = "btn_ventas";
			this.btn_ventas.Size = new System.Drawing.Size(198, 87);
			this.btn_ventas.TabIndex = 2;
			this.btn_ventas.Text = "Ventas";
			this.btn_ventas.UseVisualStyleBackColor = true;
			this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
			// 
			// btn_prov
			// 
			this.btn_prov.Location = new System.Drawing.Point(390, 12);
			this.btn_prov.Name = "btn_prov";
			this.btn_prov.Size = new System.Drawing.Size(198, 85);
			this.btn_prov.TabIndex = 3;
			this.btn_prov.Text = "Proveedores";
			this.btn_prov.UseVisualStyleBackColor = true;
			this.btn_prov.Click += new System.EventHandler(this.btn_prov_Click);
			// 
			// btn_empleados
			// 
			this.btn_empleados.Location = new System.Drawing.Point(12, 232);
			this.btn_empleados.Name = "btn_empleados";
			this.btn_empleados.Size = new System.Drawing.Size(198, 85);
			this.btn_empleados.TabIndex = 4;
			this.btn_empleados.Text = "Empleados";
			this.btn_empleados.UseVisualStyleBackColor = true;
			this.btn_empleados.Click += new System.EventHandler(this.btn_empleados_Click);
			// 
			// btn_clientes
			// 
			this.btn_clientes.Location = new System.Drawing.Point(759, 120);
			this.btn_clientes.Name = "btn_clientes";
			this.btn_clientes.Size = new System.Drawing.Size(198, 85);
			this.btn_clientes.TabIndex = 5;
			this.btn_clientes.Text = "Clientes";
			this.btn_clientes.UseVisualStyleBackColor = true;
			this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
			// 
			// btn_categorias
			// 
			this.btn_categorias.Location = new System.Drawing.Point(12, 12);
			this.btn_categorias.Name = "btn_categorias";
			this.btn_categorias.Size = new System.Drawing.Size(198, 85);
			this.btn_categorias.TabIndex = 6;
			this.btn_categorias.Text = "Categorias";
			this.btn_categorias.UseVisualStyleBackColor = true;
			this.btn_categorias.Click += new System.EventHandler(this.btn_categorias_Click);
			// 
			// btnInformes
			// 
			this.btnInformes.Location = new System.Drawing.Point(759, 231);
			this.btnInformes.Name = "btnInformes";
			this.btnInformes.Size = new System.Drawing.Size(198, 87);
			this.btnInformes.TabIndex = 7;
			this.btnInformes.Text = "Informes";
			this.btnInformes.UseVisualStyleBackColor = true;
			this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
			// 
			// btManUsu
			// 
			this.btManUsu.Location = new System.Drawing.Point(390, 120);
			this.btManUsu.Name = "btManUsu";
			this.btManUsu.Size = new System.Drawing.Size(198, 87);
			this.btManUsu.TabIndex = 8;
			this.btManUsu.Text = "Manual de Usuario";
			this.btManUsu.UseVisualStyleBackColor = true;
			this.btManUsu.Click += new System.EventHandler(this.btManUsu_Click);
			// 
			// menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(969, 328);
			this.Controls.Add(this.btManUsu);
			this.Controls.Add(this.btnInformes);
			this.Controls.Add(this.btn_categorias);
			this.Controls.Add(this.btn_clientes);
			this.Controls.Add(this.btn_empleados);
			this.Controls.Add(this.btn_prov);
			this.Controls.Add(this.btn_ventas);
			this.Controls.Add(this.btn_compras);
			this.Controls.Add(this.btn_articulos);
			this.Name = "menu";
			this.Text = "Menu";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_articulos;
        private System.Windows.Forms.Button btn_compras;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.Button btn_prov;
        private System.Windows.Forms.Button btn_empleados;
        private System.Windows.Forms.Button btn_clientes;
		private System.Windows.Forms.Button btn_categorias;
        private System.Windows.Forms.Button btnInformes;
		private System.Windows.Forms.Button btManUsu;
	}
}

