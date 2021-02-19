namespace WindowsFormsApp1
{
	partial class Agregar_Categoria
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtIdCat = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtDet = new System.Windows.Forms.TextBox();
			this.btn_aceptar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Id Categoria:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Descripción:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(262, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nombre:";
			// 
			// txtIdCat
			// 
			this.txtIdCat.Location = new System.Drawing.Point(111, 10);
			this.txtIdCat.Name = "txtIdCat";
			this.txtIdCat.Size = new System.Drawing.Size(129, 20);
			this.txtIdCat.TabIndex = 3;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(315, 10);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(146, 20);
			this.txtNombre.TabIndex = 4;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
			// 
			// txtDet
			// 
			this.txtDet.Location = new System.Drawing.Point(111, 56);
			this.txtDet.Name = "txtDet";
			this.txtDet.Size = new System.Drawing.Size(350, 20);
			this.txtDet.TabIndex = 5;
			// 
			// btn_aceptar
			// 
			this.btn_aceptar.Location = new System.Drawing.Point(198, 82);
			this.btn_aceptar.Name = "btn_aceptar";
			this.btn_aceptar.Size = new System.Drawing.Size(166, 34);
			this.btn_aceptar.TabIndex = 6;
			this.btn_aceptar.Text = "Aceptar";
			this.btn_aceptar.UseVisualStyleBackColor = true;
			this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
			// 
			// Agregar_Categoria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(491, 124);
			this.Controls.Add(this.btn_aceptar);
			this.Controls.Add(this.txtDet);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtIdCat);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Agregar_Categoria";
			this.Text = "Agregar Categoria";
			this.Load += new System.EventHandler(this.Agregar_Categoria_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtIdCat;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtDet;
        private System.Windows.Forms.Button btn_aceptar;
	}
}