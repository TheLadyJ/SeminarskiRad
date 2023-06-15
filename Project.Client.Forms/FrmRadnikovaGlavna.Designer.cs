namespace Project.Client.Forms
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
            this.pnlMain = new System.Windows.Forms.Panel();
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
            this.menuStrip1.Size = new System.Drawing.Size(1172, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.menuStrip.Size = new System.Drawing.Size(74, 25);
            this.menuStrip.Text = "Klijenti";
            // 
            // kreirajNovogKlijentaToolStripMenuItem
            // 
            this.kreirajNovogKlijentaToolStripMenuItem.Name = "kreirajNovogKlijentaToolStripMenuItem";
            this.kreirajNovogKlijentaToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.kreirajNovogKlijentaToolStripMenuItem.Text = "Kreiraj novog klijenta";
            this.kreirajNovogKlijentaToolStripMenuItem.Click += new System.EventHandler(this.kreirajNovogKlijentaToolStripMenuItem_Click);
            // 
            // pretraziKlijentaToolStripMenuItem
            // 
            this.pretraziKlijentaToolStripMenuItem.Name = "pretraziKlijentaToolStripMenuItem";
            this.pretraziKlijentaToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.pretraziKlijentaToolStripMenuItem.Text = "Pretraži klijenta";
            this.pretraziKlijentaToolStripMenuItem.Click += new System.EventHandler(this.pretraziKlijentaToolStripMenuItem_Click);
            // 
            // obrisiKlijentaToolStripMenuItem
            // 
            this.obrisiKlijentaToolStripMenuItem.Name = "obrisiKlijentaToolStripMenuItem";
            this.obrisiKlijentaToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.obrisiKlijentaToolStripMenuItem.Text = "Obriši klijenta";
            this.obrisiKlijentaToolStripMenuItem.Click += new System.EventHandler(this.obrisiKlijentaToolStripMenuItem_Click);
            // 
            // stoToolStripMenuItem
            // 
            this.stoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unesiNoviStoToolStripMenuItem,
            this.pretraziStoToolStripMenuItem,
            this.obrisiStoToolStripMenuItem});
            this.stoToolStripMenuItem.Name = "stoToolStripMenuItem";
            this.stoToolStripMenuItem.Size = new System.Drawing.Size(50, 25);
            this.stoToolStripMenuItem.Text = "Sto";
            // 
            // unesiNoviStoToolStripMenuItem
            // 
            this.unesiNoviStoToolStripMenuItem.Name = "unesiNoviStoToolStripMenuItem";
            this.unesiNoviStoToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.unesiNoviStoToolStripMenuItem.Text = "Unesi novi sto";
            this.unesiNoviStoToolStripMenuItem.Click += new System.EventHandler(this.unesiNoviStoToolStripMenuItem_Click);
            // 
            // pretraziStoToolStripMenuItem
            // 
            this.pretraziStoToolStripMenuItem.Name = "pretraziStoToolStripMenuItem";
            this.pretraziStoToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.pretraziStoToolStripMenuItem.Text = "Pretraži sto";
            this.pretraziStoToolStripMenuItem.Click += new System.EventHandler(this.pretraziStoToolStripMenuItem_Click);
            // 
            // obrisiStoToolStripMenuItem
            // 
            this.obrisiStoToolStripMenuItem.Name = "obrisiStoToolStripMenuItem";
            this.obrisiStoToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.obrisiStoToolStripMenuItem.Text = "Obriši sto";
            this.obrisiStoToolStripMenuItem.Click += new System.EventHandler(this.obrisiStoToolStripMenuItem_Click);
            // 
            // rezervacijeToolStripMenuItem
            // 
            this.rezervacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajNovuRezervacijuToolStripMenuItem,
            this.izmeniRezervacijuToolStripMenuItem,
            this.obrisiRezervacijuToolStripMenuItem});
            this.rezervacijeToolStripMenuItem.Name = "rezervacijeToolStripMenuItem";
            this.rezervacijeToolStripMenuItem.Size = new System.Drawing.Size(119, 25);
            this.rezervacijeToolStripMenuItem.Text = "Rezervacije";
            // 
            // kreirajNovuRezervacijuToolStripMenuItem
            // 
            this.kreirajNovuRezervacijuToolStripMenuItem.Name = "kreirajNovuRezervacijuToolStripMenuItem";
            this.kreirajNovuRezervacijuToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.kreirajNovuRezervacijuToolStripMenuItem.Text = "Kreiraj novu rezervaciju";
            // 
            // izmeniRezervacijuToolStripMenuItem
            // 
            this.izmeniRezervacijuToolStripMenuItem.Name = "izmeniRezervacijuToolStripMenuItem";
            this.izmeniRezervacijuToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.izmeniRezervacijuToolStripMenuItem.Text = "Izmeni rezervaciju";
            // 
            // obrisiRezervacijuToolStripMenuItem
            // 
            this.obrisiRezervacijuToolStripMenuItem.Name = "obrisiRezervacijuToolStripMenuItem";
            this.obrisiRezervacijuToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.obrisiRezervacijuToolStripMenuItem.Text = "Obriši rezervaciju";
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = global::Project.Client.Forms.Properties.Resources.PrijavljivanjePozadina;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 29);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1172, 621);
            this.pnlMain.TabIndex = 1;
            // 
            // FrmRadnikovaGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 650);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmRadnikovaGlavna";
            this.ShowIcon = false;
            this.Text = "Glavna forma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRadnikovaGlavna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlMain;
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