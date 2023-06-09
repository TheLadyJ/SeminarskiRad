﻿using System.Windows.Forms;

namespace Project.Client.Forms.UserControls.UCKlijent
{
    partial class UCKreirajNovogKlijenta
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
			this.btnKreirajKlijenta = new System.Windows.Forms.Button();
			this.lblEmail = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblTelefon = new System.Windows.Forms.Label();
			this.txtTelefon = new System.Windows.Forms.TextBox();
			this.lblPrezime = new System.Windows.Forms.Label();
			this.txtPrezime = new System.Windows.Forms.TextBox();
			this.lblIme = new System.Windows.Forms.Label();
			this.txtIme = new System.Windows.Forms.TextBox();
			this.gbKreirajKlijenta.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbKreirajKlijenta
			// 
			this.gbKreirajKlijenta.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gbKreirajKlijenta.BackColor = System.Drawing.Color.Transparent;
			this.gbKreirajKlijenta.Controls.Add(this.btnKreirajKlijenta);
			this.gbKreirajKlijenta.Controls.Add(this.lblEmail);
			this.gbKreirajKlijenta.Controls.Add(this.txtEmail);
			this.gbKreirajKlijenta.Controls.Add(this.lblTelefon);
			this.gbKreirajKlijenta.Controls.Add(this.txtTelefon);
			this.gbKreirajKlijenta.Controls.Add(this.lblPrezime);
			this.gbKreirajKlijenta.Controls.Add(this.txtPrezime);
			this.gbKreirajKlijenta.Controls.Add(this.lblIme);
			this.gbKreirajKlijenta.Controls.Add(this.txtIme);
			this.gbKreirajKlijenta.Font = new System.Drawing.Font("Century Gothic", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.gbKreirajKlijenta.ForeColor = System.Drawing.Color.White;
			this.gbKreirajKlijenta.Location = new System.Drawing.Point(4, 4);
			this.gbKreirajKlijenta.Margin = new System.Windows.Forms.Padding(4);
			this.gbKreirajKlijenta.Name = "gbKreirajKlijenta";
			this.gbKreirajKlijenta.Padding = new System.Windows.Forms.Padding(4);
			this.gbKreirajKlijenta.Size = new System.Drawing.Size(1139, 660);
			this.gbKreirajKlijenta.TabIndex = 0;
			this.gbKreirajKlijenta.TabStop = false;
			this.gbKreirajKlijenta.Text = "Kreiranje novog klijenta";
			// 
			// btnKreirajKlijenta
			// 
			this.btnKreirajKlijenta.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnKreirajKlijenta.BackColor = System.Drawing.Color.White;
			this.btnKreirajKlijenta.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnKreirajKlijenta.ForeColor = System.Drawing.Color.SlateBlue;
			this.btnKreirajKlijenta.Location = new System.Drawing.Point(441, 464);
			this.btnKreirajKlijenta.Margin = new System.Windows.Forms.Padding(4);
			this.btnKreirajKlijenta.Name = "btnKreirajKlijenta";
			this.btnKreirajKlijenta.Size = new System.Drawing.Size(301, 47);
			this.btnKreirajKlijenta.TabIndex = 5;
			this.btnKreirajKlijenta.Text = "Kreiraj novog klijenta";
			this.btnKreirajKlijenta.UseVisualStyleBackColor = false;
			this.btnKreirajKlijenta.Click += new System.EventHandler(this.btnKreirajKlijenta_Click);
			// 
			// lblEmail
			// 
			this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblEmail.Location = new System.Drawing.Point(325, 372);
			this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(66, 23);
			this.lblEmail.TabIndex = 9;
			this.lblEmail.Text = "Email:";
			// 
			// txtEmail
			// 
			this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtEmail.Location = new System.Drawing.Point(495, 362);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(321, 30);
			this.txtEmail.TabIndex = 4;
			// 
			// lblTelefon
			// 
			this.lblTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTelefon.AutoSize = true;
			this.lblTelefon.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblTelefon.ForeColor = System.Drawing.Color.White;
			this.lblTelefon.Location = new System.Drawing.Point(325, 305);
			this.lblTelefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTelefon.Name = "lblTelefon";
			this.lblTelefon.Size = new System.Drawing.Size(80, 23);
			this.lblTelefon.TabIndex = 8;
			this.lblTelefon.Text = "Telefon:";
			// 
			// txtTelefon
			// 
			this.txtTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtTelefon.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtTelefon.Location = new System.Drawing.Point(495, 295);
			this.txtTelefon.Margin = new System.Windows.Forms.Padding(4);
			this.txtTelefon.Name = "txtTelefon";
			this.txtTelefon.Size = new System.Drawing.Size(321, 30);
			this.txtTelefon.TabIndex = 3;
			// 
			// lblPrezime
			// 
			this.lblPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPrezime.AutoSize = true;
			this.lblPrezime.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblPrezime.Location = new System.Drawing.Point(325, 236);
			this.lblPrezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPrezime.Name = "lblPrezime";
			this.lblPrezime.Size = new System.Drawing.Size(88, 23);
			this.lblPrezime.TabIndex = 7;
			this.lblPrezime.Text = "Prezime:";
			// 
			// txtPrezime
			// 
			this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPrezime.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtPrezime.Location = new System.Drawing.Point(495, 226);
			this.txtPrezime.Margin = new System.Windows.Forms.Padding(4);
			this.txtPrezime.Name = "txtPrezime";
			this.txtPrezime.Size = new System.Drawing.Size(321, 30);
			this.txtPrezime.TabIndex = 2;
			// 
			// lblIme
			// 
			this.lblIme.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblIme.AutoSize = true;
			this.lblIme.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblIme.Location = new System.Drawing.Point(325, 171);
			this.lblIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblIme.Name = "lblIme";
			this.lblIme.Size = new System.Drawing.Size(50, 23);
			this.lblIme.TabIndex = 6;
			this.lblIme.Text = "Ime:";
			// 
			// txtIme
			// 
			this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtIme.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtIme.Location = new System.Drawing.Point(495, 161);
			this.txtIme.Margin = new System.Windows.Forms.Padding(4);
			this.txtIme.Name = "txtIme";
			this.txtIme.Size = new System.Drawing.Size(321, 30);
			this.txtIme.TabIndex = 1;
			// 
			// UCKreirajNovogKlijenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.BackgroundImage = global::Project.Client.Forms.Properties.Resources.UCKlijent;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.gbKreirajKlijenta);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UCKreirajNovogKlijenta";
			this.Size = new System.Drawing.Size(1151, 675);
			this.gbKreirajKlijenta.ResumeLayout(false);
			this.gbKreirajKlijenta.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKreirajKlijenta;
        private System.Windows.Forms.Button btnKreirajKlijenta;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIme;

		public GroupBox GbKreirajKlijenta { get => gbKreirajKlijenta; set => gbKreirajKlijenta = value; }
		public Button BtnKreirajKlijenta { get => btnKreirajKlijenta; set => btnKreirajKlijenta = value; }
		public Label LblEmail { get => lblEmail; set => lblEmail = value; }
		public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
		public Label LblTelefon { get => lblTelefon; set => lblTelefon = value; }
		public TextBox TxtTelefon { get => txtTelefon; set => txtTelefon = value; }
		public Label LblPrezime { get => lblPrezime; set => lblPrezime = value; }
		public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
		public Label LblIme { get => lblIme; set => lblIme = value; }
		public TextBox TxtIme { get => txtIme; set => txtIme = value; }
	}
}
