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
			this.ucPretragaRezervacije1 = new Project.Client.Forms.UserControls.UCRezervacija.UCPretragaRezervacije();
			this.SuspendLayout();
			// 
			// btnIzmeniRezervaciju
			// 
			this.btnIzmeniRezervaciju.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnIzmeniRezervaciju.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnIzmeniRezervaciju.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			this.btnIzmeniRezervaciju.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(44)))), ((int)(((byte)(126)))));
			this.btnIzmeniRezervaciju.Location = new System.Drawing.Point(1231, 814);
			this.btnIzmeniRezervaciju.Name = "btnIzmeniRezervaciju";
			this.btnIzmeniRezervaciju.Size = new System.Drawing.Size(267, 50);
			this.btnIzmeniRezervaciju.TabIndex = 26;
			this.btnIzmeniRezervaciju.Text = "Izmeni rezervaciju";
			this.btnIzmeniRezervaciju.UseVisualStyleBackColor = false;
			// 
			// ucPretragaRezervacije1
			// 
			this.ucPretragaRezervacije1.BackColor = System.Drawing.Color.Transparent;
			this.ucPretragaRezervacije1.Location = new System.Drawing.Point(50, 25);
			this.ucPretragaRezervacije1.Name = "ucPretragaRezervacije1";
			this.ucPretragaRezervacije1.Size = new System.Drawing.Size(1490, 884);
			this.ucPretragaRezervacije1.TabIndex = 27;
			// 
			// UCPretraziRezervacijuZaIzmenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Project.Client.Forms.Properties.Resources.UCRezervacija;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.btnIzmeniRezervaciju);
			this.Controls.Add(this.ucPretragaRezervacije1);
			this.Name = "UCPretraziRezervacijuZaIzmenu";
			this.Size = new System.Drawing.Size(1591, 937);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnIzmeniRezervaciju;
		private UCPretragaRezervacije ucPretragaRezervacije1;
	}
}
