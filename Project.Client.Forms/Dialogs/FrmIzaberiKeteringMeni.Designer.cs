namespace Project.Client.Forms.Dialogs
{
	partial class FrmIzaberiKeteringMeni
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
			this.lblKeteringFirma = new System.Windows.Forms.Label();
			this.cbKeteringFirme = new System.Windows.Forms.ComboBox();
			this.btnPrikazi = new System.Windows.Forms.Button();
			this.dgvMeni = new System.Windows.Forms.DataGridView();
			this.btnOdabir = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvMeni)).BeginInit();
			this.SuspendLayout();
			// 
			// lblKeteringFirma
			// 
			this.lblKeteringFirma.BackColor = System.Drawing.Color.Transparent;
			this.lblKeteringFirma.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKeteringFirma.ForeColor = System.Drawing.Color.White;
			this.lblKeteringFirma.Location = new System.Drawing.Point(49, 79);
			this.lblKeteringFirma.Name = "lblKeteringFirma";
			this.lblKeteringFirma.Size = new System.Drawing.Size(168, 29);
			this.lblKeteringFirma.TabIndex = 0;
			this.lblKeteringFirma.Text = "Ketering firma:";
			// 
			// cbKeteringFirme
			// 
			this.cbKeteringFirme.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbKeteringFirme.ForeColor = System.Drawing.Color.BlueViolet;
			this.cbKeteringFirme.FormattingEnabled = true;
			this.cbKeteringFirme.Location = new System.Drawing.Point(257, 75);
			this.cbKeteringFirme.Name = "cbKeteringFirme";
			this.cbKeteringFirme.Size = new System.Drawing.Size(368, 30);
			this.cbKeteringFirme.TabIndex = 1;
			// 
			// btnPrikazi
			// 
			this.btnPrikazi.BackColor = System.Drawing.Color.White;
			this.btnPrikazi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrikazi.ForeColor = System.Drawing.Color.BlueViolet;
			this.btnPrikazi.Location = new System.Drawing.Point(646, 72);
			this.btnPrikazi.Name = "btnPrikazi";
			this.btnPrikazi.Size = new System.Drawing.Size(227, 33);
			this.btnPrikazi.TabIndex = 2;
			this.btnPrikazi.Text = "Prikaži menije firme";
			this.btnPrikazi.UseVisualStyleBackColor = false;
			// 
			// dgvMeni
			// 
			this.dgvMeni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMeni.Location = new System.Drawing.Point(53, 145);
			this.dgvMeni.Name = "dgvMeni";
			this.dgvMeni.ReadOnly = true;
			this.dgvMeni.RowHeadersWidth = 51;
			this.dgvMeni.RowTemplate.Height = 24;
			this.dgvMeni.Size = new System.Drawing.Size(820, 277);
			this.dgvMeni.TabIndex = 3;
			// 
			// btnOdabir
			// 
			this.btnOdabir.BackColor = System.Drawing.Color.White;
			this.btnOdabir.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOdabir.ForeColor = System.Drawing.Color.Indigo;
			this.btnOdabir.Location = new System.Drawing.Point(597, 458);
			this.btnOdabir.Name = "btnOdabir";
			this.btnOdabir.Size = new System.Drawing.Size(276, 46);
			this.btnOdabir.TabIndex = 4;
			this.btnOdabir.Text = "Izvrši odabir menija";
			this.btnOdabir.UseVisualStyleBackColor = false;
			// 
			// FrmIzaberiKeteringMeni
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Project.Client.Forms.Properties.Resources.PrijavljivanjePozadina;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(928, 557);
			this.Controls.Add(this.btnOdabir);
			this.Controls.Add(this.dgvMeni);
			this.Controls.Add(this.btnPrikazi);
			this.Controls.Add(this.cbKeteringFirme);
			this.Controls.Add(this.lblKeteringFirma);
			this.Name = "FrmIzaberiKeteringMeni";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Izaberi ketering meni";
			this.Load += new System.EventHandler(this.FrmIzaberiKeteringMeni_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvMeni)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblKeteringFirma;
		private System.Windows.Forms.ComboBox cbKeteringFirme;
		private System.Windows.Forms.Button btnPrikazi;
		private System.Windows.Forms.DataGridView dgvMeni;
		private System.Windows.Forms.Button btnOdabir;
	}
}