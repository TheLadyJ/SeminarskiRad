namespace Project.Client.Forms.UserControls.UCRezervacija
{
	partial class UCPretraziRezervacijuZaBrisanje
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
			this.btnObrisiRezervaciju = new System.Windows.Forms.Button();
			this.ucPretragaRezervacija1 = new Project.Client.Forms.UserControls.UCRezervacija.UCPretragaRezervacija();
			this.SuspendLayout();
			// 
			// btnObrisiRezervaciju
			// 
			this.btnObrisiRezervaciju.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnObrisiRezervaciju.AutoSize = true;
			this.btnObrisiRezervaciju.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnObrisiRezervaciju.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			this.btnObrisiRezervaciju.ForeColor = System.Drawing.Color.Brown;
			this.btnObrisiRezervaciju.Location = new System.Drawing.Point(1187, 810);
			this.btnObrisiRezervaciju.Name = "btnObrisiRezervaciju";
			this.btnObrisiRezervaciju.Size = new System.Drawing.Size(267, 50);
			this.btnObrisiRezervaciju.TabIndex = 25;
			this.btnObrisiRezervaciju.Text = "Obriši rezervaciju";
			this.btnObrisiRezervaciju.UseVisualStyleBackColor = false;
			// 
			// ucPretragaRezervacija1
			// 
			this.ucPretragaRezervacija1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ucPretragaRezervacija1.AutoSize = true;
			this.ucPretragaRezervacija1.BackColor = System.Drawing.Color.Transparent;
			this.ucPretragaRezervacija1.Location = new System.Drawing.Point(-3, -2);
			this.ucPretragaRezervacija1.Name = "ucPretragaRezervacija1";
			this.ucPretragaRezervacija1.Size = new System.Drawing.Size(1498, 914);
			this.ucPretragaRezervacija1.TabIndex = 26;
			// 
			// UCPretraziRezervacijuZaBrisanje
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Project.Client.Forms.Properties.Resources.UCRezervacija;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.btnObrisiRezervaciju);
			this.Controls.Add(this.ucPretragaRezervacija1);
			this.MinimumSize = new System.Drawing.Size(1498, 914);
			this.Name = "UCPretraziRezervacijuZaBrisanje";
			this.Size = new System.Drawing.Size(1498, 914);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnObrisiRezervaciju;
		private UCPretragaRezervacija ucPretragaRezervacija1;
	}
}
