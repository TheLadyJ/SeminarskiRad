using System.Windows.Forms;

namespace Project.Client.Forms.UserControls.UCRezervacija
{
	partial class UCKreirajNovuRezervaciju
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
			this.btnKreirajNovuRezervaciju = new System.Windows.Forms.Button();
			this.ucRadSaRezervacijom = new Project.Client.Forms.UserControls.UCRezervacija.UCRadSaRezervacijom();
			this.SuspendLayout();
			// 
			// btnKreirajNovuRezervaciju
			// 
			this.btnKreirajNovuRezervaciju.AllowDrop = true;
			this.btnKreirajNovuRezervaciju.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnKreirajNovuRezervaciju.BackColor = System.Drawing.Color.White;
			this.btnKreirajNovuRezervaciju.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			this.btnKreirajNovuRezervaciju.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(44)))), ((int)(((byte)(126)))));
			this.btnKreirajNovuRezervaciju.Location = new System.Drawing.Point(1142, 697);
			this.btnKreirajNovuRezervaciju.Name = "btnKreirajNovuRezervaciju";
			this.btnKreirajNovuRezervaciju.Size = new System.Drawing.Size(267, 50);
			this.btnKreirajNovuRezervaciju.TabIndex = 24;
			this.btnKreirajNovuRezervaciju.Text = "Kreiraj novu rezervaciju";
			this.btnKreirajNovuRezervaciju.UseVisualStyleBackColor = false;
			this.btnKreirajNovuRezervaciju.Click += new System.EventHandler(this.btnKreirajNovuRezervaciju_Click);
			// 
			// ucRadSaRezervacijom
			// 
			this.ucRadSaRezervacijom.AllowDrop = true;
			this.ucRadSaRezervacijom.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ucRadSaRezervacijom.BackColor = System.Drawing.Color.Transparent;
			this.ucRadSaRezervacijom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ucRadSaRezervacijom.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.ucRadSaRezervacijom.Location = new System.Drawing.Point(71, 55);
			this.ucRadSaRezervacijom.Margin = new System.Windows.Forms.Padding(4);
			this.ucRadSaRezervacijom.Name = "ucRadSaRezervacijom";
			this.ucRadSaRezervacijom.Size = new System.Drawing.Size(1446, 763);
			this.ucRadSaRezervacijom.TabIndex = 25;
			// 
			// UCKreirajNovuRezervaciju
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Project.Client.Forms.Properties.Resources.UCRezervacija;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.btnKreirajNovuRezervaciju);
			this.Controls.Add(this.ucRadSaRezervacijom);
			this.Name = "UCKreirajNovuRezervaciju";
			this.Size = new System.Drawing.Size(1597, 908);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnKreirajNovuRezervaciju;
		private UCRadSaRezervacijom ucRadSaRezervacijom;

		public Button BtnKreirajNovuRezervaciju { get => btnKreirajNovuRezervaciju; set => btnKreirajNovuRezervaciju = value; }
		public UCRadSaRezervacijom UcRadSaRezervacijom { get => ucRadSaRezervacijom; set => ucRadSaRezervacijom = value; }
	}
}
