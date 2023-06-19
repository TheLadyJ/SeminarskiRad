namespace Project.Server.Main
{
    partial class FrmServer
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
			this.btnPokreniServer = new System.Windows.Forms.Button();
			this.btnZaustaviServer = new System.Windows.Forms.Button();
			this.lblStatusServera = new System.Windows.Forms.Label();
			this.lblStatusServeraVrednost = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnPokreniServer
			// 
			this.btnPokreniServer.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnPokreniServer.BackColor = System.Drawing.Color.White;
			this.btnPokreniServer.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnPokreniServer.ForeColor = System.Drawing.Color.RoyalBlue;
			this.btnPokreniServer.Location = new System.Drawing.Point(152, 169);
			this.btnPokreniServer.Margin = new System.Windows.Forms.Padding(4);
			this.btnPokreniServer.Name = "btnPokreniServer";
			this.btnPokreniServer.Size = new System.Drawing.Size(276, 50);
			this.btnPokreniServer.TabIndex = 5;
			this.btnPokreniServer.Text = "Pokreni server";
			this.btnPokreniServer.UseVisualStyleBackColor = false;
			this.btnPokreniServer.Click += new System.EventHandler(this.btnPokreniServer_Click);
			// 
			// btnZaustaviServer
			// 
			this.btnZaustaviServer.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnZaustaviServer.BackColor = System.Drawing.Color.White;
			this.btnZaustaviServer.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnZaustaviServer.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnZaustaviServer.Location = new System.Drawing.Point(505, 169);
			this.btnZaustaviServer.Margin = new System.Windows.Forms.Padding(4);
			this.btnZaustaviServer.Name = "btnZaustaviServer";
			this.btnZaustaviServer.Size = new System.Drawing.Size(276, 50);
			this.btnZaustaviServer.TabIndex = 6;
			this.btnZaustaviServer.Text = "Zaustavi server";
			this.btnZaustaviServer.UseVisualStyleBackColor = false;
			this.btnZaustaviServer.Click += new System.EventHandler(this.btnZaustaviServer_Click);
			// 
			// lblStatusServera
			// 
			this.lblStatusServera.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblStatusServera.AutoSize = true;
			this.lblStatusServera.BackColor = System.Drawing.Color.Transparent;
			this.lblStatusServera.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblStatusServera.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblStatusServera.Location = new System.Drawing.Point(176, 283);
			this.lblStatusServera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblStatusServera.Name = "lblStatusServera";
			this.lblStatusServera.Size = new System.Drawing.Size(126, 19);
			this.lblStatusServera.TabIndex = 7;
			this.lblStatusServera.Text = "Status servera:";
			// 
			// lblStatusServeraVrednost
			// 
			this.lblStatusServeraVrednost.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblStatusServeraVrednost.BackColor = System.Drawing.SystemColors.Window;
			this.lblStatusServeraVrednost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblStatusServeraVrednost.Font = new System.Drawing.Font("Century Gothic", 10.18868F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.lblStatusServeraVrednost.ForeColor = System.Drawing.Color.Salmon;
			this.lblStatusServeraVrednost.Location = new System.Drawing.Point(368, 274);
			this.lblStatusServeraVrednost.Name = "lblStatusServeraVrednost";
			this.lblStatusServeraVrednost.Size = new System.Drawing.Size(413, 28);
			this.lblStatusServeraVrednost.TabIndex = 36;
			this.lblStatusServeraVrednost.Text = "Nije pokrenut";
			this.lblStatusServeraVrednost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Project.Server.Main.Properties.Resources.ServerPozadina;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(957, 490);
			this.Controls.Add(this.lblStatusServeraVrednost);
			this.Controls.Add(this.lblStatusServera);
			this.Controls.Add(this.btnZaustaviServer);
			this.Controls.Add(this.btnPokreniServer);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "FrmServer";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Server";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmServer_FormClosed);
			this.Load += new System.EventHandler(this.FrmServer_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPokreniServer;
        private System.Windows.Forms.Button btnZaustaviServer;
        private System.Windows.Forms.Label lblStatusServera;
		private System.Windows.Forms.Label lblStatusServeraVrednost;
	}
}

