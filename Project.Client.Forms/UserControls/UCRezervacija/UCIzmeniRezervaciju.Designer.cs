﻿namespace Project.Client.Forms.UserControls.UCRezervacija
{
	partial class UCIzmeniRezervaciju
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
			this.ucRadSaRezervacijom = new Project.Client.Forms.UserControls.UCRezervacija.UCRadSaRezervacijom();
			this.button1 = new System.Windows.Forms.Button();
			this.btnIzmeniRezervaciju = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ucRadSaRezervacijom
			// 
			this.ucRadSaRezervacijom.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ucRadSaRezervacijom.BackColor = System.Drawing.Color.Transparent;
			this.ucRadSaRezervacijom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ucRadSaRezervacijom.Location = new System.Drawing.Point(69, 41);
			this.ucRadSaRezervacijom.Margin = new System.Windows.Forms.Padding(4);
			this.ucRadSaRezervacijom.Name = "ucRadSaRezervacijom";
			this.ucRadSaRezervacijom.Size = new System.Drawing.Size(1465, 778);
			this.ucRadSaRezervacijom.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1651, 694);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btnIzmeniRezervaciju
			// 
			this.btnIzmeniRezervaciju.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnIzmeniRezervaciju.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnIzmeniRezervaciju.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			this.btnIzmeniRezervaciju.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(44)))), ((int)(((byte)(126)))));
			this.btnIzmeniRezervaciju.Location = new System.Drawing.Point(1165, 692);
			this.btnIzmeniRezervaciju.Name = "btnIzmeniRezervaciju";
			this.btnIzmeniRezervaciju.Size = new System.Drawing.Size(267, 50);
			this.btnIzmeniRezervaciju.TabIndex = 23;
			this.btnIzmeniRezervaciju.Text = "Izmeni rezervaciju";
			this.btnIzmeniRezervaciju.UseVisualStyleBackColor = false;
			// 
			// UCIzmeniRezervaciju
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Project.Client.Forms.Properties.Resources.UCRezervacija;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.btnIzmeniRezervaciju);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ucRadSaRezervacijom);
			this.Name = "UCIzmeniRezervaciju";
			this.Size = new System.Drawing.Size(1599, 867);
			this.ResumeLayout(false);

		}

		#endregion

		private UCRadSaRezervacijom ucRadSaRezervacijom;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnIzmeniRezervaciju;
	}
}
