using System.Windows.Forms;

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
			this.dgvRezervacije = new System.Windows.Forms.DataGridView();
			this.btnPretrazi = new System.Windows.Forms.Button();
			this.gbUnosStola = new System.Windows.Forms.GroupBox();
			this.lblNapomena = new System.Windows.Forms.Label();
			this.txtKriterijum = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
			this.gbUnosStola.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvRezervacije
			// 
			this.dgvRezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvRezervacije.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRezervacije.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRezervacije.Location = new System.Drawing.Point(36, 231);
			this.dgvRezervacije.MultiSelect = false;
			this.dgvRezervacije.Name = "dgvRezervacije";
			this.dgvRezervacije.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRezervacije.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvRezervacije.RowHeadersWidth = 51;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			this.dgvRezervacije.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvRezervacije.RowTemplate.Height = 24;
			this.dgvRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvRezervacije.Size = new System.Drawing.Size(1408, 455);
			this.dgvRezervacije.TabIndex = 3;
			// 
			// btnPretrazi
			// 
			this.btnPretrazi.BackColor = System.Drawing.Color.White;
			this.btnPretrazi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(44)))), ((int)(((byte)(126)))));
			this.btnPretrazi.Location = new System.Drawing.Point(1000, 91);
			this.btnPretrazi.MinimumSize = new System.Drawing.Size(443, 51);
			this.btnPretrazi.Name = "btnPretrazi";
			this.btnPretrazi.Size = new System.Drawing.Size(444, 51);
			this.btnPretrazi.TabIndex = 2;
			this.btnPretrazi.Text = "Pretraži rezervaciju na osnovu kriterijuma";
			this.btnPretrazi.UseVisualStyleBackColor = false;
			this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
			// 
			// gbUnosStola
			// 
			this.gbUnosStola.BackColor = System.Drawing.Color.Transparent;
			this.gbUnosStola.Controls.Add(this.lblNapomena);
			this.gbUnosStola.Controls.Add(this.txtKriterijum);
			this.gbUnosStola.Controls.Add(this.dgvRezervacije);
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
			// lblNapomena
			// 
			this.lblNapomena.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNapomena.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblNapomena.Location = new System.Drawing.Point(36, 138);
			this.lblNapomena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNapomena.Name = "lblNapomena";
			this.lblNapomena.Size = new System.Drawing.Size(844, 59);
			this.lblNapomena.TabIndex = 41;
			this.lblNapomena.Text = "(Moguće je pretražiti po klijentu, radniku, datumu u formatu dd-mm-yyyy, vremenu " +
    "u formatu hh:mm, mestu, tipu proslave ili ukupnoj ceni)";
			// 
			// txtKriterijum
			// 
			this.txtKriterijum.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtKriterijum.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			this.txtKriterijum.Location = new System.Drawing.Point(36, 91);
			this.txtKriterijum.Margin = new System.Windows.Forms.Padding(4);
			this.txtKriterijum.Name = "txtKriterijum";
			this.txtKriterijum.Size = new System.Drawing.Size(876, 28);
			this.txtKriterijum.TabIndex = 1;
			// 
			// UCPretragaRezervacija
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.gbUnosStola);
			this.Name = "UCPretragaRezervacija";
			this.Size = new System.Drawing.Size(1498, 914);
			this.Load += new System.EventHandler(this.UCPretragaRezervacija_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
			this.gbUnosStola.ResumeLayout(false);
			this.gbUnosStola.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView dgvRezervacije;
		private System.Windows.Forms.Button btnPretrazi;
		private System.Windows.Forms.GroupBox gbUnosStola;
		private System.Windows.Forms.TextBox txtKriterijum;
		private System.Windows.Forms.Label lblNapomena;

		public DataGridView DgvRezervacije { get => dgvRezervacije; set => dgvRezervacije = value; }
		public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
		public GroupBox GbUnosStola { get => gbUnosStola; set => gbUnosStola = value; }
		public TextBox TxtKriterijum { get => txtKriterijum; set => txtKriterijum = value; }
		public Label LblNapomena { get => lblNapomena; set => lblNapomena = value; }
	}
}
