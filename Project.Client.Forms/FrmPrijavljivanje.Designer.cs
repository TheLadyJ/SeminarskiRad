using System.Windows.Forms;

namespace Project.Client.Forms
{
    partial class FrmPrijavljivanje
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.lblKorisnickoIme = new System.Windows.Forms.Label();
			this.lblLozinka = new System.Windows.Forms.Label();
			this.txtKorisnikoIme = new System.Windows.Forms.TextBox();
			this.txtLozinka = new System.Windows.Forms.TextBox();
			this.btnPrijaviSe = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblKorisnickoIme
			// 
			this.lblKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblKorisnickoIme.AutoSize = true;
			this.lblKorisnickoIme.BackColor = System.Drawing.Color.Transparent;
			this.lblKorisnickoIme.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblKorisnickoIme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblKorisnickoIme.Location = new System.Drawing.Point(65, 106);
			this.lblKorisnickoIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblKorisnickoIme.Name = "lblKorisnickoIme";
			this.lblKorisnickoIme.Size = new System.Drawing.Size(135, 19);
			this.lblKorisnickoIme.TabIndex = 0;
			this.lblKorisnickoIme.Text = "Korisničko ime:";
			// 
			// lblLozinka
			// 
			this.lblLozinka.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblLozinka.AutoSize = true;
			this.lblLozinka.BackColor = System.Drawing.Color.Transparent;
			this.lblLozinka.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblLozinka.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblLozinka.Location = new System.Drawing.Point(65, 175);
			this.lblLozinka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLozinka.Name = "lblLozinka";
			this.lblLozinka.Size = new System.Drawing.Size(75, 19);
			this.lblLozinka.TabIndex = 1;
			this.lblLozinka.Text = "Lozinka:";
			// 
			// txtKorisnikoIme
			// 
			this.txtKorisnikoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtKorisnikoIme.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtKorisnikoIme.Location = new System.Drawing.Point(276, 102);
			this.txtKorisnikoIme.Margin = new System.Windows.Forms.Padding(4);
			this.txtKorisnikoIme.Name = "txtKorisnikoIme";
			this.txtKorisnikoIme.Size = new System.Drawing.Size(303, 28);
			this.txtKorisnikoIme.TabIndex = 2;
			// 
			// txtLozinka
			// 
			this.txtLozinka.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtLozinka.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtLozinka.Location = new System.Drawing.Point(276, 167);
			this.txtLozinka.Margin = new System.Windows.Forms.Padding(4);
			this.txtLozinka.Name = "txtLozinka";
			this.txtLozinka.PasswordChar = '•';
			this.txtLozinka.Size = new System.Drawing.Size(303, 28);
			this.txtLozinka.TabIndex = 3;
			// 
			// btnPrijaviSe
			// 
			this.btnPrijaviSe.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnPrijaviSe.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnPrijaviSe.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnPrijaviSe.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.btnPrijaviSe.Location = new System.Drawing.Point(160, 270);
			this.btnPrijaviSe.Margin = new System.Windows.Forms.Padding(4);
			this.btnPrijaviSe.Name = "btnPrijaviSe";
			this.btnPrijaviSe.Size = new System.Drawing.Size(276, 50);
			this.btnPrijaviSe.TabIndex = 4;
			this.btnPrijaviSe.Text = "Prijavi se";
			this.btnPrijaviSe.UseVisualStyleBackColor = false;
			this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
			// 
			// FrmPrijavljivanje
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Project.Client.Forms.Properties.Resources.PrijavljivanjePozadina;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(620, 406);
			this.Controls.Add(this.btnPrijaviSe);
			this.Controls.Add(this.txtLozinka);
			this.Controls.Add(this.txtKorisnikoIme);
			this.Controls.Add(this.lblLozinka);
			this.Controls.Add(this.lblKorisnickoIme);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "FrmPrijavljivanje";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Prijavljivanje radnika";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrijavljivanje_FormClosed);
			this.Load += new System.EventHandler(this.FrmPrijavljivanje_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtKorisnikoIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnPrijaviSe;

        public Label LblKorisnickoIme { get => lblKorisnickoIme; set => lblKorisnickoIme = value; }
        public Label LblLozinka { get => lblLozinka; set => lblLozinka = value; }
        public TextBox TxtKorisnikoIme { get => txtKorisnikoIme; set => txtKorisnikoIme = value; }
        public TextBox TxtLozinka { get => txtLozinka; set => txtLozinka = value; }
        public Button BtnPrijaviSe { get => btnPrijaviSe; set => btnPrijaviSe = value; }
    }
}

