using System.Windows.Forms;

namespace Project.Client.Forms.UserControls.UCSto
{
    partial class UCPretraziSto
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
			this.gbPretragaStola = new System.Windows.Forms.GroupBox();
			this.lblNapomena = new System.Windows.Forms.Label();
			this.lblProizvodjacPrikaziVrednost = new System.Windows.Forms.Label();
			this.lblCenaStolaPrikaziVrednost = new System.Windows.Forms.Label();
			this.lblKapacitetPrikaziVrednost = new System.Windows.Forms.Label();
			this.dgvStolovi = new System.Windows.Forms.DataGridView();
			this.btnPrikaziDetalje = new System.Windows.Forms.Button();
			this.txtKriterijum = new System.Windows.Forms.TextBox();
			this.btnPretraziSto = new System.Windows.Forms.Button();
			this.lblProizvodjac = new System.Windows.Forms.Label();
			this.lblCenaStola = new System.Windows.Forms.Label();
			this.lblKapacitet = new System.Windows.Forms.Label();
			this.gbPretragaStola.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStolovi)).BeginInit();
			this.SuspendLayout();
			// 
			// gbPretragaStola
			// 
			this.gbPretragaStola.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gbPretragaStola.BackColor = System.Drawing.Color.Transparent;
			this.gbPretragaStola.Controls.Add(this.lblNapomena);
			this.gbPretragaStola.Controls.Add(this.lblProizvodjacPrikaziVrednost);
			this.gbPretragaStola.Controls.Add(this.lblCenaStolaPrikaziVrednost);
			this.gbPretragaStola.Controls.Add(this.lblKapacitetPrikaziVrednost);
			this.gbPretragaStola.Controls.Add(this.dgvStolovi);
			this.gbPretragaStola.Controls.Add(this.btnPrikaziDetalje);
			this.gbPretragaStola.Controls.Add(this.txtKriterijum);
			this.gbPretragaStola.Controls.Add(this.btnPretraziSto);
			this.gbPretragaStola.Controls.Add(this.lblProizvodjac);
			this.gbPretragaStola.Controls.Add(this.lblCenaStola);
			this.gbPretragaStola.Controls.Add(this.lblKapacitet);
			this.gbPretragaStola.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.gbPretragaStola.ForeColor = System.Drawing.Color.White;
			this.gbPretragaStola.Location = new System.Drawing.Point(4, 4);
			this.gbPretragaStola.Margin = new System.Windows.Forms.Padding(4);
			this.gbPretragaStola.Name = "gbPretragaStola";
			this.gbPretragaStola.Padding = new System.Windows.Forms.Padding(4);
			this.gbPretragaStola.Size = new System.Drawing.Size(1171, 702);
			this.gbPretragaStola.TabIndex = 1;
			this.gbPretragaStola.TabStop = false;
			this.gbPretragaStola.Text = "Pretraga stola";
			// 
			// lblNapomena
			// 
			this.lblNapomena.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNapomena.AutoSize = true;
			this.lblNapomena.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblNapomena.Location = new System.Drawing.Point(118, 131);
			this.lblNapomena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNapomena.Name = "lblNapomena";
			this.lblNapomena.Size = new System.Drawing.Size(477, 21);
			this.lblNapomena.TabIndex = 25;
			this.lblNapomena.Text = "(Moguće je pretražiti po kapacitetu, ceni ili proizvođaču)";
			// 
			// lblProizvodjacPrikaziVrednost
			// 
			this.lblProizvodjacPrikaziVrednost.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblProizvodjacPrikaziVrednost.BackColor = System.Drawing.Color.White;
			this.lblProizvodjacPrikaziVrednost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblProizvodjacPrikaziVrednost.ForeColor = System.Drawing.Color.Black;
			this.lblProizvodjacPrikaziVrednost.Location = new System.Drawing.Point(249, 567);
			this.lblProizvodjacPrikaziVrednost.Name = "lblProizvodjacPrikaziVrednost";
			this.lblProizvodjacPrikaziVrednost.Size = new System.Drawing.Size(360, 27);
			this.lblProizvodjacPrikaziVrednost.TabIndex = 24;
			this.lblProizvodjacPrikaziVrednost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCenaStolaPrikaziVrednost
			// 
			this.lblCenaStolaPrikaziVrednost.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCenaStolaPrikaziVrednost.BackColor = System.Drawing.Color.White;
			this.lblCenaStolaPrikaziVrednost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCenaStolaPrikaziVrednost.ForeColor = System.Drawing.Color.Black;
			this.lblCenaStolaPrikaziVrednost.Location = new System.Drawing.Point(249, 506);
			this.lblCenaStolaPrikaziVrednost.Name = "lblCenaStolaPrikaziVrednost";
			this.lblCenaStolaPrikaziVrednost.Size = new System.Drawing.Size(360, 27);
			this.lblCenaStolaPrikaziVrednost.TabIndex = 23;
			this.lblCenaStolaPrikaziVrednost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblKapacitetPrikaziVrednost
			// 
			this.lblKapacitetPrikaziVrednost.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblKapacitetPrikaziVrednost.BackColor = System.Drawing.Color.White;
			this.lblKapacitetPrikaziVrednost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblKapacitetPrikaziVrednost.ForeColor = System.Drawing.Color.Black;
			this.lblKapacitetPrikaziVrednost.Location = new System.Drawing.Point(249, 447);
			this.lblKapacitetPrikaziVrednost.Name = "lblKapacitetPrikaziVrednost";
			this.lblKapacitetPrikaziVrednost.Size = new System.Drawing.Size(360, 27);
			this.lblKapacitetPrikaziVrednost.TabIndex = 22;
			this.lblKapacitetPrikaziVrednost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dgvStolovi
			// 
			this.dgvStolovi.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvStolovi.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvStolovi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvStolovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStolovi.Location = new System.Drawing.Point(681, 32);
			this.dgvStolovi.Margin = new System.Windows.Forms.Padding(4);
			this.dgvStolovi.Name = "dgvStolovi";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvStolovi.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvStolovi.RowHeadersWidth = 45;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			this.dgvStolovi.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvStolovi.Size = new System.Drawing.Size(436, 641);
			this.dgvStolovi.TabIndex = 18;
			// 
			// btnPrikaziDetalje
			// 
			this.btnPrikaziDetalje.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnPrikaziDetalje.BackColor = System.Drawing.Color.White;
			this.btnPrikaziDetalje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(63)))), ((int)(((byte)(37)))));
			this.btnPrikaziDetalje.Location = new System.Drawing.Point(246, 371);
			this.btnPrikaziDetalje.Margin = new System.Windows.Forms.Padding(4);
			this.btnPrikaziDetalje.Name = "btnPrikaziDetalje";
			this.btnPrikaziDetalje.Size = new System.Drawing.Size(361, 43);
			this.btnPrikaziDetalje.TabIndex = 13;
			this.btnPrikaziDetalje.Text = "Prikaži sto detaljnije";
			this.btnPrikaziDetalje.UseVisualStyleBackColor = false;
			this.btnPrikaziDetalje.Click += new System.EventHandler(this.btnPrikaziDetalje_Click);
			// 
			// txtKriterijum
			// 
			this.txtKriterijum.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtKriterijum.Location = new System.Drawing.Point(122, 85);
			this.txtKriterijum.Margin = new System.Windows.Forms.Padding(4);
			this.txtKriterijum.Name = "txtKriterijum";
			this.txtKriterijum.Size = new System.Drawing.Size(485, 28);
			this.txtKriterijum.TabIndex = 12;
			// 
			// btnPretraziSto
			// 
			this.btnPretraziSto.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnPretraziSto.BackColor = System.Drawing.Color.White;
			this.btnPretraziSto.ForeColor = System.Drawing.Color.RoyalBlue;
			this.btnPretraziSto.Location = new System.Drawing.Point(246, 175);
			this.btnPretraziSto.Margin = new System.Windows.Forms.Padding(4);
			this.btnPretraziSto.Name = "btnPretraziSto";
			this.btnPretraziSto.Size = new System.Drawing.Size(361, 43);
			this.btnPretraziSto.TabIndex = 6;
			this.btnPretraziSto.Text = "Pretraži sto";
			this.btnPretraziSto.UseVisualStyleBackColor = false;
			this.btnPretraziSto.Click += new System.EventHandler(this.btnPretraziSto_Click);
			// 
			// lblProizvodjac
			// 
			this.lblProizvodjac.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblProizvodjac.AutoSize = true;
			this.lblProizvodjac.Location = new System.Drawing.Point(67, 575);
			this.lblProizvodjac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblProizvodjac.Name = "lblProizvodjac";
			this.lblProizvodjac.Size = new System.Drawing.Size(106, 19);
			this.lblProizvodjac.TabIndex = 2;
			this.lblProizvodjac.Text = "Proizvođač:";
			// 
			// lblCenaStola
			// 
			this.lblCenaStola.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCenaStola.AutoSize = true;
			this.lblCenaStola.Location = new System.Drawing.Point(67, 514);
			this.lblCenaStola.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCenaStola.Name = "lblCenaStola";
			this.lblCenaStola.Size = new System.Drawing.Size(102, 19);
			this.lblCenaStola.TabIndex = 1;
			this.lblCenaStola.Text = "Cena stola:";
			// 
			// lblKapacitet
			// 
			this.lblKapacitet.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblKapacitet.AutoSize = true;
			this.lblKapacitet.Location = new System.Drawing.Point(68, 455);
			this.lblKapacitet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblKapacitet.Name = "lblKapacitet";
			this.lblKapacitet.Size = new System.Drawing.Size(92, 19);
			this.lblKapacitet.TabIndex = 0;
			this.lblKapacitet.Text = "Kapacitet:";
			// 
			// UCPretraziSto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.BackgroundImage = global::Project.Client.Forms.Properties.Resources.UCSto;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.gbPretragaStola);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UCPretraziSto";
			this.Size = new System.Drawing.Size(1185, 713);
			this.Load += new System.EventHandler(this.UCPretraziSto_Load);
			this.gbPretragaStola.ResumeLayout(false);
			this.gbPretragaStola.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStolovi)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPretragaStola;
        private System.Windows.Forms.Button btnPretraziSto;
        private System.Windows.Forms.Label lblProizvodjac;
        private System.Windows.Forms.Label lblCenaStola;
        private System.Windows.Forms.Label lblKapacitet;
        private System.Windows.Forms.Button btnPrikaziDetalje;
        private System.Windows.Forms.TextBox txtKriterijum;
        private System.Windows.Forms.DataGridView dgvStolovi;
		private System.Windows.Forms.Label lblProizvodjacPrikaziVrednost;
		private System.Windows.Forms.Label lblCenaStolaPrikaziVrednost;
		private System.Windows.Forms.Label lblKapacitetPrikaziVrednost;
		private System.Windows.Forms.Label lblNapomena;

		public GroupBox GbPretragaStola { get => gbPretragaStola; set => gbPretragaStola = value; }
		public Button BtnPretraziSto { get => btnPretraziSto; set => btnPretraziSto = value; }
		public Label LblProizvodjac { get => lblProizvodjac; set => lblProizvodjac = value; }
		public Label LblCenaStola { get => lblCenaStola; set => lblCenaStola = value; }
		public Label LblKapacitet { get => lblKapacitet; set => lblKapacitet = value; }
		public Button BtnPrikaziDetalje { get => btnPrikaziDetalje; set => btnPrikaziDetalje = value; }
		public TextBox TxtKriterijum { get => txtKriterijum; set => txtKriterijum = value; }
		public DataGridView DgvStolovi { get => dgvStolovi; set => dgvStolovi = value; }
		public Label LblProizvodjacPrikaziVrednost { get => lblProizvodjacPrikaziVrednost; set => lblProizvodjacPrikaziVrednost = value; }
		public Label LblCenaStolaPrikaziVrednost { get => lblCenaStolaPrikaziVrednost; set => lblCenaStolaPrikaziVrednost = value; }
		public Label LblKapacitetPrikaziVrednost { get => lblKapacitetPrikaziVrednost; set => lblKapacitetPrikaziVrednost = value; }
		public Label Label2 { get => lblNapomena; set => lblNapomena = value; }
	}
}
