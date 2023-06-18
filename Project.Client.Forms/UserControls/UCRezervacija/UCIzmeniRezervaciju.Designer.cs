using System.Windows.Forms;

namespace Project.Client.Forms.UserControls.UCRezervacija
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
			this.btnIzmeniRezervaciju = new System.Windows.Forms.Button();
			this.ucRadSaRezervacijom = new Project.Client.Forms.UserControls.UCRezervacija.UCRadSaRezervacijom();
			this.SuspendLayout();
			// 
			// btnIzmeniRezervaciju
			// 
			this.btnIzmeniRezervaciju.BackColor = System.Drawing.Color.White;
			this.btnIzmeniRezervaciju.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			this.btnIzmeniRezervaciju.ForeColor = System.Drawing.Color.Brown;
			this.btnIzmeniRezervaciju.Location = new System.Drawing.Point(1100, 655);
			this.btnIzmeniRezervaciju.Name = "btnIzmeniRezervaciju";
			this.btnIzmeniRezervaciju.Size = new System.Drawing.Size(267, 50);
			this.btnIzmeniRezervaciju.TabIndex = 23;
			this.btnIzmeniRezervaciju.Text = "Izmeni rezervaciju";
			this.btnIzmeniRezervaciju.UseVisualStyleBackColor = false;
			this.btnIzmeniRezervaciju.Click += new System.EventHandler(this.btnIzmeniRezervaciju_Click);
			// 
			// ucRadSaRezervacijom
			// 
			this.ucRadSaRezervacijom.BackColor = System.Drawing.Color.Transparent;
			this.ucRadSaRezervacijom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ucRadSaRezervacijom.Location = new System.Drawing.Point(4, 0);
			this.ucRadSaRezervacijom.Margin = new System.Windows.Forms.Padding(4);
			this.ucRadSaRezervacijom.Name = "ucRadSaRezervacijom";
			this.ucRadSaRezervacijom.Size = new System.Drawing.Size(1411, 778);
			this.ucRadSaRezervacijom.TabIndex = 0;
			this.ucRadSaRezervacijom.Load += new System.EventHandler(this.ucRadSaRezervacijom_Load);
			// 
			// UCIzmeniRezervaciju
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.btnIzmeniRezervaciju);
			this.Controls.Add(this.ucRadSaRezervacijom);
			this.Name = "UCIzmeniRezervaciju";
			this.Size = new System.Drawing.Size(1415, 783);
			this.ResumeLayout(false);

		}

		#endregion

		private UCRadSaRezervacijom ucRadSaRezervacijom;
		private System.Windows.Forms.Button btnIzmeniRezervaciju;

		public UCRadSaRezervacijom UcRadSaRezervacijom { get => ucRadSaRezervacijom; set => ucRadSaRezervacijom = value; }
		public Button BtnIzmeniRezervaciju { get => btnIzmeniRezervaciju; set => btnIzmeniRezervaciju = value; }
	}
}
