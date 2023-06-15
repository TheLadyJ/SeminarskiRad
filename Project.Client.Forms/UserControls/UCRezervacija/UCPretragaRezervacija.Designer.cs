namespace Project.Client.Forms.UserControls.UCRezervacija
{
	partial class UCPretragaRezervacija
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
			this.txtUkupnaCena = new System.Windows.Forms.TextBox();
			this.txtKeteringMeni = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnPretrazi = new System.Windows.Forms.Button();
			this.chbUkupnaCena = new System.Windows.Forms.CheckBox();
			this.chbKeteringMeni = new System.Windows.Forms.CheckBox();
			this.chbTipProslave = new System.Windows.Forms.CheckBox();
			this.chbDatumVreme = new System.Windows.Forms.CheckBox();
			this.chbMesto = new System.Windows.Forms.CheckBox();
			this.chbKlijent = new System.Windows.Forms.CheckBox();
			this.btnDetaljiKeteringMenija = new System.Windows.Forms.Button();
			this.btnIzaberiKeteringMeni = new System.Windows.Forms.Button();
			this.cbMesto = new System.Windows.Forms.ComboBox();
			this.cbKlijent = new System.Windows.Forms.ComboBox();
			this.cbTipProslave = new System.Windows.Forms.ComboBox();
			this.lblDatumVremeNapomena = new System.Windows.Forms.Label();
			this.txtDatumVreme = new System.Windows.Forms.TextBox();
			this.gbUnosStola = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.gbUnosStola.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtUkupnaCena
			// 
			this.txtUkupnaCena.Location = new System.Drawing.Point(1045, 214);
			this.txtUkupnaCena.Margin = new System.Windows.Forms.Padding(4);
			this.txtUkupnaCena.Name = "txtUkupnaCena";
			this.txtUkupnaCena.Size = new System.Drawing.Size(398, 28);
			this.txtUkupnaCena.TabIndex = 34;
			// 
			// txtKeteringMeni
			// 
			this.txtKeteringMeni.Location = new System.Drawing.Point(1045, 55);
			this.txtKeteringMeni.Margin = new System.Windows.Forms.Padding(4);
			this.txtKeteringMeni.Name = "txtKeteringMeni";
			this.txtKeteringMeni.Size = new System.Drawing.Size(398, 28);
			this.txtKeteringMeni.TabIndex = 33;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(36, 433);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1407, 319);
			this.dataGridView1.TabIndex = 32;
			// 
			// btnPretrazi
			// 
			this.btnPretrazi.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnPretrazi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(44)))), ((int)(((byte)(126)))));
			this.btnPretrazi.Location = new System.Drawing.Point(1000, 360);
			this.btnPretrazi.Name = "btnPretrazi";
			this.btnPretrazi.Size = new System.Drawing.Size(443, 51);
			this.btnPretrazi.TabIndex = 31;
			this.btnPretrazi.Text = "Pretraži rezervaciju na osnovu kriterijuma";
			this.btnPretrazi.UseVisualStyleBackColor = false;
			// 
			// chbUkupnaCena
			// 
			this.chbUkupnaCena.AutoSize = true;
			this.chbUkupnaCena.Location = new System.Drawing.Point(800, 222);
			this.chbUkupnaCena.Name = "chbUkupnaCena";
			this.chbUkupnaCena.Size = new System.Drawing.Size(146, 23);
			this.chbUkupnaCena.TabIndex = 30;
			this.chbUkupnaCena.Text = "Ukupna cena:";
			this.chbUkupnaCena.UseVisualStyleBackColor = true;
			// 
			// chbKeteringMeni
			// 
			this.chbKeteringMeni.AutoSize = true;
			this.chbKeteringMeni.Location = new System.Drawing.Point(800, 61);
			this.chbKeteringMeni.Name = "chbKeteringMeni";
			this.chbKeteringMeni.Size = new System.Drawing.Size(149, 23);
			this.chbKeteringMeni.TabIndex = 29;
			this.chbKeteringMeni.Text = "Ketering meni:";
			this.chbKeteringMeni.UseVisualStyleBackColor = true;
			// 
			// chbTipProslave
			// 
			this.chbTipProslave.AutoSize = true;
			this.chbTipProslave.Location = new System.Drawing.Point(36, 324);
			this.chbTipProslave.Name = "chbTipProslave";
			this.chbTipProslave.Size = new System.Drawing.Size(134, 23);
			this.chbTipProslave.TabIndex = 28;
			this.chbTipProslave.Text = "Tip proslave:";
			this.chbTipProslave.UseVisualStyleBackColor = true;
			// 
			// chbDatumVreme
			// 
			this.chbDatumVreme.AutoSize = true;
			this.chbDatumVreme.Location = new System.Drawing.Point(36, 219);
			this.chbDatumVreme.Name = "chbDatumVreme";
			this.chbDatumVreme.Size = new System.Drawing.Size(156, 23);
			this.chbDatumVreme.TabIndex = 27;
			this.chbDatumVreme.Text = "Datum i vreme:";
			this.chbDatumVreme.UseVisualStyleBackColor = true;
			// 
			// chbMesto
			// 
			this.chbMesto.AutoSize = true;
			this.chbMesto.Location = new System.Drawing.Point(35, 137);
			this.chbMesto.Name = "chbMesto";
			this.chbMesto.Size = new System.Drawing.Size(85, 23);
			this.chbMesto.TabIndex = 26;
			this.chbMesto.Text = "Mesto:";
			this.chbMesto.UseVisualStyleBackColor = true;
			// 
			// chbKlijent
			// 
			this.chbKlijent.AutoSize = true;
			this.chbKlijent.Location = new System.Drawing.Point(35, 60);
			this.chbKlijent.Name = "chbKlijent";
			this.chbKlijent.Size = new System.Drawing.Size(84, 23);
			this.chbKlijent.TabIndex = 25;
			this.chbKlijent.Text = "Klijent:";
			this.chbKlijent.UseVisualStyleBackColor = true;
			// 
			// btnDetaljiKeteringMenija
			// 
			this.btnDetaljiKeteringMenija.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnDetaljiKeteringMenija.Location = new System.Drawing.Point(1109, 126);
			this.btnDetaljiKeteringMenija.Name = "btnDetaljiKeteringMenija";
			this.btnDetaljiKeteringMenija.Size = new System.Drawing.Size(334, 38);
			this.btnDetaljiKeteringMenija.TabIndex = 21;
			this.btnDetaljiKeteringMenija.Text = "Pogledaj detalje izabranog menija";
			this.btnDetaljiKeteringMenija.UseVisualStyleBackColor = false;
			// 
			// btnIzaberiKeteringMeni
			// 
			this.btnIzaberiKeteringMeni.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnIzaberiKeteringMeni.Location = new System.Drawing.Point(800, 126);
			this.btnIzaberiKeteringMeni.Name = "btnIzaberiKeteringMeni";
			this.btnIzaberiKeteringMeni.Size = new System.Drawing.Size(264, 38);
			this.btnIzaberiKeteringMeni.TabIndex = 18;
			this.btnIzaberiKeteringMeni.Text = "Izaberi ketering meni";
			this.btnIzaberiKeteringMeni.UseVisualStyleBackColor = false;
			// 
			// cbMesto
			// 
			this.cbMesto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cbMesto.FormattingEnabled = true;
			this.cbMesto.Location = new System.Drawing.Point(301, 135);
			this.cbMesto.Margin = new System.Windows.Forms.Padding(4);
			this.cbMesto.Name = "cbMesto";
			this.cbMesto.Size = new System.Drawing.Size(398, 27);
			this.cbMesto.TabIndex = 17;
			// 
			// cbKlijent
			// 
			this.cbKlijent.FormattingEnabled = true;
			this.cbKlijent.Location = new System.Drawing.Point(301, 56);
			this.cbKlijent.Margin = new System.Windows.Forms.Padding(4);
			this.cbKlijent.Name = "cbKlijent";
			this.cbKlijent.Size = new System.Drawing.Size(398, 27);
			this.cbKlijent.TabIndex = 13;
			// 
			// cbTipProslave
			// 
			this.cbTipProslave.FormattingEnabled = true;
			this.cbTipProslave.Location = new System.Drawing.Point(301, 322);
			this.cbTipProslave.Margin = new System.Windows.Forms.Padding(4);
			this.cbTipProslave.Name = "cbTipProslave";
			this.cbTipProslave.Size = new System.Drawing.Size(398, 27);
			this.cbTipProslave.TabIndex = 10;
			// 
			// lblDatumVremeNapomena
			// 
			this.lblDatumVremeNapomena.AutoSize = true;
			this.lblDatumVremeNapomena.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblDatumVremeNapomena.Location = new System.Drawing.Point(32, 263);
			this.lblDatumVremeNapomena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDatumVremeNapomena.Name = "lblDatumVremeNapomena";
			this.lblDatumVremeNapomena.Size = new System.Drawing.Size(228, 17);
			this.lblDatumVremeNapomena.TabIndex = 7;
			this.lblDatumVremeNapomena.Text = "(U formatu dd.MM.yyyy. HH:mm)";
			// 
			// txtDatumVreme
			// 
			this.txtDatumVreme.Location = new System.Drawing.Point(301, 214);
			this.txtDatumVreme.Margin = new System.Windows.Forms.Padding(4);
			this.txtDatumVreme.Name = "txtDatumVreme";
			this.txtDatumVreme.Size = new System.Drawing.Size(398, 28);
			this.txtDatumVreme.TabIndex = 3;
			// 
			// gbUnosStola
			// 
			this.gbUnosStola.BackColor = System.Drawing.Color.Transparent;
			this.gbUnosStola.Controls.Add(this.txtUkupnaCena);
			this.gbUnosStola.Controls.Add(this.txtKeteringMeni);
			this.gbUnosStola.Controls.Add(this.dataGridView1);
			this.gbUnosStola.Controls.Add(this.btnPretrazi);
			this.gbUnosStola.Controls.Add(this.chbUkupnaCena);
			this.gbUnosStola.Controls.Add(this.chbKeteringMeni);
			this.gbUnosStola.Controls.Add(this.chbTipProslave);
			this.gbUnosStola.Controls.Add(this.chbDatumVreme);
			this.gbUnosStola.Controls.Add(this.chbMesto);
			this.gbUnosStola.Controls.Add(this.chbKlijent);
			this.gbUnosStola.Controls.Add(this.btnDetaljiKeteringMenija);
			this.gbUnosStola.Controls.Add(this.btnIzaberiKeteringMeni);
			this.gbUnosStola.Controls.Add(this.cbMesto);
			this.gbUnosStola.Controls.Add(this.cbKlijent);
			this.gbUnosStola.Controls.Add(this.cbTipProslave);
			this.gbUnosStola.Controls.Add(this.lblDatumVremeNapomena);
			this.gbUnosStola.Controls.Add(this.txtDatumVreme);
			this.gbUnosStola.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.gbUnosStola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))));
			this.gbUnosStola.Location = new System.Drawing.Point(12, 24);
			this.gbUnosStola.Margin = new System.Windows.Forms.Padding(4);
			this.gbUnosStola.MaximumSize = new System.Drawing.Size(1474, 867);
			this.gbUnosStola.Name = "gbUnosStola";
			this.gbUnosStola.Padding = new System.Windows.Forms.Padding(4);
			this.gbUnosStola.Size = new System.Drawing.Size(1474, 867);
			this.gbUnosStola.TabIndex = 3;
			this.gbUnosStola.TabStop = false;
			this.gbUnosStola.Text = "Rezervacija";
			// 
			// UCPretragaRezervacija
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.gbUnosStola);
			this.Name = "UCPretragaRezervacija";
			this.Size = new System.Drawing.Size(1498, 914);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.gbUnosStola.ResumeLayout(false);
			this.gbUnosStola.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtUkupnaCena;
		private System.Windows.Forms.TextBox txtKeteringMeni;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnPretrazi;
		private System.Windows.Forms.CheckBox chbUkupnaCena;
		private System.Windows.Forms.CheckBox chbKeteringMeni;
		private System.Windows.Forms.CheckBox chbTipProslave;
		private System.Windows.Forms.CheckBox chbDatumVreme;
		private System.Windows.Forms.CheckBox chbMesto;
		private System.Windows.Forms.CheckBox chbKlijent;
		private System.Windows.Forms.Button btnDetaljiKeteringMenija;
		private System.Windows.Forms.Button btnIzaberiKeteringMeni;
		private System.Windows.Forms.ComboBox cbMesto;
		private System.Windows.Forms.ComboBox cbKlijent;
		private System.Windows.Forms.ComboBox cbTipProslave;
		private System.Windows.Forms.Label lblDatumVremeNapomena;
		private System.Windows.Forms.TextBox txtDatumVreme;
		private System.Windows.Forms.GroupBox gbUnosStola;
	}
}
