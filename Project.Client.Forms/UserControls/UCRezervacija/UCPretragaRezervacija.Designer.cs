namespace Project.Client.Forms.UserControls.UCRezervacija
{
	partial class UCPretragaRezervacija
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnPretrazi = new System.Windows.Forms.Button();
			this.gbUnosStola = new System.Windows.Forms.GroupBox();
			this.txtDatumVreme = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.gbUnosStola.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(36, 236);
			this.dataGridView1.MinimumSize = new System.Drawing.Size(1407, 319);
			this.dataGridView1.Name = "dataGridView1";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.RowHeadersWidth = 51;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1408, 455);
			this.dataGridView1.TabIndex = 32;
			// 
			// btnPretrazi
			// 
			this.btnPretrazi.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnPretrazi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(44)))), ((int)(((byte)(126)))));
			this.btnPretrazi.Location = new System.Drawing.Point(1000, 91);
			this.btnPretrazi.MinimumSize = new System.Drawing.Size(443, 51);
			this.btnPretrazi.Name = "btnPretrazi";
			this.btnPretrazi.Size = new System.Drawing.Size(444, 51);
			this.btnPretrazi.TabIndex = 31;
			this.btnPretrazi.Text = "Pretraži rezervaciju na osnovu kriterijuma";
			this.btnPretrazi.UseVisualStyleBackColor = false;
			// 
			// gbUnosStola
			// 
			this.gbUnosStola.BackColor = System.Drawing.Color.Transparent;
			this.gbUnosStola.Controls.Add(this.txtDatumVreme);
			this.gbUnosStola.Controls.Add(this.dataGridView1);
			this.gbUnosStola.Controls.Add(this.btnPretrazi);
			this.gbUnosStola.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.gbUnosStola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))));
			this.gbUnosStola.Location = new System.Drawing.Point(12, 24);
			this.gbUnosStola.Margin = new System.Windows.Forms.Padding(4);
			this.gbUnosStola.MaximumSize = new System.Drawing.Size(1474, 867);
			this.gbUnosStola.Name = "gbUnosStola";
			this.gbUnosStola.Padding = new System.Windows.Forms.Padding(4);
			this.gbUnosStola.Size = new System.Drawing.Size(1474, 866);
			this.gbUnosStola.TabIndex = 3;
			this.gbUnosStola.TabStop = false;
			this.gbUnosStola.Text = "Rezervacija";
			// 
			// txtDatumVreme
			// 
			this.txtDatumVreme.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtDatumVreme.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			this.txtDatumVreme.Location = new System.Drawing.Point(36, 91);
			this.txtDatumVreme.Margin = new System.Windows.Forms.Padding(4);
			this.txtDatumVreme.Name = "txtDatumVreme";
			this.txtDatumVreme.Size = new System.Drawing.Size(876, 28);
			this.txtDatumVreme.TabIndex = 33;
			// 
			// UCPretragaRezervacija
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.gbUnosStola);
			this.Name = "UCPretragaRezervacija";
			this.Size = new System.Drawing.Size(1498, 914);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.gbUnosStola.ResumeLayout(false);
			this.gbUnosStola.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnPretrazi;
		private System.Windows.Forms.GroupBox gbUnosStola;
		private System.Windows.Forms.TextBox txtDatumVreme;
	}
}
