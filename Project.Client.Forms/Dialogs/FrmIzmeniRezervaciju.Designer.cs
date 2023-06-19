using Project.Client.Forms.UserControls.UCRezervacija;
using System.Windows.Forms;

namespace Project.Client.Forms.Dialogs
{
	partial class FrmIzmeniRezervaciju
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIzmeniRezervaciju));
			this.btnIzmeniRezervaciju = new System.Windows.Forms.Button();
			this.ucRadSaRezervacijom = new Project.Client.Forms.UserControls.UCRezervacija.UCRadSaRezervacijom();
			this.SuspendLayout();
			// 
			// btnIzmeniRezervaciju
			// 
			this.btnIzmeniRezervaciju.BackColor = System.Drawing.Color.White;
			this.btnIzmeniRezervaciju.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			this.btnIzmeniRezervaciju.ForeColor = System.Drawing.Color.Brown;
			this.btnIzmeniRezervaciju.Location = new System.Drawing.Point(1122, 671);
			this.btnIzmeniRezervaciju.Name = "btnIzmeniRezervaciju";
			this.btnIzmeniRezervaciju.Size = new System.Drawing.Size(267, 50);
			this.btnIzmeniRezervaciju.TabIndex = 25;
			this.btnIzmeniRezervaciju.Text = "Izmeni rezervaciju";
			this.btnIzmeniRezervaciju.UseVisualStyleBackColor = false;
			this.btnIzmeniRezervaciju.Click += new System.EventHandler(this.btnIzmeniRezervaciju_Click); ;
			// 
			// ucRadSaRezervacijom
			// 
			this.ucRadSaRezervacijom.BackColor = System.Drawing.Color.Transparent;
			this.ucRadSaRezervacijom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ucRadSaRezervacijom.IzabraniMeni = ((Project.Common.Domain.KeteringMeni)(resources.GetObject("ucRadSaRezervacijom.IzabraniMeni")));
			this.ucRadSaRezervacijom.Location = new System.Drawing.Point(26, 16);
			this.ucRadSaRezervacijom.Margin = new System.Windows.Forms.Padding(4);
			this.ucRadSaRezervacijom.Name = "ucRadSaRezervacijom";
			this.ucRadSaRezervacijom.RezervisaniStolovi = ((System.Collections.Generic.List<Project.Common.Domain.RezervisanSto>)(resources.GetObject("ucRadSaRezervacijom.RezervisaniStolovi")));
			this.ucRadSaRezervacijom.Size = new System.Drawing.Size(1411, 778);
			this.ucRadSaRezervacijom.TabIndex = 24;
			// 
			// FrmIzmeniRezervaciju
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Project.Client.Forms.Properties.Resources.UCRezervacija;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1463, 810);
			this.Controls.Add(this.btnIzmeniRezervaciju);
			this.Controls.Add(this.ucRadSaRezervacijom);
			this.MaximizeBox = false;
			this.Name = "FrmIzmeniRezervaciju";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Izmeni rezervaciju";
			this.Load += new System.EventHandler(this.FrmIzmeniRezervaciju_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnIzmeniRezervaciju;
		private UCRadSaRezervacijom ucRadSaRezervacijom;

		public Button BtnIzmeniRezervaciju { get => btnIzmeniRezervaciju; set => btnIzmeniRezervaciju = value; }
		public UCRadSaRezervacijom UcRadSaRezervacijom { get => ucRadSaRezervacijom; set => ucRadSaRezervacijom = value; }
	}
}