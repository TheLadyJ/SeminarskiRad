namespace Project.Client.Forms.UserControls.UCRezervacija
{
    partial class UCRadSaRezervacijom
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
			this.gbUnosStola = new System.Windows.Forms.GroupBox();
			this.dgvStolovi = new System.Windows.Forms.DataGridView();
			this.btnObrisiStolove = new System.Windows.Forms.Button();
			this.btnDodajSto = new System.Windows.Forms.Button();
			this.btnDetaljiKeteringMenija = new System.Windows.Forms.Button();
			this.lblKeteringMeniVrednost = new System.Windows.Forms.Label();
			this.lblKeteringMeni = new System.Windows.Forms.Label();
			this.btnIzaberiKeteringMeni = new System.Windows.Forms.Button();
			this.cbMesto = new System.Windows.Forms.ComboBox();
			this.lblMesto = new System.Windows.Forms.Label();
			this.lblRadnikVrednost = new System.Windows.Forms.Label();
			this.lblRadnik = new System.Windows.Forms.Label();
			this.cbKlijent = new System.Windows.Forms.ComboBox();
			this.lblKlijent = new System.Windows.Forms.Label();
			this.lblUkupnaCenaVrednost = new System.Windows.Forms.Label();
			this.cbTipProslave = new System.Windows.Forms.ComboBox();
			this.lblTipProslave = new System.Windows.Forms.Label();
			this.lblUkupnaCenaNapomena = new System.Windows.Forms.Label();
			this.lblDatumVremeNapomena = new System.Windows.Forms.Label();
			this.txtDatumVreme = new System.Windows.Forms.TextBox();
			this.lblUkupnaCena = new System.Windows.Forms.Label();
			this.lblDatumVreme = new System.Windows.Forms.Label();
			this.gbUnosStola.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStolovi)).BeginInit();
			this.SuspendLayout();
			// 
			// gbUnosStola
			// 
			this.gbUnosStola.BackColor = System.Drawing.Color.Transparent;
			this.gbUnosStola.Controls.Add(this.dgvStolovi);
			this.gbUnosStola.Controls.Add(this.btnObrisiStolove);
			this.gbUnosStola.Controls.Add(this.btnDodajSto);
			this.gbUnosStola.Controls.Add(this.btnDetaljiKeteringMenija);
			this.gbUnosStola.Controls.Add(this.lblKeteringMeniVrednost);
			this.gbUnosStola.Controls.Add(this.lblKeteringMeni);
			this.gbUnosStola.Controls.Add(this.btnIzaberiKeteringMeni);
			this.gbUnosStola.Controls.Add(this.cbMesto);
			this.gbUnosStola.Controls.Add(this.lblMesto);
			this.gbUnosStola.Controls.Add(this.lblRadnikVrednost);
			this.gbUnosStola.Controls.Add(this.lblRadnik);
			this.gbUnosStola.Controls.Add(this.cbKlijent);
			this.gbUnosStola.Controls.Add(this.lblKlijent);
			this.gbUnosStola.Controls.Add(this.lblUkupnaCenaVrednost);
			this.gbUnosStola.Controls.Add(this.cbTipProslave);
			this.gbUnosStola.Controls.Add(this.lblTipProslave);
			this.gbUnosStola.Controls.Add(this.lblUkupnaCenaNapomena);
			this.gbUnosStola.Controls.Add(this.lblDatumVremeNapomena);
			this.gbUnosStola.Controls.Add(this.txtDatumVreme);
			this.gbUnosStola.Controls.Add(this.lblUkupnaCena);
			this.gbUnosStola.Controls.Add(this.lblDatumVreme);
			this.gbUnosStola.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.gbUnosStola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))));
			this.gbUnosStola.Location = new System.Drawing.Point(4, 4);
			this.gbUnosStola.Margin = new System.Windows.Forms.Padding(4);
			this.gbUnosStola.Name = "gbUnosStola";
			this.gbUnosStola.Padding = new System.Windows.Forms.Padding(4);
			this.gbUnosStola.Size = new System.Drawing.Size(1390, 757);
			this.gbUnosStola.TabIndex = 1;
			this.gbUnosStola.TabStop = false;
			this.gbUnosStola.Text = "Rezervacija";
			// 
			// dgvStolovi
			// 
			this.dgvStolovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStolovi.Location = new System.Drawing.Point(29, 358);
			this.dgvStolovi.Name = "dgvStolovi";
			this.dgvStolovi.RowHeadersWidth = 51;
			this.dgvStolovi.RowTemplate.Height = 24;
			this.dgvStolovi.Size = new System.Drawing.Size(598, 349);
			this.dgvStolovi.TabIndex = 24;
			// 
			// btnObrisiStolove
			// 
			this.btnObrisiStolove.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnObrisiStolove.Location = new System.Drawing.Point(378, 286);
			this.btnObrisiStolove.Name = "btnObrisiStolove";
			this.btnObrisiStolove.Size = new System.Drawing.Size(249, 38);
			this.btnObrisiStolove.TabIndex = 23;
			this.btnObrisiStolove.Text = "Obriši sto/stolove";
			this.btnObrisiStolove.UseVisualStyleBackColor = false;
			// 
			// btnDodajSto
			// 
			this.btnDodajSto.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnDodajSto.Location = new System.Drawing.Point(29, 286);
			this.btnDodajSto.Name = "btnDodajSto";
			this.btnDodajSto.Size = new System.Drawing.Size(249, 38);
			this.btnDodajSto.TabIndex = 22;
			this.btnDodajSto.Text = "Dodaj sto";
			this.btnDodajSto.UseVisualStyleBackColor = false;
			// 
			// btnDetaljiKeteringMenija
			// 
			this.btnDetaljiKeteringMenija.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnDetaljiKeteringMenija.Location = new System.Drawing.Point(1050, 286);
			this.btnDetaljiKeteringMenija.Name = "btnDetaljiKeteringMenija";
			this.btnDetaljiKeteringMenija.Size = new System.Drawing.Size(312, 38);
			this.btnDetaljiKeteringMenija.TabIndex = 21;
			this.btnDetaljiKeteringMenija.Text = "Pogledaj detalje izabranog menija";
			this.btnDetaljiKeteringMenija.UseVisualStyleBackColor = false;
			// 
			// lblKeteringMeniVrednost
			// 
			this.lblKeteringMeniVrednost.BackColor = System.Drawing.SystemColors.Window;
			this.lblKeteringMeniVrednost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblKeteringMeniVrednost.Location = new System.Drawing.Point(979, 208);
			this.lblKeteringMeniVrednost.Name = "lblKeteringMeniVrednost";
			this.lblKeteringMeniVrednost.Size = new System.Drawing.Size(383, 27);
			this.lblKeteringMeniVrednost.TabIndex = 20;
			this.lblKeteringMeniVrednost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblKeteringMeni
			// 
			this.lblKeteringMeni.AutoSize = true;
			this.lblKeteringMeni.Location = new System.Drawing.Point(721, 216);
			this.lblKeteringMeni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblKeteringMeni.Name = "lblKeteringMeni";
			this.lblKeteringMeni.Size = new System.Drawing.Size(127, 19);
			this.lblKeteringMeni.TabIndex = 19;
			this.lblKeteringMeni.Text = "Ketering meni:";
			// 
			// btnIzaberiKeteringMeni
			// 
			this.btnIzaberiKeteringMeni.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnIzaberiKeteringMeni.Location = new System.Drawing.Point(725, 286);
			this.btnIzaberiKeteringMeni.Name = "btnIzaberiKeteringMeni";
			this.btnIzaberiKeteringMeni.Size = new System.Drawing.Size(249, 38);
			this.btnIzaberiKeteringMeni.TabIndex = 18;
			this.btnIzaberiKeteringMeni.Text = "Izaberi ketering meni";
			this.btnIzaberiKeteringMeni.UseVisualStyleBackColor = false;
			// 
			// cbMesto
			// 
			this.cbMesto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cbMesto.FormattingEnabled = true;
			this.cbMesto.Location = new System.Drawing.Point(244, 184);
			this.cbMesto.Margin = new System.Windows.Forms.Padding(4);
			this.cbMesto.Name = "cbMesto";
			this.cbMesto.Size = new System.Drawing.Size(383, 27);
			this.cbMesto.TabIndex = 17;
			// 
			// lblMesto
			// 
			this.lblMesto.AutoSize = true;
			this.lblMesto.Location = new System.Drawing.Point(36, 192);
			this.lblMesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMesto.Name = "lblMesto";
			this.lblMesto.Size = new System.Drawing.Size(63, 19);
			this.lblMesto.TabIndex = 16;
			this.lblMesto.Text = "Mesto:";
			// 
			// lblRadnikVrednost
			// 
			this.lblRadnikVrednost.BackColor = System.Drawing.SystemColors.Window;
			this.lblRadnikVrednost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblRadnikVrednost.Location = new System.Drawing.Point(244, 53);
			this.lblRadnikVrednost.Name = "lblRadnikVrednost";
			this.lblRadnikVrednost.Size = new System.Drawing.Size(383, 27);
			this.lblRadnikVrednost.TabIndex = 15;
			this.lblRadnikVrednost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRadnik
			// 
			this.lblRadnik.AutoSize = true;
			this.lblRadnik.Location = new System.Drawing.Point(36, 63);
			this.lblRadnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRadnik.Name = "lblRadnik";
			this.lblRadnik.Size = new System.Drawing.Size(70, 19);
			this.lblRadnik.TabIndex = 14;
			this.lblRadnik.Text = "Radnik:";
			// 
			// cbKlijent
			// 
			this.cbKlijent.FormattingEnabled = true;
			this.cbKlijent.Location = new System.Drawing.Point(979, 54);
			this.cbKlijent.Margin = new System.Windows.Forms.Padding(4);
			this.cbKlijent.Name = "cbKlijent";
			this.cbKlijent.Size = new System.Drawing.Size(383, 27);
			this.cbKlijent.TabIndex = 13;
			// 
			// lblKlijent
			// 
			this.lblKlijent.AutoSize = true;
			this.lblKlijent.Location = new System.Drawing.Point(721, 64);
			this.lblKlijent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblKlijent.Name = "lblKlijent";
			this.lblKlijent.Size = new System.Drawing.Size(62, 19);
			this.lblKlijent.TabIndex = 12;
			this.lblKlijent.Text = "Klijent:";
			// 
			// lblUkupnaCenaVrednost
			// 
			this.lblUkupnaCenaVrednost.BackColor = System.Drawing.SystemColors.Window;
			this.lblUkupnaCenaVrednost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblUkupnaCenaVrednost.Location = new System.Drawing.Point(979, 457);
			this.lblUkupnaCenaVrednost.Name = "lblUkupnaCenaVrednost";
			this.lblUkupnaCenaVrednost.Size = new System.Drawing.Size(383, 27);
			this.lblUkupnaCenaVrednost.TabIndex = 11;
			this.lblUkupnaCenaVrednost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbTipProslave
			// 
			this.cbTipProslave.FormattingEnabled = true;
			this.cbTipProslave.Location = new System.Drawing.Point(244, 115);
			this.cbTipProslave.Margin = new System.Windows.Forms.Padding(4);
			this.cbTipProslave.Name = "cbTipProslave";
			this.cbTipProslave.Size = new System.Drawing.Size(383, 27);
			this.cbTipProslave.TabIndex = 10;
			// 
			// lblTipProslave
			// 
			this.lblTipProslave.AutoSize = true;
			this.lblTipProslave.Location = new System.Drawing.Point(36, 123);
			this.lblTipProslave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTipProslave.Name = "lblTipProslave";
			this.lblTipProslave.Size = new System.Drawing.Size(112, 19);
			this.lblTipProslave.TabIndex = 9;
			this.lblTipProslave.Text = "Tip proslave:";
			// 
			// lblUkupnaCenaNapomena
			// 
			this.lblUkupnaCenaNapomena.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblUkupnaCenaNapomena.Location = new System.Drawing.Point(723, 503);
			this.lblUkupnaCenaNapomena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUkupnaCenaNapomena.Name = "lblUkupnaCenaNapomena";
			this.lblUkupnaCenaNapomena.Size = new System.Drawing.Size(203, 57);
			this.lblUkupnaCenaNapomena.TabIndex = 8;
			this.lblUkupnaCenaNapomena.Text = "(Izračunato na osnovu cene svih stolova i keteringa za sve goste)";
			// 
			// lblDatumVremeNapomena
			// 
			this.lblDatumVremeNapomena.AutoSize = true;
			this.lblDatumVremeNapomena.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblDatumVremeNapomena.Location = new System.Drawing.Point(722, 153);
			this.lblDatumVremeNapomena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDatumVremeNapomena.Name = "lblDatumVremeNapomena";
			this.lblDatumVremeNapomena.Size = new System.Drawing.Size(228, 17);
			this.lblDatumVremeNapomena.TabIndex = 7;
			this.lblDatumVremeNapomena.Text = "(U formatu dd.MM.yyyy. HH:mm)";
			// 
			// txtDatumVreme
			// 
			this.txtDatumVreme.Location = new System.Drawing.Point(979, 112);
			this.txtDatumVreme.Margin = new System.Windows.Forms.Padding(4);
			this.txtDatumVreme.Name = "txtDatumVreme";
			this.txtDatumVreme.Size = new System.Drawing.Size(383, 28);
			this.txtDatumVreme.TabIndex = 3;
			// 
			// lblUkupnaCena
			// 
			this.lblUkupnaCena.AutoSize = true;
			this.lblUkupnaCena.Location = new System.Drawing.Point(723, 465);
			this.lblUkupnaCena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUkupnaCena.Name = "lblUkupnaCena";
			this.lblUkupnaCena.Size = new System.Drawing.Size(124, 19);
			this.lblUkupnaCena.TabIndex = 1;
			this.lblUkupnaCena.Text = "Ukupna cena:";
			// 
			// lblDatumVreme
			// 
			this.lblDatumVreme.AutoSize = true;
			this.lblDatumVreme.Location = new System.Drawing.Point(721, 123);
			this.lblDatumVreme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDatumVreme.Name = "lblDatumVreme";
			this.lblDatumVreme.Size = new System.Drawing.Size(134, 19);
			this.lblDatumVreme.TabIndex = 0;
			this.lblDatumVreme.Text = "Datum i vreme:";
			// 
			// UCRadSaRezervacijom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.gbUnosStola);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UCRadSaRezervacijom";
			this.Size = new System.Drawing.Size(1410, 772);
			this.gbUnosStola.ResumeLayout(false);
			this.gbUnosStola.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStolovi)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUnosStola;
        private System.Windows.Forms.Label lblUkupnaCenaNapomena;
        private System.Windows.Forms.Label lblDatumVremeNapomena;
        private System.Windows.Forms.TextBox txtDatumVreme;
        private System.Windows.Forms.Label lblUkupnaCena;
        private System.Windows.Forms.Label lblDatumVreme;
        private System.Windows.Forms.ComboBox cbTipProslave;
        private System.Windows.Forms.Label lblTipProslave;
        private System.Windows.Forms.Label lblUkupnaCenaVrednost;
        private System.Windows.Forms.Label lblRadnikVrednost;
        private System.Windows.Forms.Label lblRadnik;
        private System.Windows.Forms.ComboBox cbKlijent;
        private System.Windows.Forms.Label lblKlijent;
        private System.Windows.Forms.ComboBox cbMesto;
        private System.Windows.Forms.Label lblMesto;
        private System.Windows.Forms.Button btnIzaberiKeteringMeni;
        private System.Windows.Forms.Button btnDetaljiKeteringMenija;
        private System.Windows.Forms.Label lblKeteringMeniVrednost;
        private System.Windows.Forms.Label lblKeteringMeni;
        private System.Windows.Forms.Button btnDodajSto;
        private System.Windows.Forms.DataGridView dgvStolovi;
        private System.Windows.Forms.Button btnObrisiStolove;
	}
}
