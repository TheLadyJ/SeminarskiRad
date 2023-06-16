using System.Windows.Forms;

namespace Project.Client.Forms.UserControls.UCKlijent
{
    partial class UCPretraziKlijetnta
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
			this.gbKreirajKlijenta = new System.Windows.Forms.GroupBox();
			this.lblNapomena = new System.Windows.Forms.Label();
			this.lblEmailPrikaziVrednost = new System.Windows.Forms.Label();
			this.lblTelefonPrikaziVrednost = new System.Windows.Forms.Label();
			this.lblPrezimePrikaziVrednost = new System.Windows.Forms.Label();
			this.lblImePrikaziVrednost = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblTelefon = new System.Windows.Forms.Label();
			this.lblPrezime = new System.Windows.Forms.Label();
			this.lblIme = new System.Windows.Forms.Label();
			this.btnPrikaziDetaljno = new System.Windows.Forms.Button();
			this.btnPretraziKlijenta = new System.Windows.Forms.Button();
			this.dgvKlijenti = new System.Windows.Forms.DataGridView();
			this.txtKriterijum = new System.Windows.Forms.TextBox();
			this.gbKreirajKlijenta.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
			this.SuspendLayout();
			// 
			// gbKreirajKlijenta
			// 
			this.gbKreirajKlijenta.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gbKreirajKlijenta.BackColor = System.Drawing.Color.Transparent;
			this.gbKreirajKlijenta.Controls.Add(this.lblNapomena);
			this.gbKreirajKlijenta.Controls.Add(this.lblEmailPrikaziVrednost);
			this.gbKreirajKlijenta.Controls.Add(this.lblTelefonPrikaziVrednost);
			this.gbKreirajKlijenta.Controls.Add(this.lblPrezimePrikaziVrednost);
			this.gbKreirajKlijenta.Controls.Add(this.lblImePrikaziVrednost);
			this.gbKreirajKlijenta.Controls.Add(this.lblEmail);
			this.gbKreirajKlijenta.Controls.Add(this.lblTelefon);
			this.gbKreirajKlijenta.Controls.Add(this.lblPrezime);
			this.gbKreirajKlijenta.Controls.Add(this.lblIme);
			this.gbKreirajKlijenta.Controls.Add(this.btnPrikaziDetaljno);
			this.gbKreirajKlijenta.Controls.Add(this.btnPretraziKlijenta);
			this.gbKreirajKlijenta.Controls.Add(this.dgvKlijenti);
			this.gbKreirajKlijenta.Controls.Add(this.txtKriterijum);
			this.gbKreirajKlijenta.Font = new System.Drawing.Font("Century Gothic", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.gbKreirajKlijenta.ForeColor = System.Drawing.Color.White;
			this.gbKreirajKlijenta.Location = new System.Drawing.Point(4, 4);
			this.gbKreirajKlijenta.Margin = new System.Windows.Forms.Padding(4);
			this.gbKreirajKlijenta.Name = "gbKreirajKlijenta";
			this.gbKreirajKlijenta.Padding = new System.Windows.Forms.Padding(4);
			this.gbKreirajKlijenta.Size = new System.Drawing.Size(1148, 719);
			this.gbKreirajKlijenta.TabIndex = 3;
			this.gbKreirajKlijenta.TabStop = false;
			this.gbKreirajKlijenta.Text = "Pretraga klijenta";
			// 
			// lblNapomena
			// 
			this.lblNapomena.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNapomena.AutoSize = true;
			this.lblNapomena.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblNapomena.Location = new System.Drawing.Point(70, 142);
			this.lblNapomena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNapomena.Name = "lblNapomena";
			this.lblNapomena.Size = new System.Drawing.Size(526, 21);
			this.lblNapomena.TabIndex = 40;
			this.lblNapomena.Text = "(Moguće je pretražiti po imenu, prezimenu, telefonu ili email-u)";
			// 
			// lblEmailPrikaziVrednost
			// 
			this.lblEmailPrikaziVrednost.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblEmailPrikaziVrednost.BackColor = System.Drawing.SystemColors.Window;
			this.lblEmailPrikaziVrednost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblEmailPrikaziVrednost.Font = new System.Drawing.Font("Century Gothic", 8.830189F, System.Drawing.FontStyle.Bold);
			this.lblEmailPrikaziVrednost.ForeColor = System.Drawing.Color.Black;
			this.lblEmailPrikaziVrednost.Location = new System.Drawing.Point(273, 591);
			this.lblEmailPrikaziVrednost.Name = "lblEmailPrikaziVrednost";
			this.lblEmailPrikaziVrednost.Size = new System.Drawing.Size(323, 27);
			this.lblEmailPrikaziVrednost.TabIndex = 39;
			this.lblEmailPrikaziVrednost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTelefonPrikaziVrednost
			// 
			this.lblTelefonPrikaziVrednost.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTelefonPrikaziVrednost.BackColor = System.Drawing.SystemColors.Window;
			this.lblTelefonPrikaziVrednost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTelefonPrikaziVrednost.Font = new System.Drawing.Font("Century Gothic", 8.830189F, System.Drawing.FontStyle.Bold);
			this.lblTelefonPrikaziVrednost.ForeColor = System.Drawing.Color.Black;
			this.lblTelefonPrikaziVrednost.Location = new System.Drawing.Point(273, 533);
			this.lblTelefonPrikaziVrednost.Name = "lblTelefonPrikaziVrednost";
			this.lblTelefonPrikaziVrednost.Size = new System.Drawing.Size(323, 27);
			this.lblTelefonPrikaziVrednost.TabIndex = 38;
			this.lblTelefonPrikaziVrednost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPrezimePrikaziVrednost
			// 
			this.lblPrezimePrikaziVrednost.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPrezimePrikaziVrednost.BackColor = System.Drawing.SystemColors.Window;
			this.lblPrezimePrikaziVrednost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPrezimePrikaziVrednost.Font = new System.Drawing.Font("Century Gothic", 8.830189F, System.Drawing.FontStyle.Bold);
			this.lblPrezimePrikaziVrednost.ForeColor = System.Drawing.Color.Black;
			this.lblPrezimePrikaziVrednost.Location = new System.Drawing.Point(273, 470);
			this.lblPrezimePrikaziVrednost.Name = "lblPrezimePrikaziVrednost";
			this.lblPrezimePrikaziVrednost.Size = new System.Drawing.Size(323, 27);
			this.lblPrezimePrikaziVrednost.TabIndex = 37;
			this.lblPrezimePrikaziVrednost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblImePrikaziVrednost
			// 
			this.lblImePrikaziVrednost.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblImePrikaziVrednost.BackColor = System.Drawing.SystemColors.Window;
			this.lblImePrikaziVrednost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblImePrikaziVrednost.Font = new System.Drawing.Font("Century Gothic", 8.830189F, System.Drawing.FontStyle.Bold);
			this.lblImePrikaziVrednost.ForeColor = System.Drawing.Color.Black;
			this.lblImePrikaziVrednost.Location = new System.Drawing.Point(273, 417);
			this.lblImePrikaziVrednost.Name = "lblImePrikaziVrednost";
			this.lblImePrikaziVrednost.Size = new System.Drawing.Size(323, 27);
			this.lblImePrikaziVrednost.TabIndex = 36;
			this.lblImePrikaziVrednost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEmail
			// 
			this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblEmail.Location = new System.Drawing.Point(84, 599);
			this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(58, 19);
			this.lblEmail.TabIndex = 23;
			this.lblEmail.Text = "Email:";
			// 
			// lblTelefon
			// 
			this.lblTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTelefon.AutoSize = true;
			this.lblTelefon.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblTelefon.Location = new System.Drawing.Point(84, 541);
			this.lblTelefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTelefon.Name = "lblTelefon";
			this.lblTelefon.Size = new System.Drawing.Size(73, 19);
			this.lblTelefon.TabIndex = 22;
			this.lblTelefon.Text = "Telefon:";
			// 
			// lblPrezime
			// 
			this.lblPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPrezime.AutoSize = true;
			this.lblPrezime.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblPrezime.Location = new System.Drawing.Point(84, 478);
			this.lblPrezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPrezime.Name = "lblPrezime";
			this.lblPrezime.Size = new System.Drawing.Size(79, 19);
			this.lblPrezime.TabIndex = 21;
			this.lblPrezime.Text = "Prezime:";
			// 
			// lblIme
			// 
			this.lblIme.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblIme.AutoSize = true;
			this.lblIme.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblIme.Location = new System.Drawing.Point(84, 425);
			this.lblIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblIme.Name = "lblIme";
			this.lblIme.Size = new System.Drawing.Size(46, 19);
			this.lblIme.TabIndex = 20;
			this.lblIme.Text = "Ime:";
			// 
			// btnPrikaziDetaljno
			// 
			this.btnPrikaziDetaljno.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnPrikaziDetaljno.BackColor = System.Drawing.Color.White;
			this.btnPrikaziDetaljno.ForeColor = System.Drawing.Color.SlateBlue;
			this.btnPrikaziDetaljno.Location = new System.Drawing.Point(273, 350);
			this.btnPrikaziDetaljno.Margin = new System.Windows.Forms.Padding(4);
			this.btnPrikaziDetaljno.Name = "btnPrikaziDetaljno";
			this.btnPrikaziDetaljno.Size = new System.Drawing.Size(323, 39);
			this.btnPrikaziDetaljno.TabIndex = 19;
			this.btnPrikaziDetaljno.Text = "Prikaži klijenta detaljnije";
			this.btnPrikaziDetaljno.UseVisualStyleBackColor = false;
			this.btnPrikaziDetaljno.Click += new System.EventHandler(this.btnPrikaziDetaljno_Click);
			// 
			// btnPretraziKlijenta
			// 
			this.btnPretraziKlijenta.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnPretraziKlijenta.BackColor = System.Drawing.Color.White;
			this.btnPretraziKlijenta.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.btnPretraziKlijenta.Location = new System.Drawing.Point(273, 183);
			this.btnPretraziKlijenta.Margin = new System.Windows.Forms.Padding(4);
			this.btnPretraziKlijenta.Name = "btnPretraziKlijenta";
			this.btnPretraziKlijenta.Size = new System.Drawing.Size(323, 39);
			this.btnPretraziKlijenta.TabIndex = 14;
			this.btnPretraziKlijenta.Text = "Pretraži klijenta";
			this.btnPretraziKlijenta.UseVisualStyleBackColor = false;
			this.btnPretraziKlijenta.Click += new System.EventHandler(this.btnPretraziKlijenta_Click);
			// 
			// dgvKlijenti
			// 
			this.dgvKlijenti.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvKlijenti.BackgroundColor = System.Drawing.Color.White;
			this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKlijenti.Location = new System.Drawing.Point(689, 54);
			this.dgvKlijenti.Margin = new System.Windows.Forms.Padding(4);
			this.dgvKlijenti.Name = "dgvKlijenti";
			this.dgvKlijenti.ReadOnly = true;
			this.dgvKlijenti.RowHeadersWidth = 45;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.830189F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			this.dgvKlijenti.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvKlijenti.Size = new System.Drawing.Size(383, 629);
			this.dgvKlijenti.TabIndex = 13;
			// 
			// txtKriterijum
			// 
			this.txtKriterijum.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtKriterijum.Font = new System.Drawing.Font("Century Gothic", 8.830189F, System.Drawing.FontStyle.Bold);
			this.txtKriterijum.ForeColor = System.Drawing.Color.Black;
			this.txtKriterijum.Location = new System.Drawing.Point(88, 103);
			this.txtKriterijum.Margin = new System.Windows.Forms.Padding(4);
			this.txtKriterijum.Name = "txtKriterijum";
			this.txtKriterijum.Size = new System.Drawing.Size(508, 26);
			this.txtKriterijum.TabIndex = 0;
			// 
			// UCPretraziKlijetnta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Project.Client.Forms.Properties.Resources.UCKlijent;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.gbKreirajKlijenta);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UCPretraziKlijetnta";
			this.Size = new System.Drawing.Size(1163, 735);
			this.Load += new System.EventHandler(this.UCPretraziKlijetnta_Load);
			this.gbKreirajKlijenta.ResumeLayout(false);
			this.gbKreirajKlijenta.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKreirajKlijenta;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Button btnPrikaziDetaljno;
        private System.Windows.Forms.Button btnPretraziKlijenta;
        private System.Windows.Forms.DataGridView dgvKlijenti;
        private System.Windows.Forms.TextBox txtKriterijum;
		private System.Windows.Forms.Label lblEmailPrikaziVrednost;
		private System.Windows.Forms.Label lblTelefonPrikaziVrednost;
		private System.Windows.Forms.Label lblPrezimePrikaziVrednost;
		private System.Windows.Forms.Label lblImePrikaziVrednost;
		private Label lblNapomena;

		public GroupBox GbKreirajKlijenta { get => gbKreirajKlijenta; set => gbKreirajKlijenta = value; }
		public Label LblEmail { get => lblEmail; set => lblEmail = value; }
		public Label LblTelefon { get => lblTelefon; set => lblTelefon = value; }
		public Label LblPrezime { get => lblPrezime; set => lblPrezime = value; }
		public Label LblIme { get => lblIme; set => lblIme = value; }
		public Button BtnPrikaziDetaljno { get => btnPrikaziDetaljno; set => btnPrikaziDetaljno = value; }
		public Button BtnPretraziKlijenta { get => btnPretraziKlijenta; set => btnPretraziKlijenta = value; }
		public DataGridView DgvKlijenti { get => dgvKlijenti; set => dgvKlijenti = value; }
		public TextBox TxtKriterijum { get => txtKriterijum; set => txtKriterijum = value; }
		public Label LblEmailPrikaziVrednost { get => lblEmailPrikaziVrednost; set => lblEmailPrikaziVrednost = value; }
		public Label LblTelefonPrikaziVrednost { get => lblTelefonPrikaziVrednost; set => lblTelefonPrikaziVrednost = value; }
		public Label LblPrezimePrikaziVrednost { get => lblPrezimePrikaziVrednost; set => lblPrezimePrikaziVrednost = value; }
		public Label LblImePrikaziVrednost { get => lblImePrikaziVrednost; set => lblImePrikaziVrednost = value; }
	}
}
