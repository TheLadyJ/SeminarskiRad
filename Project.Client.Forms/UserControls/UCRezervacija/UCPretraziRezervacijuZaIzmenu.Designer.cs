﻿using System.Windows.Forms;

namespace Project.Client.Forms.UserControls.UCRezervacija
{
	partial class UCPretraziRezervacijuZaIzmenu
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
			this.btnIzmeniRezervaciju = new System.Windows.Forms.Button();
			this.ucPretragaRezervacija = new Project.Client.Forms.UserControls.UCRezervacija.UCPretragaRezervacija();
			this.SuspendLayout();
			// 
			// btnIzmeniRezervaciju
			// 
			this.btnIzmeniRezervaciju.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnIzmeniRezervaciju.AutoSize = true;
			this.btnIzmeniRezervaciju.BackColor = System.Drawing.Color.White;
			this.btnIzmeniRezervaciju.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			this.btnIzmeniRezervaciju.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(44)))), ((int)(((byte)(126)))));
			this.btnIzmeniRezervaciju.Location = new System.Drawing.Point(1103, 813);
			this.btnIzmeniRezervaciju.Name = "btnIzmeniRezervaciju";
			this.btnIzmeniRezervaciju.Size = new System.Drawing.Size(352, 50);
			this.btnIzmeniRezervaciju.TabIndex = 26;
			this.btnIzmeniRezervaciju.Text = "Izmeni odabranu rezervaciju";
			this.btnIzmeniRezervaciju.UseVisualStyleBackColor = false;
			this.btnIzmeniRezervaciju.Click += new System.EventHandler(this.btnIzmeniRezervaciju_Click);
			// 
			// ucPretragaRezervacija
			// 
			this.ucPretragaRezervacija.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ucPretragaRezervacija.AutoSize = true;
			this.ucPretragaRezervacija.BackColor = System.Drawing.Color.Transparent;
			this.ucPretragaRezervacija.Location = new System.Drawing.Point(3, 3);
			this.ucPretragaRezervacija.Name = "ucPretragaRezervacija";
			this.ucPretragaRezervacija.Size = new System.Drawing.Size(1490, 895);
			this.ucPretragaRezervacija.TabIndex = 27;
			// 
			// UCPretraziRezervacijuZaIzmenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Project.Client.Forms.Properties.Resources.UCRezervacija;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.btnIzmeniRezervaciju);
			this.Controls.Add(this.ucPretragaRezervacija);
			this.MinimumSize = new System.Drawing.Size(1498, 914);
			this.Name = "UCPretraziRezervacijuZaIzmenu";
			this.Size = new System.Drawing.Size(1498, 914);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnIzmeniRezervaciju;
		private UCPretragaRezervacija ucPretragaRezervacija;

		public Button BtnIzmeniRezervaciju { get => btnIzmeniRezervaciju; set => btnIzmeniRezervaciju = value; }
		public UCPretragaRezervacija UcPretragaRezervacija { get => ucPretragaRezervacija; set => ucPretragaRezervacija = value; }
	}
}
