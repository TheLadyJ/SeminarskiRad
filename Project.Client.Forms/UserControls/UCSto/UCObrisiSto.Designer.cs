namespace Project.Client.Forms.UserControls.UCSto
{
    partial class UCObrisiSto
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
            this.gbBrisanjeStola = new System.Windows.Forms.GroupBox();
            this.dgvStolovi = new System.Windows.Forms.DataGridView();
            this.chbProizvodjac = new System.Windows.Forms.CheckBox();
            this.chbCenaStola = new System.Windows.Forms.CheckBox();
            this.chbKapacitet = new System.Windows.Forms.CheckBox();
            this.chbRedniBroj = new System.Windows.Forms.CheckBox();
            this.txtRedniBroj = new System.Windows.Forms.TextBox();
            this.cbProizvodjac = new System.Windows.Forms.ComboBox();
            this.txtCenaStola = new System.Windows.Forms.TextBox();
            this.txtKapacitet = new System.Windows.Forms.TextBox();
            this.btnPretraziSto = new System.Windows.Forms.Button();
            this.btnObrisiSto = new System.Windows.Forms.Button();
            this.gbBrisanjeStola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStolovi)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBrisanjeStola
            // 
            this.gbBrisanjeStola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbBrisanjeStola.BackColor = System.Drawing.Color.Transparent;
            this.gbBrisanjeStola.Controls.Add(this.btnObrisiSto);
            this.gbBrisanjeStola.Controls.Add(this.dgvStolovi);
            this.gbBrisanjeStola.Controls.Add(this.chbProizvodjac);
            this.gbBrisanjeStola.Controls.Add(this.chbCenaStola);
            this.gbBrisanjeStola.Controls.Add(this.chbKapacitet);
            this.gbBrisanjeStola.Controls.Add(this.chbRedniBroj);
            this.gbBrisanjeStola.Controls.Add(this.txtRedniBroj);
            this.gbBrisanjeStola.Controls.Add(this.cbProizvodjac);
            this.gbBrisanjeStola.Controls.Add(this.txtCenaStola);
            this.gbBrisanjeStola.Controls.Add(this.txtKapacitet);
            this.gbBrisanjeStola.Controls.Add(this.btnPretraziSto);
            this.gbBrisanjeStola.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbBrisanjeStola.ForeColor = System.Drawing.Color.White;
            this.gbBrisanjeStola.Location = new System.Drawing.Point(90, 45);
            this.gbBrisanjeStola.Name = "gbBrisanjeStola";
            this.gbBrisanjeStola.Size = new System.Drawing.Size(955, 601);
            this.gbBrisanjeStola.TabIndex = 2;
            this.gbBrisanjeStola.TabStop = false;
            this.gbBrisanjeStola.Text = "Brisanje stola";
            // 
            // dgvStolovi
            // 
            this.dgvStolovi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStolovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStolovi.Location = new System.Drawing.Point(59, 235);
            this.dgvStolovi.Name = "dgvStolovi";
            this.dgvStolovi.RowHeadersWidth = 45;
            this.dgvStolovi.Size = new System.Drawing.Size(840, 327);
            this.dgvStolovi.TabIndex = 18;
            // 
            // chbProizvodjac
            // 
            this.chbProizvodjac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbProizvodjac.AutoSize = true;
            this.chbProizvodjac.Location = new System.Drawing.Point(495, 107);
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
            this.chbCenaStola.Location = new System.Drawing.Point(495, 58);
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
            this.chbKapacitet.Location = new System.Drawing.Point(59, 108);
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
            this.chbRedniBroj.Location = new System.Drawing.Point(59, 58);
            this.chbRedniBroj.Name = "chbRedniBroj";
            this.chbRedniBroj.Size = new System.Drawing.Size(106, 22);
            this.chbRedniBroj.TabIndex = 14;
            this.chbRedniBroj.Text = "Redni broj:";
            this.chbRedniBroj.UseVisualStyleBackColor = true;
            // 
            // txtRedniBroj
            // 
            this.txtRedniBroj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRedniBroj.Location = new System.Drawing.Point(192, 54);
            this.txtRedniBroj.Name = "txtRedniBroj";
            this.txtRedniBroj.Size = new System.Drawing.Size(271, 26);
            this.txtRedniBroj.TabIndex = 12;
            // 
            // cbProizvodjac
            // 
            this.cbProizvodjac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbProizvodjac.FormattingEnabled = true;
            this.cbProizvodjac.Location = new System.Drawing.Point(628, 103);
            this.cbProizvodjac.Name = "cbProizvodjac";
            this.cbProizvodjac.Size = new System.Drawing.Size(271, 26);
            this.cbProizvodjac.TabIndex = 11;
            // 
            // txtCenaStola
            // 
            this.txtCenaStola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCenaStola.Location = new System.Drawing.Point(628, 56);
            this.txtCenaStola.Name = "txtCenaStola";
            this.txtCenaStola.Size = new System.Drawing.Size(271, 26);
            this.txtCenaStola.TabIndex = 10;
            // 
            // txtKapacitet
            // 
            this.txtKapacitet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKapacitet.Location = new System.Drawing.Point(192, 104);
            this.txtKapacitet.Name = "txtKapacitet";
            this.txtKapacitet.Size = new System.Drawing.Size(271, 26);
            this.txtKapacitet.TabIndex = 9;
            // 
            // btnPretraziSto
            // 
            this.btnPretraziSto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretraziSto.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnPretraziSto.Location = new System.Drawing.Point(59, 169);
            this.btnPretraziSto.Name = "btnPretraziSto";
            this.btnPretraziSto.Size = new System.Drawing.Size(271, 35);
            this.btnPretraziSto.TabIndex = 6;
            this.btnPretraziSto.Text = "Pretraži sto";
            this.btnPretraziSto.UseVisualStyleBackColor = true;
            // 
            // btnObrisiSto
            // 
            this.btnObrisiSto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiSto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(63)))), ((int)(((byte)(37)))));
            this.btnObrisiSto.Location = new System.Drawing.Point(357, 169);
            this.btnObrisiSto.Name = "btnObrisiSto";
            this.btnObrisiSto.Size = new System.Drawing.Size(271, 35);
            this.btnObrisiSto.TabIndex = 19;
            this.btnObrisiSto.Text = "Obriši sto";
            this.btnObrisiSto.UseVisualStyleBackColor = true;
            // 
            // UCObrisiSto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Project.Client.Forms.Properties.Resources.UCSto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.gbBrisanjeStola);
            this.Name = "UCObrisiSto";
            this.Size = new System.Drawing.Size(1130, 679);
            this.gbBrisanjeStola.ResumeLayout(false);
            this.gbBrisanjeStola.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStolovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBrisanjeStola;
        private System.Windows.Forms.DataGridView dgvStolovi;
        private System.Windows.Forms.CheckBox chbProizvodjac;
        private System.Windows.Forms.CheckBox chbCenaStola;
        private System.Windows.Forms.CheckBox chbKapacitet;
        private System.Windows.Forms.CheckBox chbRedniBroj;
        private System.Windows.Forms.TextBox txtRedniBroj;
        private System.Windows.Forms.ComboBox cbProizvodjac;
        private System.Windows.Forms.TextBox txtCenaStola;
        private System.Windows.Forms.TextBox txtKapacitet;
        private System.Windows.Forms.Button btnPretraziSto;
        private System.Windows.Forms.Button btnObrisiSto;
    }
}
