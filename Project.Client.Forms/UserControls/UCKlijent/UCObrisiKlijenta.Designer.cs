namespace Project.Client.Forms.UserControls.UCKlijent
{
    partial class UCObrisiKlijenta
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
			this.txtIme = new System.Windows.Forms.TextBox();
			this.txtTelefon = new System.Windows.Forms.TextBox();
			this.txtPrezime = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.chbIme = new System.Windows.Forms.CheckBox();
			this.chbTelefon = new System.Windows.Forms.CheckBox();
			this.chbEmail = new System.Windows.Forms.CheckBox();
			this.chbPrezime = new System.Windows.Forms.CheckBox();
			this.dgvKlijenti = new System.Windows.Forms.DataGridView();
			this.btnPretraziKlijenta = new System.Windows.Forms.Button();
			this.btnObrisiKlijenta = new System.Windows.Forms.Button();
			this.gbPretraziKlijenta = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
			this.gbPretraziKlijenta.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtIme
			// 
			this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtIme.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtIme.Location = new System.Drawing.Point(217, 74);
			this.txtIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtIme.Name = "txtIme";
			this.txtIme.Size = new System.Drawing.Size(343, 28);
			this.txtIme.TabIndex = 0;
			// 
			// txtTelefon
			// 
			this.txtTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtTelefon.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtTelefon.Location = new System.Drawing.Point(752, 74);
			this.txtTelefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtTelefon.Name = "txtTelefon";
			this.txtTelefon.Size = new System.Drawing.Size(343, 28);
			this.txtTelefon.TabIndex = 2;
			// 
			// txtPrezime
			// 
			this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPrezime.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtPrezime.Location = new System.Drawing.Point(217, 134);
			this.txtPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtPrezime.Name = "txtPrezime";
			this.txtPrezime.Size = new System.Drawing.Size(343, 28);
			this.txtPrezime.TabIndex = 4;
			// 
			// txtEmail
			// 
			this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtEmail.Location = new System.Drawing.Point(752, 134);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(343, 28);
			this.txtEmail.TabIndex = 6;
			// 
			// chbIme
			// 
			this.chbIme.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.chbIme.AutoSize = true;
			this.chbIme.BackColor = System.Drawing.Color.Transparent;
			this.chbIme.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.chbIme.Location = new System.Drawing.Point(53, 79);
			this.chbIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chbIme.Name = "chbIme";
			this.chbIme.Size = new System.Drawing.Size(68, 23);
			this.chbIme.TabIndex = 9;
			this.chbIme.Text = "Ime:";
			this.chbIme.UseVisualStyleBackColor = false;
			// 
			// chbTelefon
			// 
			this.chbTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.chbTelefon.AutoSize = true;
			this.chbTelefon.BackColor = System.Drawing.Color.Transparent;
			this.chbTelefon.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.chbTelefon.ForeColor = System.Drawing.Color.White;
			this.chbTelefon.Location = new System.Drawing.Point(604, 79);
			this.chbTelefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chbTelefon.Name = "chbTelefon";
			this.chbTelefon.Size = new System.Drawing.Size(95, 23);
			this.chbTelefon.TabIndex = 10;
			this.chbTelefon.Text = "Telefon:";
			this.chbTelefon.UseVisualStyleBackColor = false;
			// 
			// chbEmail
			// 
			this.chbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.chbEmail.AutoSize = true;
			this.chbEmail.BackColor = System.Drawing.Color.Transparent;
			this.chbEmail.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.chbEmail.ForeColor = System.Drawing.Color.White;
			this.chbEmail.Location = new System.Drawing.Point(604, 137);
			this.chbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chbEmail.Name = "chbEmail";
			this.chbEmail.Size = new System.Drawing.Size(80, 23);
			this.chbEmail.TabIndex = 11;
			this.chbEmail.Text = "Email:";
			this.chbEmail.UseVisualStyleBackColor = false;
			// 
			// chbPrezime
			// 
			this.chbPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.chbPrezime.AutoSize = true;
			this.chbPrezime.BackColor = System.Drawing.Color.Transparent;
			this.chbPrezime.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.chbPrezime.Location = new System.Drawing.Point(53, 132);
			this.chbPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chbPrezime.Name = "chbPrezime";
			this.chbPrezime.Size = new System.Drawing.Size(101, 23);
			this.chbPrezime.TabIndex = 12;
			this.chbPrezime.Text = "Prezime:";
			this.chbPrezime.UseVisualStyleBackColor = false;
			// 
			// dgvKlijenti
			// 
			this.dgvKlijenti.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKlijenti.Location = new System.Drawing.Point(53, 281);
			this.dgvKlijenti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvKlijenti.Name = "dgvKlijenti";
			this.dgvKlijenti.ReadOnly = true;
			this.dgvKlijenti.RowHeadersWidth = 45;
			this.dgvKlijenti.Size = new System.Drawing.Size(1043, 402);
			this.dgvKlijenti.TabIndex = 13;
			// 
			// btnPretraziKlijenta
			// 
			this.btnPretraziKlijenta.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnPretraziKlijenta.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnPretraziKlijenta.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.btnPretraziKlijenta.Location = new System.Drawing.Point(53, 213);
			this.btnPretraziKlijenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnPretraziKlijenta.Name = "btnPretraziKlijenta";
			this.btnPretraziKlijenta.Size = new System.Drawing.Size(323, 39);
			this.btnPretraziKlijenta.TabIndex = 14;
			this.btnPretraziKlijenta.Text = "Pretraži klijenta za brisanje";
			this.btnPretraziKlijenta.UseVisualStyleBackColor = false;
			// 
			// btnObrisiKlijenta
			// 
			this.btnObrisiKlijenta.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnObrisiKlijenta.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnObrisiKlijenta.ForeColor = System.Drawing.Color.SlateBlue;
			this.btnObrisiKlijenta.Location = new System.Drawing.Point(419, 213);
			this.btnObrisiKlijenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnObrisiKlijenta.Name = "btnObrisiKlijenta";
			this.btnObrisiKlijenta.Size = new System.Drawing.Size(323, 39);
			this.btnObrisiKlijenta.TabIndex = 19;
			this.btnObrisiKlijenta.Text = "Obriši klijenta";
			this.btnObrisiKlijenta.UseVisualStyleBackColor = false;
			// 
			// gbPretraziKlijenta
			// 
			this.gbPretraziKlijenta.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gbPretraziKlijenta.BackColor = System.Drawing.Color.Transparent;
			this.gbPretraziKlijenta.Controls.Add(this.btnObrisiKlijenta);
			this.gbPretraziKlijenta.Controls.Add(this.btnPretraziKlijenta);
			this.gbPretraziKlijenta.Controls.Add(this.dgvKlijenti);
			this.gbPretraziKlijenta.Controls.Add(this.chbPrezime);
			this.gbPretraziKlijenta.Controls.Add(this.chbEmail);
			this.gbPretraziKlijenta.Controls.Add(this.chbTelefon);
			this.gbPretraziKlijenta.Controls.Add(this.chbIme);
			this.gbPretraziKlijenta.Controls.Add(this.txtEmail);
			this.gbPretraziKlijenta.Controls.Add(this.txtPrezime);
			this.gbPretraziKlijenta.Controls.Add(this.txtTelefon);
			this.gbPretraziKlijenta.Controls.Add(this.txtIme);
			this.gbPretraziKlijenta.Font = new System.Drawing.Font("Century Gothic", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.gbPretraziKlijenta.ForeColor = System.Drawing.Color.White;
			this.gbPretraziKlijenta.Location = new System.Drawing.Point(4, 4);
			this.gbPretraziKlijenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbPretraziKlijenta.Name = "gbPretraziKlijenta";
			this.gbPretraziKlijenta.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbPretraziKlijenta.Size = new System.Drawing.Size(1148, 719);
			this.gbPretraziKlijenta.TabIndex = 2;
			this.gbPretraziKlijenta.TabStop = false;
			this.gbPretraziKlijenta.Text = "Brisanje klijenta";
			// 
			// UCObrisiKlijenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.BackgroundImage = global::Project.Client.Forms.Properties.Resources.UCKlijent;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.gbPretraziKlijenta);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "UCObrisiKlijenta";
			this.Size = new System.Drawing.Size(1160, 736);
			((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
			this.gbPretraziKlijenta.ResumeLayout(false);
			this.gbPretraziKlijenta.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox chbIme;
        private System.Windows.Forms.CheckBox chbTelefon;
        private System.Windows.Forms.CheckBox chbEmail;
        private System.Windows.Forms.CheckBox chbPrezime;
        private System.Windows.Forms.DataGridView dgvKlijenti;
        private System.Windows.Forms.Button btnPretraziKlijenta;
        private System.Windows.Forms.Button btnObrisiKlijenta;
        private System.Windows.Forms.GroupBox gbPretraziKlijenta;
    }
}
