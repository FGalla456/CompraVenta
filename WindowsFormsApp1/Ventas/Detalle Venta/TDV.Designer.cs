namespace WindowsFormsApp1
{
    partial class TDV
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
			this.Grilla.Size = new System.Drawing.Size(756, 462);
			this.Grilla.TabIndex = 0;
			this.Grilla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla_CellDoubleClick);
			// 
			// TDV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(780, 486);
			this.Controls.Add(this.Grilla);
			this.Name = "TDV";
			this.Text = "Lista de Detalle de Ventas";
			this.Load += new System.EventHandler(this.TDV_Load);
			((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grilla;
    }
}