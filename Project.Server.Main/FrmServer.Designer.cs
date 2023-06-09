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
            this.txtStatusServera = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPokreniServer
            // 
            this.btnPokreniServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPokreniServer.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPokreniServer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnPokreniServer.Location = new System.Drawing.Point(114, 137);
            this.btnPokreniServer.Name = "btnPokreniServer";
            this.btnPokreniServer.Size = new System.Drawing.Size(207, 41);
            this.btnPokreniServer.TabIndex = 5;
            this.btnPokreniServer.Text = "Pokreni server";
            this.btnPokreniServer.UseVisualStyleBackColor = true;
            this.btnPokreniServer.Click += new System.EventHandler(this.btnPokreniServer_Click);
            // 
            // btnZaustaviServer
            // 
            this.btnZaustaviServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZaustaviServer.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaustaviServer.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnZaustaviServer.Location = new System.Drawing.Point(379, 137);
            this.btnZaustaviServer.Name = "btnZaustaviServer";
            this.btnZaustaviServer.Size = new System.Drawing.Size(207, 41);
            this.btnZaustaviServer.TabIndex = 6;
            this.btnZaustaviServer.Text = "Zaustavi server";
            this.btnZaustaviServer.UseVisualStyleBackColor = true;
            this.btnZaustaviServer.Click += new System.EventHandler(this.btnZaustaviServer_Click);
            // 
            // lblStatusServera
            // 
            this.lblStatusServera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatusServera.AutoSize = true;
            this.lblStatusServera.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusServera.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatusServera.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStatusServera.Location = new System.Drawing.Point(132, 230);
            this.lblStatusServera.Name = "lblStatusServera";
            this.lblStatusServera.Size = new System.Drawing.Size(111, 18);
            this.lblStatusServera.TabIndex = 7;
            this.lblStatusServera.Text = "Status servera:";
            // 
            // txtStatusServera
            // 
            this.txtStatusServera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStatusServera.BackColor = System.Drawing.Color.White;
            this.txtStatusServera.Font = new System.Drawing.Font("Century Gothic", 10.18868F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtStatusServera.ForeColor = System.Drawing.Color.Salmon;
            this.txtStatusServera.Location = new System.Drawing.Point(276, 227);
            this.txtStatusServera.Name = "txtStatusServera";
            this.txtStatusServera.ReadOnly = true;
            this.txtStatusServera.Size = new System.Drawing.Size(310, 26);
            this.txtStatusServera.TabIndex = 8;
            this.txtStatusServera.Text = "Nije pokrenut";
            this.txtStatusServera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Server.Main.Properties.Resources.ServerPozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 398);
            this.Controls.Add(this.txtStatusServera);
            this.Controls.Add(this.lblStatusServera);
            this.Controls.Add(this.btnZaustaviServer);
            this.Controls.Add(this.btnPokreniServer);
            this.Name = "FrmServer";
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
        private System.Windows.Forms.TextBox txtStatusServera;
    }
}

