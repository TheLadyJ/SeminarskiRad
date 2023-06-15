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
			this.gbKreirajKlijenta = new System.Windows.Forms.GroupBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblTelefon = new System.Windows.Forms.Label();
			this.lblPrezime = new System.Windows.Forms.Label();
			this.lblIme = new System.Windows.Forms.Label();
			this.btnPrikaziDetaljno = new System.Windows.Forms.Button();
			this.btnPretraziKlijenta = new System.Windows.Forms.Button();
			this.dgvKlijenti = new System.Windows.Forms.DataGridView();
			this.chbPrezime = new System.Windows.Forms.CheckBox();
			this.chbEmail = new System.Windows.Forms.CheckBox();
			this.chbTelefon = new System.Windows.Forms.CheckBox();
			this.chbIme = new System.Windows.Forms.CheckBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtPrezime = new System.Windows.Forms.TextBox();
			this.txtTelefon = new System.Windows.Forms.TextBox();
			this.txtIme = new System.Windows.Forms.TextBox();
			this.lblImePrikaziVrednost = new System.Windows.Forms.Label();
			this.lblPrezimePrikaziVrednost = new System.Windows.Forms.Label();
			this.lblTelefonPrikaziVrednost = new System.Windows.Forms.Label();
			this.lblEmailPrikaziVrednost = new System.Windows.Forms.Label();
			this.gbKreirajKlijenta.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
			this.SuspendLayout();
			// 
			// gbKreirajKlijenta
			// 
			this.gbKreirajKlijenta.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gbKreirajKlijenta.BackColor = System.Drawing.Color.Transparent;
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
			this.gbKreirajKlijenta.Controls.Add(this.chbPrezime);
			this.gbKreirajKlijenta.Controls.Add(this.chbEmail);
			this.gbKreirajKlijenta.Controls.Add(this.chbTelefon);
			this.gbKreirajKlijenta.Controls.Add(this.chbIme);
			this.gbKreirajKlijenta.Controls.Add(this.txtEmail);
			this.gbKreirajKlijenta.Controls.Add(this.txtPrezime);
			this.gbKreirajKlijenta.Controls.Add(this.txtTelefon);
			this.gbKreirajKlijenta.Controls.Add(this.txtIme);
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
			// lblEmail
			// 
			this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblEmail.Location = new System.Drawing.Point(84, 638);
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
			this.lblTelefon.Location = new System.Drawing.Point(84, 580);
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
			this.lblPrezime.Location = new System.Drawing.Point(84, 517);
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
			this.lblIme.Location = new System.Drawing.Point(84, 464);
			this.lblIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblIme.Name = "lblIme";
			this.lblIme.Size = new System.Drawing.Size(46, 19);
			this.lblIme.TabIndex = 20;
			this.lblIme.Text = "Ime:";
			// 
			// btnPrikaziDetaljno
			// 
			this.btnPrikaziDetaljno.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnPrikaziDetaljno.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnPrikaziDetaljno.ForeColor = System.Drawing.Color.SlateBlue;
			this.btnPrikaziDetaljno.Location = new System.Drawing.Point(273, 389);
			this.btnPrikaziDetaljno.Margin = new System.Windows.Forms.Padding(4);
			this.btnPrikaziDetaljno.Name = "btnPrikaziDetaljno";
			this.btnPrikaziDetaljno.Size = new System.Drawing.Size(323, 39);
			this.btnPrikaziDetaljno.TabIndex = 19;
			this.btnPrikaziDetaljno.Text = "Prikaži klijenta detaljnije";
			this.btnPrikaziDetaljno.UseVisualStyleBackColor = false;
			// 
			// btnPretraziKlijenta
			// 
			this.btnPretraziKlijenta.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnPretraziKlijenta.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnPretraziKlijenta.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.btnPretraziKlijenta.Location = new System.Drawing.Point(273, 316);
			this.btnPretraziKlijenta.Margin = new System.Windows.Forms.Padding(4);
			this.btnPretraziKlijenta.Name = "btnPretraziKlijenta";
			this.btnPretraziKlijenta.Size = new System.Drawing.Size(323, 39);
			this.btnPretraziKlijenta.TabIndex = 14;
			this.btnPretraziKlijenta.Text = "Pretraži klijenta";
			this.btnPretraziKlijenta.UseVisualStyleBackColor = false;
			// 
			// dgvKlijenti
			// 
			this.dgvKlijenti.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKlijenti.Location = new System.Drawing.Point(689, 54);
			this.dgvKlijenti.Margin = new System.Windows.Forms.Padding(4);
			this.dgvKlijenti.Name = "dgvKlijenti";
			this.dgvKlijenti.ReadOnly = true;
			this.dgvKlijenti.RowHeadersWidth = 45;
			this.dgvKlijenti.Size = new System.Drawing.Size(383, 629);
			this.dgvKlijenti.TabIndex = 13;
			// 
			// chbPrezime
			// 
			this.chbPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.chbPrezime.AutoSize = true;
			this.chbPrezime.BackColor = System.Drawing.Color.Transparent;
			this.chbPrezime.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.chbPrezime.Location = new System.Drawing.Point(88, 132);
			this.chbPrezime.Margin = new System.Windows.Forms.Padding(4);
			this.chbPrezime.Name = "chbPrezime";
			this.chbPrezime.Size = new System.Drawing.Size(101, 23);
			this.chbPrezime.TabIndex = 12;
			this.chbPrezime.Text = "Prezime:";
			this.chbPrezime.UseVisualStyleBackColor = false;
			// 
			// chbEmail
			// 
			this.chbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.chbEmail.AutoSize = true;
			this.chbEmail.BackColor = System.Drawing.Color.Transparent;
			this.chbEmail.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.chbEmail.ForeColor = System.Drawing.Color.White;
			this.chbEmail.Location = new System.Drawing.Point(88, 252);
			this.chbEmail.Margin = new System.Windows.Forms.Padding(4);
			this.chbEmail.Name = "chbEmail";
			this.chbEmail.Size = new System.Drawing.Size(80, 23);
			this.chbEmail.TabIndex = 11;
			this.chbEmail.Text = "Email:";
			this.chbEmail.UseVisualStyleBackColor = false;
			// 
			// chbTelefon
			// 
			this.chbTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.chbTelefon.AutoSize = true;
			this.chbTelefon.BackColor = System.Drawing.Color.Transparent;
			this.chbTelefon.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.chbTelefon.ForeColor = System.Drawing.Color.White;
			this.chbTelefon.Location = new System.Drawing.Point(88, 194);
			this.chbTelefon.Margin = new System.Windows.Forms.Padding(4);
			this.chbTelefon.Name = "chbTelefon";
			this.chbTelefon.Size = new System.Drawing.Size(95, 23);
			this.chbTelefon.TabIndex = 10;
			this.chbTelefon.Text = "Telefon:";
			this.chbTelefon.UseVisualStyleBackColor = false;
			// 
			// chbIme
			// 
			this.chbIme.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.chbIme.AutoSize = true;
			this.chbIme.BackColor = System.Drawing.Color.Transparent;
			this.chbIme.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.chbIme.Location = new System.Drawing.Point(88, 79);
			this.chbIme.Margin = new System.Windows.Forms.Padding(4);
			this.chbIme.Name = "chbIme";
			this.chbIme.Size = new System.Drawing.Size(68, 23);
			this.chbIme.TabIndex = 9;
			this.chbIme.Text = "Ime:";
			this.chbIme.UseVisualStyleBackColor = false;
			// 
			// txtEmail
			// 
			this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtEmail.Location = new System.Drawing.Point(273, 247);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(321, 28);
			this.txtEmail.TabIndex = 6;
			// 
			// txtPrezime
			// 
			this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPrezime.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtPrezime.Location = new System.Drawing.Point(273, 127);
			this.txtPrezime.Margin = new System.Windows.Forms.Padding(4);
			this.txtPrezime.Name = "txtPrezime";
			this.txtPrezime.Size = new System.Drawing.Size(321, 28);
			this.txtPrezime.TabIndex = 4;
			// 
			// txtTelefon
			// 
			this.txtTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtTelefon.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtTelefon.Location = new System.Drawing.Point(273, 190);
			this.txtTelefon.Margin = new System.Windows.Forms.Padding(4);
			this.txtTelefon.Name = "txtTelefon";
			this.txtTelefon.Size = new System.Drawing.Size(321, 28);
			this.txtTelefon.TabIndex = 2;
			// 
			// txtIme
			// 
			this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtIme.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtIme.Location = new System.Drawing.Point(273, 74);
			this.txtIme.Margin = new System.Windows.Forms.Padding(4);
			this.txtIme.Name = "txtIme";
			this.txtIme.Size = new System.Drawing.Size(321, 28);
			this.txtIme.TabIndex = 0;
			// 
			// lblImePrikaziVrednost
			// 
			this.lblImePrikaziVrednost.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblImePrikaziVrednost.BackColor = System.Drawing.SystemColors.Window;
			this.lblImePrikaziVrednost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblImePrikaziVrednost.Location = new System.Drawing.Point(273, 456);
			this.lblImePrikaziVrednost.Name = "lblImePrikaziVrednost";
			this.lblImePrikaziVrednost.Size = new System.Drawing.Size(323, 27);
			this.lblImePrikaziVrednost.TabIndex = 36;
			this.lblImePrikaziVrednost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPrezimePrikaziVrednost
			// 
			this.lblPrezimePrikaziVrednost.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPrezimePrikaziVrednost.BackColor = System.Drawing.SystemColors.Window;
			this.lblPrezimePrikaziVrednost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPrezimePrikaziVrednost.Location = new System.Drawing.Point(273, 509);
			this.lblPrezimePrikaziVrednost.Name = "lblPrezimePrikaziVrednost";
			this.lblPrezimePrikaziVrednost.Size = new System.Drawing.Size(323, 27);
			this.lblPrezimePrikaziVrednost.TabIndex = 37;
			this.lblPrezimePrikaziVrednost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTelefonPrikaziVrednost
			// 
			this.lblTelefonPrikaziVrednost.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTelefonPrikaziVrednost.BackColor = System.Drawing.SystemColors.Window;
			this.lblTelefonPrikaziVrednost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTelefonPrikaziVrednost.Location = new System.Drawing.Point(273, 572);
			this.lblTelefonPrikaziVrednost.Name = "lblTelefonPrikaziVrednost";
			this.lblTelefonPrikaziVrednost.Size = new System.Drawing.Size(323, 27);
			this.lblTelefonPrikaziVrednost.TabIndex = 38;
			this.lblTelefonPrikaziVrednost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEmailPrikaziVrednost
			// 
			this.lblEmailPrikaziVrednost.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblEmailPrikaziVrednost.BackColor = System.Drawing.SystemColors.Window;
			this.lblEmailPrikaziVrednost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblEmailPrikaziVrednost.Location = new System.Drawing.Point(273, 630);
			this.lblEmailPrikaziVrednost.Name = "lblEmailPrikaziVrednost";
			this.lblEmailPrikaziVrednost.Size = new System.Drawing.Size(323, 27);
			this.lblEmailPrikaziVrednost.TabIndex = 39;
			this.lblEmailPrikaziVrednost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
        private System.Windows.Forms.CheckBox chbPrezime;
        private System.Windows.Forms.CheckBox chbEmail;
        private System.Windows.Forms.CheckBox chbTelefon;
        private System.Windows.Forms.CheckBox chbIme;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtIme;
		private System.Windows.Forms.Label lblEmailPrikaziVrednost;
		private System.Windows.Forms.Label lblTelefonPrikaziVrednost;
		private System.Windows.Forms.Label lblPrezimePrikaziVrednost;
		private System.Windows.Forms.Label lblImePrikaziVrednost;
	}
}
