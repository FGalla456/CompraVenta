namespace WindowsFormsApp1
{
	partial class Categorias
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
			this.Grilla = new System.Windows.Forms.DataGridView();
			this.button4 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btn_agregar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
			this.SuspendLayout();
			// 
			// Grilla
			// 
			this.Grilla.AllowUserToAddRows = false;
			this.Grilla.AllowUserToDeleteRows = false;
			this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grilla.Location = new System.Drawing.Point(12, 12);
			this.Grilla.Name = "Grilla";
			this.Grilla.ReadOnly = true;
			this.Grilla.Size = new System.Drawing.Size(815, 338);
			this.Grilla.TabIndex = 31;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(301, 375);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(219, 91);
			this.button4.TabIndex = 34;
			this.button4.Text = "Actualizar datos ";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(604, 375);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(223, 91);
			this.button2.TabIndex = 33;
			this.button2.Text = "Eliminar Categoria";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btn_agregar
			// 
			this.btn_agregar.Location = new System.Drawing.Point(12, 375);
			this.btn_agregar.Name = "btn_agregar";
			this.btn_agregar.Size = new System.Drawing.Size(219, 91);
			this.btn_agregar.TabIndex = 32;
			this.btn_agregar.Text = "Agregar Categoria";
			this.btn_agregar.UseVisualStyleBackColor = true;
			this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
			// 
			// Categorias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(847, 482);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btn_agregar);
			this.Controls.Add(this.Grilla);
			this.Name = "Categorias";
			this.Text = "Categorias";
			this.Load += new System.EventHandler(this.Categorias_Load);
			((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView Grilla;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btn_agregar;
	}
}