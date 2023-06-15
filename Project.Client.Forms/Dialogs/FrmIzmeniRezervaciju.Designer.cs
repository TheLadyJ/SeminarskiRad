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
			this.ucIzmeniRezervaciju1 = new Project.Client.Forms.UserControls.UCRezervacija.UCIzmeniRezervaciju();
			this.SuspendLayout();
			// 
			// ucIzmeniRezervaciju1
			// 
			this.ucIzmeniRezervaciju1.BackColor = System.Drawing.Color.Transparent;
			this.ucIzmeniRezervaciju1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ucIzmeniRezervaciju1.Location = new System.Drawing.Point(25, 12);
			this.ucIzmeniRezervaciju1.Name = "ucIzmeniRezervaciju1";
			this.ucIzmeniRezervaciju1.Size = new System.Drawing.Size(1415, 783);
			this.ucIzmeniRezervaciju1.TabIndex = 0;
			// 
			// FrmIzmeniRezervaciju
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Project.Client.Forms.Properties.Resources.UCRezervacija;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1463, 810);
			this.Controls.Add(this.ucIzmeniRezervaciju1);
			this.MaximizeBox = false;
			this.Name = "FrmIzmeniRezervaciju";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Izmeni rezervaciju";
			this.Load += new System.EventHandler(this.FrmIzmeniRezervaciju_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private UserControls.UCRezervacija.UCIzmeniRezervaciju ucIzmeniRezervaciju1;
	}
}