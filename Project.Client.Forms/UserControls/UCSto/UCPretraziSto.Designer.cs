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
            this.gbPretragaStola = new System.Windows.Forms.GroupBox();
            this.dgvStolovi = new System.Windows.Forms.DataGridView();
            this.chbProizvodjac = new System.Windows.Forms.CheckBox();
            this.chbCenaStola = new System.Windows.Forms.CheckBox();
            this.chbKapacitet = new System.Windows.Forms.CheckBox();
            this.chbRedniBroj = new System.Windows.Forms.CheckBox();
            this.btnPrikaziDetalje = new System.Windows.Forms.Button();
            this.txtRedniBroj = new System.Windows.Forms.TextBox();
            this.cbProizvodjac = new System.Windows.Forms.ComboBox();
            this.txtCenaStola = new System.Windows.Forms.TextBox();
            this.txtKapacitet = new System.Windows.Forms.TextBox();
            this.txtRedniBrojPrikazi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretraziSto = new System.Windows.Forms.Button();
            this.cbProizvodjacPrikazi = new System.Windows.Forms.ComboBox();
            this.txtCenaStolaPrikazi = new System.Windows.Forms.TextBox();
            this.txtKapacitetPrikazi = new System.Windows.Forms.TextBox();
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
            this.gbPretragaStola.Controls.Add(this.dgvStolovi);
            this.gbPretragaStola.Controls.Add(this.chbProizvodjac);
            this.gbPretragaStola.Controls.Add(this.chbCenaStola);
            this.gbPretragaStola.Controls.Add(this.chbKapacitet);
            this.gbPretragaStola.Controls.Add(this.chbRedniBroj);
            this.gbPretragaStola.Controls.Add(this.btnPrikaziDetalje);
            this.gbPretragaStola.Controls.Add(this.txtRedniBroj);
            this.gbPretragaStola.Controls.Add(this.cbProizvodjac);
            this.gbPretragaStola.Controls.Add(this.txtCenaStola);
            this.gbPretragaStola.Controls.Add(this.txtKapacitet);
            this.gbPretragaStola.Controls.Add(this.txtRedniBrojPrikazi);
            this.gbPretragaStola.Controls.Add(this.label1);
            this.gbPretragaStola.Controls.Add(this.btnPretraziSto);
            this.gbPretragaStola.Controls.Add(this.cbProizvodjacPrikazi);
            this.gbPretragaStola.Controls.Add(this.txtCenaStolaPrikazi);
            this.gbPretragaStola.Controls.Add(this.txtKapacitetPrikazi);
            this.gbPretragaStola.Controls.Add(this.lblProizvodjac);
            this.gbPretragaStola.Controls.Add(this.lblCenaStola);
            this.gbPretragaStola.Controls.Add(this.lblKapacitet);
            this.gbPretragaStola.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPretragaStola.ForeColor = System.Drawing.Color.White;
            this.gbPretragaStola.Location = new System.Drawing.Point(86, 41);
            this.gbPretragaStola.Name = "gbPretragaStola";
            this.gbPretragaStola.Size = new System.Drawing.Size(878, 570);
            this.gbPretragaStola.TabIndex = 1;
            this.gbPretragaStola.TabStop = false;
            this.gbPretragaStola.Text = "Pretraga stola";
            // 
            // dgvStolovi
            // 
            this.dgvStolovi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStolovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStolovi.Location = new System.Drawing.Point(505, 25);
            this.dgvStolovi.Name = "dgvStolovi";
            this.dgvStolovi.RowHeadersWidth = 45;
            this.dgvStolovi.Size = new System.Drawing.Size(327, 521);
            this.dgvStolovi.TabIndex = 18;
            // 
            // chbProizvodjac
            // 
            this.chbProizvodjac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbProizvodjac.AutoSize = true;
            this.chbProizvodjac.Location = new System.Drawing.Point(47, 194);
            this.chbProizvodjac.Name = "chbProizvodjac";
            this.chbProizvodjac.Size = new System.Drawing.Size(109, 22);
            this.chbProizvodjac.TabIndex = 17;
            this.chbProizvodjac.Text = "Proizvođač";
            this.chbProizvodjac.UseVisualStyleBackColor = true;
            // 
            // chbCenaStola
            // 
            this.chbCenaStola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbCenaStola.AutoSize = true;
            this.chbCenaStola.Location = new System.Drawing.Point(47, 145);
            this.chbCenaStola.Name = "chbCenaStola";
            this.chbCenaStola.Size = new System.Drawing.Size(110, 22);
            this.chbCenaStola.TabIndex = 16;
            this.chbCenaStola.Text = "Cena stola:";
            this.chbCenaStola.UseVisualStyleBackColor = true;
            // 
            // chbKapacitet
            // 
            this.chbKapacitet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbKapacitet.AutoSize = true;
            this.chbKapacitet.Location = new System.Drawing.Point(47, 92);
            this.chbKapacitet.Name = "chbKapacitet";
            this.chbKapacitet.Size = new System.Drawing.Size(102, 22);
            this.chbKapacitet.TabIndex = 15;
            this.chbKapacitet.Text = "Kapacitet:";
            this.chbKapacitet.UseVisualStyleBackColor = true;
            // 
            // chbRedniBroj
            // 
            this.chbRedniBroj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbRedniBroj.AutoSize = true;
            this.chbRedniBroj.Location = new System.Drawing.Point(47, 42);
            this.chbRedniBroj.Name = "chbRedniBroj";
            this.chbRedniBroj.Size = new System.Drawing.Size(106, 22);
            this.chbRedniBroj.TabIndex = 14;
            this.chbRedniBroj.Text = "Redni broj:";
            this.chbRedniBroj.UseVisualStyleBackColor = true;
            // 
            // btnPrikaziDetalje
            // 
            this.btnPrikaziDetalje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikaziDetalje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(63)))), ((int)(((byte)(37)))));
            this.btnPrikaziDetalje.Location = new System.Drawing.Point(180, 306);
            this.btnPrikaziDetalje.Name = "btnPrikaziDetalje";
            this.btnPrikaziDetalje.Size = new System.Drawing.Size(271, 35);
            this.btnPrikaziDetalje.TabIndex = 13;
            this.btnPrikaziDetalje.Text = "Prikaži sto detaljnije";
            this.btnPrikaziDetalje.UseVisualStyleBackColor = true;
            // 
            // txtRedniBroj
            // 
            this.txtRedniBroj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRedniBroj.Location = new System.Drawing.Point(180, 38);
            this.txtRedniBroj.Name = "txtRedniBroj";
            this.txtRedniBroj.Size = new System.Drawing.Size(271, 26);
            this.txtRedniBroj.TabIndex = 12;
            // 
            // cbProizvodjac
            // 
            this.cbProizvodjac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbProizvodjac.FormattingEnabled = true;
            this.cbProizvodjac.Location = new System.Drawing.Point(180, 190);
            this.cbProizvodjac.Name = "cbProizvodjac";
            this.cbProizvodjac.Size = new System.Drawing.Size(271, 26);
            this.cbProizvodjac.TabIndex = 11;
            // 
            // txtCenaStola
            // 
            this.txtCenaStola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCenaStola.Location = new System.Drawing.Point(180, 141);
            this.txtCenaStola.Name = "txtCenaStola";
            this.txtCenaStola.Size = new System.Drawing.Size(271, 26);
            this.txtCenaStola.TabIndex = 10;
            // 
            // txtKapacitet
            // 
            this.txtKapacitet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKapacitet.Location = new System.Drawing.Point(180, 88);
            this.txtKapacitet.Name = "txtKapacitet";
            this.txtKapacitet.Size = new System.Drawing.Size(271, 26);
            this.txtKapacitet.TabIndex = 9;
            // 
            // txtRedniBrojPrikazi
            // 
            this.txtRedniBrojPrikazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRedniBrojPrikazi.Location = new System.Drawing.Point(180, 366);
            this.txtRedniBrojPrikazi.Name = "txtRedniBrojPrikazi";
            this.txtRedniBrojPrikazi.ReadOnly = true;
            this.txtRedniBrojPrikazi.Size = new System.Drawing.Size(271, 26);
            this.txtRedniBrojPrikazi.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Redni broj:";
            // 
            // btnPretraziSto
            // 
            this.btnPretraziSto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretraziSto.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnPretraziSto.Location = new System.Drawing.Point(180, 247);
            this.btnPretraziSto.Name = "btnPretraziSto";
            this.btnPretraziSto.Size = new System.Drawing.Size(271, 35);
            this.btnPretraziSto.TabIndex = 6;
            this.btnPretraziSto.Text = "Pretraži sto";
            this.btnPretraziSto.UseVisualStyleBackColor = true;
            // 
            // cbProizvodjacPrikazi
            // 
            this.cbProizvodjacPrikazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbProizvodjacPrikazi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProizvodjacPrikazi.FormattingEnabled = true;
            this.cbProizvodjacPrikazi.Location = new System.Drawing.Point(180, 511);
            this.cbProizvodjacPrikazi.Name = "cbProizvodjacPrikazi";
            this.cbProizvodjacPrikazi.Size = new System.Drawing.Size(271, 26);
            this.cbProizvodjacPrikazi.TabIndex = 5;
            // 
            // txtCenaStolaPrikazi
            // 
            this.txtCenaStolaPrikazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCenaStolaPrikazi.Location = new System.Drawing.Point(180, 462);
            this.txtCenaStolaPrikazi.Name = "txtCenaStolaPrikazi";
            this.txtCenaStolaPrikazi.ReadOnly = true;
            this.txtCenaStolaPrikazi.Size = new System.Drawing.Size(271, 26);
            this.txtCenaStolaPrikazi.TabIndex = 4;
            // 
            // txtKapacitetPrikazi
            // 
            this.txtKapacitetPrikazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKapacitetPrikazi.Location = new System.Drawing.Point(180, 409);
            this.txtKapacitetPrikazi.Name = "txtKapacitetPrikazi";
            this.txtKapacitetPrikazi.ReadOnly = true;
            this.txtKapacitetPrikazi.Size = new System.Drawing.Size(271, 26);
            this.txtKapacitetPrikazi.TabIndex = 3;
            // 
            // lblProizvodjac
            // 
            this.lblProizvodjac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProizvodjac.AutoSize = true;
            this.lblProizvodjac.Location = new System.Drawing.Point(44, 519);
            this.lblProizvodjac.Name = "lblProizvodjac";
            this.lblProizvodjac.Size = new System.Drawing.Size(94, 18);
            this.lblProizvodjac.TabIndex = 2;
            this.lblProizvodjac.Text = "Proizvođač:";
            // 
            // lblCenaStola
            // 
            this.lblCenaStola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCenaStola.AutoSize = true;
            this.lblCenaStola.Location = new System.Drawing.Point(44, 470);
            this.lblCenaStola.Name = "lblCenaStola";
            this.lblCenaStola.Size = new System.Drawing.Size(91, 18);
            this.lblCenaStola.TabIndex = 1;
            this.lblCenaStola.Text = "Cena stola:";
            // 
            // lblKapacitet
            // 
            this.lblKapacitet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKapacitet.AutoSize = true;
            this.lblKapacitet.Location = new System.Drawing.Point(44, 417);
            this.lblKapacitet.Name = "lblKapacitet";
            this.lblKapacitet.Size = new System.Drawing.Size(83, 18);
            this.lblKapacitet.TabIndex = 0;
            this.lblKapacitet.Text = "Kapacitet:";
            // 
            // UCPretraziSto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Project.Client.Forms.Properties.Resources.UCSto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.gbPretragaStola);
            this.Name = "UCPretraziSto";
            this.Size = new System.Drawing.Size(1023, 640);
            this.gbPretragaStola.ResumeLayout(false);
            this.gbPretragaStola.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStolovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPretragaStola;
        private System.Windows.Forms.Button btnPretraziSto;
        private System.Windows.Forms.ComboBox cbProizvodjacPrikazi;
        private System.Windows.Forms.TextBox txtCenaStolaPrikazi;
        private System.Windows.Forms.TextBox txtKapacitetPrikazi;
        private System.Windows.Forms.Label lblProizvodjac;
        private System.Windows.Forms.Label lblCenaStola;
        private System.Windows.Forms.Label lblKapacitet;
        private System.Windows.Forms.Button btnPrikaziDetalje;
        private System.Windows.Forms.TextBox txtRedniBroj;
        private System.Windows.Forms.ComboBox cbProizvodjac;
        private System.Windows.Forms.TextBox txtCenaStola;
        private System.Windows.Forms.TextBox txtKapacitet;
        private System.Windows.Forms.TextBox txtRedniBrojPrikazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbProizvodjac;
        private System.Windows.Forms.CheckBox chbCenaStola;
        private System.Windows.Forms.CheckBox chbKapacitet;
        private System.Windows.Forms.CheckBox chbRedniBroj;
        private System.Windows.Forms.DataGridView dgvStolovi;
    }
}
