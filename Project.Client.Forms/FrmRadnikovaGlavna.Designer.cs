﻿namespace Project.Client.Forms
{
    partial class FrmRadnikovaGlavna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajNovogKlijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraziKlijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiKlijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unesiNoviStoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraziStoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiStoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajNovuRezervacijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniRezervacijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiRezervacijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip,
            this.stoToolStripMenuItem,
            this.rezervacijeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Project.Client.Forms.Properties.Resources.PrijavljivanjePozadina;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 500);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajNovogKlijentaToolStripMenuItem,
            this.pretraziKlijentaToolStripMenuItem,
            this.obrisiKlijentaToolStripMenuItem});
            this.menuStrip.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip.ForeColor = System.Drawing.SystemColors.MenuText;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(66, 24);
            this.menuStrip.Text = "Klijenti";
            // 
            // kreirajNovogKlijentaToolStripMenuItem
            // 
            this.kreirajNovogKlijentaToolStripMenuItem.Name = "kreirajNovogKlijentaToolStripMenuItem";
            this.kreirajNovogKlijentaToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.kreirajNovogKlijentaToolStripMenuItem.Text = "Kreiraj novog klijenta";
            this.kreirajNovogKlijentaToolStripMenuItem.Click += new System.EventHandler(this.kreirajNovogKlijentaToolStripMenuItem_Click);
            // 
            // pretraziKlijentaToolStripMenuItem
            // 
            this.pretraziKlijentaToolStripMenuItem.Name = "pretraziKlijentaToolStripMenuItem";
            this.pretraziKlijentaToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.pretraziKlijentaToolStripMenuItem.Text = "Pretraži klijenta";
            // 
            // obrisiKlijentaToolStripMenuItem
            // 
            this.obrisiKlijentaToolStripMenuItem.Name = "obrisiKlijentaToolStripMenuItem";
            this.obrisiKlijentaToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.obrisiKlijentaToolStripMenuItem.Text = "Obriši klijenta";
            // 
            // stoToolStripMenuItem
            // 
            this.stoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unesiNoviStoToolStripMenuItem,
            this.pretraziStoToolStripMenuItem,
            this.obrisiStoToolStripMenuItem});
            this.stoToolStripMenuItem.Name = "stoToolStripMenuItem";
            this.stoToolStripMenuItem.Size = new System.Drawing.Size(43, 24);
            this.stoToolStripMenuItem.Text = "Sto";
            // 
            // unesiNoviStoToolStripMenuItem
            // 
            this.unesiNoviStoToolStripMenuItem.Name = "unesiNoviStoToolStripMenuItem";
            this.unesiNoviStoToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.unesiNoviStoToolStripMenuItem.Text = "Unesi novi sto";
            // 
            // pretraziStoToolStripMenuItem
            // 
            this.pretraziStoToolStripMenuItem.Name = "pretraziStoToolStripMenuItem";
            this.pretraziStoToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.pretraziStoToolStripMenuItem.Text = "Pretraži sto";
            // 
            // obrisiStoToolStripMenuItem
            // 
            this.obrisiStoToolStripMenuItem.Name = "obrisiStoToolStripMenuItem";
            this.obrisiStoToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.obrisiStoToolStripMenuItem.Text = "Obriši sto";
            // 
            // rezervacijeToolStripMenuItem
            // 
            this.rezervacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajNovuRezervacijuToolStripMenuItem,
            this.izmeniRezervacijuToolStripMenuItem,
            this.obrisiRezervacijuToolStripMenuItem});
            this.rezervacijeToolStripMenuItem.Name = "rezervacijeToolStripMenuItem";
            this.rezervacijeToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.rezervacijeToolStripMenuItem.Text = "Rezervacije";
            // 
            // kreirajNovuRezervacijuToolStripMenuItem
            // 
            this.kreirajNovuRezervacijuToolStripMenuItem.Name = "kreirajNovuRezervacijuToolStripMenuItem";
            this.kreirajNovuRezervacijuToolStripMenuItem.Size = new System.Drawing.Size(256, 24);
            this.kreirajNovuRezervacijuToolStripMenuItem.Text = "Kreiraj novu rezervaciju";
            // 
            // izmeniRezervacijuToolStripMenuItem
            // 
            this.izmeniRezervacijuToolStripMenuItem.Name = "izmeniRezervacijuToolStripMenuItem";
            this.izmeniRezervacijuToolStripMenuItem.Size = new System.Drawing.Size(256, 24);
            this.izmeniRezervacijuToolStripMenuItem.Text = "Izmeni rezervaciju";
            // 
            // obrisiRezervacijuToolStripMenuItem
            // 
            this.obrisiRezervacijuToolStripMenuItem.Name = "obrisiRezervacijuToolStripMenuItem";
            this.obrisiRezervacijuToolStripMenuItem.Size = new System.Drawing.Size(256, 24);
            this.obrisiRezervacijuToolStripMenuItem.Text = "Obriši rezervaciju";
            // 
            // FrmRadnikovaGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmRadnikovaGlavna";
            this.Text = "FrmRadnikovaGlavna";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem menuStrip;
        private System.Windows.Forms.ToolStripMenuItem kreirajNovogKlijentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretraziKlijentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiKlijentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unesiNoviStoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretraziStoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiStoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajNovuRezervacijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniRezervacijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiRezervacijuToolStripMenuItem;
    }
}