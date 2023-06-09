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
            this.txtIme.Location = new System.Drawing.Point(163, 60);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(258, 26);
            this.txtIme.TabIndex = 0;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefon.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTelefon.Location = new System.Drawing.Point(564, 60);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(258, 26);
            this.txtTelefon.TabIndex = 2;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrezime.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrezime.Location = new System.Drawing.Point(163, 109);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(258, 26);
            this.txtPrezime.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEmail.Location = new System.Drawing.Point(564, 109);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(258, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // chbIme
            // 
            this.chbIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbIme.AutoSize = true;
            this.chbIme.BackColor = System.Drawing.Color.Transparent;
            this.chbIme.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbIme.Location = new System.Drawing.Point(40, 64);
            this.chbIme.Name = "chbIme";
            this.chbIme.Size = new System.Drawing.Size(59, 22);
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
            this.chbTelefon.Location = new System.Drawing.Point(453, 64);
            this.chbTelefon.Name = "chbTelefon";
            this.chbTelefon.Size = new System.Drawing.Size(84, 22);
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
            this.chbEmail.Location = new System.Drawing.Point(453, 111);
            this.chbEmail.Name = "chbEmail";
            this.chbEmail.Size = new System.Drawing.Size(71, 22);
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
            this.chbPrezime.Location = new System.Drawing.Point(40, 107);
            this.chbPrezime.Name = "chbPrezime";
            this.chbPrezime.Size = new System.Drawing.Size(89, 22);
            this.chbPrezime.TabIndex = 12;
            this.chbPrezime.Text = "Prezime:";
            this.chbPrezime.UseVisualStyleBackColor = false;
            // 
            // dgvKlijenti
            // 
            this.dgvKlijenti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijenti.Location = new System.Drawing.Point(40, 228);
            this.dgvKlijenti.Name = "dgvKlijenti";
            this.dgvKlijenti.ReadOnly = true;
            this.dgvKlijenti.RowHeadersWidth = 45;
            this.dgvKlijenti.Size = new System.Drawing.Size(782, 327);
            this.dgvKlijenti.TabIndex = 13;
            // 
            // btnPretraziKlijenta
            // 
            this.btnPretraziKlijenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretraziKlijenta.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnPretraziKlijenta.Location = new System.Drawing.Point(40, 173);
            this.btnPretraziKlijenta.Name = "btnPretraziKlijenta";
            this.btnPretraziKlijenta.Size = new System.Drawing.Size(242, 32);
            this.btnPretraziKlijenta.TabIndex = 14;
            this.btnPretraziKlijenta.Text = "Pretraži klijenta za brisanje";
            this.btnPretraziKlijenta.UseVisualStyleBackColor = true;
            // 
            // btnObrisiKlijenta
            // 
            this.btnObrisiKlijenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiKlijenta.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnObrisiKlijenta.Location = new System.Drawing.Point(314, 173);
            this.btnObrisiKlijenta.Name = "btnObrisiKlijenta";
            this.btnObrisiKlijenta.Size = new System.Drawing.Size(242, 32);
            this.btnObrisiKlijenta.TabIndex = 19;
            this.btnObrisiKlijenta.Text = "Obriši klijenta";
            this.btnObrisiKlijenta.UseVisualStyleBackColor = true;
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
            this.gbPretraziKlijenta.Location = new System.Drawing.Point(49, 23);
            this.gbPretraziKlijenta.Name = "gbPretraziKlijenta";
            this.gbPretraziKlijenta.Size = new System.Drawing.Size(861, 584);
            this.gbPretraziKlijenta.TabIndex = 2;
            this.gbPretraziKlijenta.TabStop = false;
            this.gbPretraziKlijenta.Text = "Brisanje klijenta";
            // 
            // UCObrisiKlijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Project.Client.Forms.Properties.Resources.UCKlijent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.gbPretraziKlijenta);
            this.Name = "UCObrisiKlijenta";
            this.Size = new System.Drawing.Size(958, 631);
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
