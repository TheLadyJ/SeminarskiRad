using System;
using System.Windows.Forms;

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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gbUnosStola = new System.Windows.Forms.GroupBox();
			this.dtpDatum = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.txtVremeDo = new System.Windows.Forms.TextBox();
			this.lblDatumVremeDo = new System.Windows.Forms.Label();
			this.cbStolovi = new System.Windows.Forms.ComboBox();
			this.lblSto = new System.Windows.Forms.Label();
			this.dgvStolovi = new System.Windows.Forms.DataGridView();
			this.btnObrisiStolove = new System.Windows.Forms.Button();
			this.btnDodajSto = new System.Windows.Forms.Button();
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
			this.txtVremeOd = new System.Windows.Forms.TextBox();
			this.lblUkupnaCena = new System.Windows.Forms.Label();
			this.lblDatumVremeOd = new System.Windows.Forms.Label();
			this.gbUnosStola.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStolovi)).BeginInit();
			this.SuspendLayout();
			// 
			// gbUnosStola
			// 
			this.gbUnosStola.BackColor = System.Drawing.Color.Transparent;
			this.gbUnosStola.Controls.Add(this.dtpDatum);
			this.gbUnosStola.Controls.Add(this.label1);
			this.gbUnosStola.Controls.Add(this.txtVremeDo);
			this.gbUnosStola.Controls.Add(this.lblDatumVremeDo);
			this.gbUnosStola.Controls.Add(this.cbStolovi);
			this.gbUnosStola.Controls.Add(this.lblSto);
			this.gbUnosStola.Controls.Add(this.dgvStolovi);
			this.gbUnosStola.Controls.Add(this.btnObrisiStolove);
			this.gbUnosStola.Controls.Add(this.btnDodajSto);
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
			this.gbUnosStola.Controls.Add(this.txtVremeOd);
			this.gbUnosStola.Controls.Add(this.lblUkupnaCena);
			this.gbUnosStola.Controls.Add(this.lblDatumVremeOd);
			this.gbUnosStola.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.gbUnosStola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))));
			this.gbUnosStola.Location = new System.Drawing.Point(4, 13);
			this.gbUnosStola.Margin = new System.Windows.Forms.Padding(4);
			this.gbUnosStola.Name = "gbUnosStola";
			this.gbUnosStola.Padding = new System.Windows.Forms.Padding(4);
			this.gbUnosStola.Size = new System.Drawing.Size(1386, 751);
			this.gbUnosStola.TabIndex = 1;
			this.gbUnosStola.TabStop = false;
			this.gbUnosStola.Text = "Rezervacija";
			// 
			// dtpDatum
			// 
			this.dtpDatum.Location = new System.Drawing.Point(977, 174);
			this.dtpDatum.MinDate = new System.DateTime(2023, 6, 19, 17, 5, 20, 610);
			this.dtpDatum.Name = "dtpDatum";
			this.dtpDatum.Size = new System.Drawing.Size(383, 28);
			this.dtpDatum.TabIndex = 30;
			this.dtpDatum.Value = new System.DateTime(2023, 6, 19, 17, 5, 20, 610);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(721, 181);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 19);
			this.label1.TabIndex = 29;
			this.label1.Text = "Datum:";
			// 
			// txtVremeDo
			// 
			this.txtVremeDo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtVremeDo.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			this.txtVremeDo.Location = new System.Drawing.Point(977, 247);
			this.txtVremeDo.Margin = new System.Windows.Forms.Padding(4);
			this.txtVremeDo.Name = "txtVremeDo";
			this.txtVremeDo.Size = new System.Drawing.Size(383, 28);
			this.txtVremeDo.TabIndex = 28;
			// 
			// lblDatumVremeDo
			// 
			this.lblDatumVremeDo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblDatumVremeDo.AutoSize = true;
			this.lblDatumVremeDo.Location = new System.Drawing.Point(719, 258);
			this.lblDatumVremeDo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDatumVremeDo.Name = "lblDatumVremeDo";
			this.lblDatumVremeDo.Size = new System.Drawing.Size(96, 19);
			this.lblDatumVremeDo.TabIndex = 27;
			this.lblDatumVremeDo.Text = "Vreme do:";
			// 
			// cbStolovi
			// 
			this.cbStolovi.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbStolovi.BackColor = System.Drawing.Color.White;
			this.cbStolovi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbStolovi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbStolovi.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			this.cbStolovi.FormattingEnabled = true;
			this.cbStolovi.Location = new System.Drawing.Point(242, 187);
			this.cbStolovi.Margin = new System.Windows.Forms.Padding(4);
			this.cbStolovi.Name = "cbStolovi";
			this.cbStolovi.Size = new System.Drawing.Size(383, 27);
			this.cbStolovi.TabIndex = 26;
			// 
			// lblSto
			// 
			this.lblSto.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblSto.AutoSize = true;
			this.lblSto.Location = new System.Drawing.Point(34, 195);
			this.lblSto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSto.Name = "lblSto";
			this.lblSto.Size = new System.Drawing.Size(38, 19);
			this.lblSto.TabIndex = 25;
			this.lblSto.Text = "Sto:";
			// 
			// dgvStolovi
			// 
			this.dgvStolovi.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvStolovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvStolovi.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvStolovi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvStolovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStolovi.Location = new System.Drawing.Point(27, 322);
			this.dgvStolovi.Name = "dgvStolovi";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvStolovi.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvStolovi.RowHeadersWidth = 51;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			this.dgvStolovi.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvStolovi.RowTemplate.Height = 24;
			this.dgvStolovi.Size = new System.Drawing.Size(598, 384);
			this.dgvStolovi.TabIndex = 24;
			this.dgvStolovi.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvStolovi_RowsAdded);
			this.dgvStolovi.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvStolovi_RowsRemoved);
			// 
			// btnObrisiStolove
			// 
			this.btnObrisiStolove.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnObrisiStolove.BackColor = System.Drawing.Color.White;
			this.btnObrisiStolove.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnObrisiStolove.Location = new System.Drawing.Point(376, 249);
			this.btnObrisiStolove.Name = "btnObrisiStolove";
			this.btnObrisiStolove.Size = new System.Drawing.Size(249, 40);
			this.btnObrisiStolove.TabIndex = 23;
			this.btnObrisiStolove.Text = "Obriši sto/stolove";
			this.btnObrisiStolove.UseVisualStyleBackColor = false;
			this.btnObrisiStolove.Click += new System.EventHandler(this.btnObrisiStolove_Click);
			// 
			// btnDodajSto
			// 
			this.btnDodajSto.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnDodajSto.BackColor = System.Drawing.Color.White;
			this.btnDodajSto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnDodajSto.Location = new System.Drawing.Point(27, 249);
			this.btnDodajSto.Name = "btnDodajSto";
			this.btnDodajSto.Size = new System.Drawing.Size(249, 40);
			this.btnDodajSto.TabIndex = 22;
			this.btnDodajSto.Text = "Dodaj sto";
			this.btnDodajSto.UseVisualStyleBackColor = false;
			this.btnDodajSto.Click += new System.EventHandler(this.btnDodajSto_Click);
			// 
			// lblKeteringMeniVrednost
			// 
			this.lblKeteringMeniVrednost.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblKeteringMeniVrednost.BackColor = System.Drawing.Color.White;
			this.lblKeteringMeniVrednost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblKeteringMeniVrednost.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			this.lblKeteringMeniVrednost.ForeColor = System.Drawing.Color.Black;
			this.lblKeteringMeniVrednost.Location = new System.Drawing.Point(977, 347);
			this.lblKeteringMeniVrednost.Name = "lblKeteringMeniVrednost";
			this.lblKeteringMeniVrednost.Size = new System.Drawing.Size(383, 64);
			this.lblKeteringMeniVrednost.TabIndex = 20;
			this.lblKeteringMeniVrednost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblKeteringMeniVrednost.TextChanged += new System.EventHandler(this.lblKeteringMeniVrednost_TextChanged);
			// 
			// lblKeteringMeni
			// 
			this.lblKeteringMeni.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblKeteringMeni.AutoSize = true;
			this.lblKeteringMeni.Location = new System.Drawing.Point(719, 355);
			this.lblKeteringMeni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblKeteringMeni.Name = "lblKeteringMeni";
			this.lblKeteringMeni.Size = new System.Drawing.Size(127, 19);
			this.lblKeteringMeni.TabIndex = 19;
			this.lblKeteringMeni.Text = "Ketering meni:";
			// 
			// btnIzaberiKeteringMeni
			// 
			this.btnIzaberiKeteringMeni.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnIzaberiKeteringMeni.BackColor = System.Drawing.Color.White;
			this.btnIzaberiKeteringMeni.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnIzaberiKeteringMeni.Location = new System.Drawing.Point(1111, 442);
			this.btnIzaberiKeteringMeni.Name = "btnIzaberiKeteringMeni";
			this.btnIzaberiKeteringMeni.Size = new System.Drawing.Size(249, 42);
			this.btnIzaberiKeteringMeni.TabIndex = 18;
			this.btnIzaberiKeteringMeni.Text = "Izaberi ketering meni";
			this.btnIzaberiKeteringMeni.UseVisualStyleBackColor = false;
			this.btnIzaberiKeteringMeni.Click += new System.EventHandler(this.btnIzaberiKeteringMeni_Click);
			// 
			// cbMesto
			// 
			this.cbMesto.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbMesto.BackColor = System.Drawing.Color.White;
			this.cbMesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbMesto.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			this.cbMesto.FormattingEnabled = true;
			this.cbMesto.Location = new System.Drawing.Point(977, 54);
			this.cbMesto.Margin = new System.Windows.Forms.Padding(4);
			this.cbMesto.Name = "cbMesto";
			this.cbMesto.Size = new System.Drawing.Size(383, 27);
			this.cbMesto.TabIndex = 17;
			// 
			// lblMesto
			// 
			this.lblMesto.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblMesto.AutoSize = true;
			this.lblMesto.Location = new System.Drawing.Point(721, 62);
			this.lblMesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMesto.Name = "lblMesto";
			this.lblMesto.Size = new System.Drawing.Size(63, 19);
			this.lblMesto.TabIndex = 16;
			this.lblMesto.Text = "Mesto:";
			// 
			// lblRadnikVrednost
			// 
			this.lblRadnikVrednost.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblRadnikVrednost.BackColor = System.Drawing.Color.White;
			this.lblRadnikVrednost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblRadnikVrednost.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			this.lblRadnikVrednost.ForeColor = System.Drawing.Color.Black;
			this.lblRadnikVrednost.Location = new System.Drawing.Point(242, 53);
			this.lblRadnikVrednost.Name = "lblRadnikVrednost";
			this.lblRadnikVrednost.Size = new System.Drawing.Size(383, 27);
			this.lblRadnikVrednost.TabIndex = 15;
			this.lblRadnikVrednost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRadnik
			// 
			this.lblRadnik.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblRadnik.AutoSize = true;
			this.lblRadnik.Location = new System.Drawing.Point(34, 62);
			this.lblRadnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRadnik.Name = "lblRadnik";
			this.lblRadnik.Size = new System.Drawing.Size(70, 19);
			this.lblRadnik.TabIndex = 14;
			this.lblRadnik.Text = "Radnik:";
			// 
			// cbKlijent
			// 
			this.cbKlijent.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbKlijent.BackColor = System.Drawing.Color.White;
			this.cbKlijent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbKlijent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbKlijent.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			this.cbKlijent.FormattingEnabled = true;
			this.cbKlijent.Location = new System.Drawing.Point(242, 118);
			this.cbKlijent.Margin = new System.Windows.Forms.Padding(4);
			this.cbKlijent.Name = "cbKlijent";
			this.cbKlijent.Size = new System.Drawing.Size(383, 27);
			this.cbKlijent.TabIndex = 13;
			// 
			// lblKlijent
			// 
			this.lblKlijent.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblKlijent.AutoSize = true;
			this.lblKlijent.Location = new System.Drawing.Point(34, 126);
			this.lblKlijent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblKlijent.Name = "lblKlijent";
			this.lblKlijent.Size = new System.Drawing.Size(62, 19);
			this.lblKlijent.TabIndex = 12;
			this.lblKlijent.Text = "Klijent:";
			// 
			// lblUkupnaCenaVrednost
			// 
			this.lblUkupnaCenaVrednost.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblUkupnaCenaVrednost.BackColor = System.Drawing.Color.White;
			this.lblUkupnaCenaVrednost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblUkupnaCenaVrednost.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			this.lblUkupnaCenaVrednost.ForeColor = System.Drawing.Color.Black;
			this.lblUkupnaCenaVrednost.Location = new System.Drawing.Point(977, 525);
			this.lblUkupnaCenaVrednost.Name = "lblUkupnaCenaVrednost";
			this.lblUkupnaCenaVrednost.Size = new System.Drawing.Size(383, 27);
			this.lblUkupnaCenaVrednost.TabIndex = 11;
			this.lblUkupnaCenaVrednost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbTipProslave
			// 
			this.cbTipProslave.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbTipProslave.BackColor = System.Drawing.Color.White;
			this.cbTipProslave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTipProslave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbTipProslave.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			this.cbTipProslave.FormattingEnabled = true;
			this.cbTipProslave.Location = new System.Drawing.Point(977, 118);
			this.cbTipProslave.Margin = new System.Windows.Forms.Padding(4);
			this.cbTipProslave.Name = "cbTipProslave";
			this.cbTipProslave.Size = new System.Drawing.Size(383, 27);
			this.cbTipProslave.TabIndex = 10;
			// 
			// lblTipProslave
			// 
			this.lblTipProslave.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTipProslave.AutoSize = true;
			this.lblTipProslave.Location = new System.Drawing.Point(720, 121);
			this.lblTipProslave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTipProslave.Name = "lblTipProslave";
			this.lblTipProslave.Size = new System.Drawing.Size(112, 19);
			this.lblTipProslave.TabIndex = 9;
			this.lblTipProslave.Text = "Tip proslave:";
			// 
			// lblUkupnaCenaNapomena
			// 
			this.lblUkupnaCenaNapomena.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblUkupnaCenaNapomena.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblUkupnaCenaNapomena.Location = new System.Drawing.Point(722, 566);
			this.lblUkupnaCenaNapomena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUkupnaCenaNapomena.Name = "lblUkupnaCenaNapomena";
			this.lblUkupnaCenaNapomena.Size = new System.Drawing.Size(226, 71);
			this.lblUkupnaCenaNapomena.TabIndex = 8;
			this.lblUkupnaCenaNapomena.Text = "(Izračunato na osnovu cene svih stolova i keteringa za sve goste)";
			// 
			// lblDatumVremeNapomena
			// 
			this.lblDatumVremeNapomena.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblDatumVremeNapomena.AutoSize = true;
			this.lblDatumVremeNapomena.Font = new System.Drawing.Font("Century Gothic", 8.150944F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblDatumVremeNapomena.Location = new System.Drawing.Point(722, 289);
			this.lblDatumVremeNapomena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDatumVremeNapomena.Name = "lblDatumVremeNapomena";
			this.lblDatumVremeNapomena.Size = new System.Drawing.Size(244, 17);
			this.lblDatumVremeNapomena.TabIndex = 7;
			this.lblDatumVremeNapomena.Text = "(Oba vremena u formatu HH:mm)";
			// 
			// txtVremeOd
			// 
			this.txtVremeOd.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtVremeOd.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			this.txtVremeOd.Location = new System.Drawing.Point(977, 211);
			this.txtVremeOd.Margin = new System.Windows.Forms.Padding(4);
			this.txtVremeOd.Name = "txtVremeOd";
			this.txtVremeOd.Size = new System.Drawing.Size(383, 28);
			this.txtVremeOd.TabIndex = 3;
			// 
			// lblUkupnaCena
			// 
			this.lblUkupnaCena.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblUkupnaCena.AutoSize = true;
			this.lblUkupnaCena.Location = new System.Drawing.Point(721, 533);
			this.lblUkupnaCena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUkupnaCena.Name = "lblUkupnaCena";
			this.lblUkupnaCena.Size = new System.Drawing.Size(124, 19);
			this.lblUkupnaCena.TabIndex = 1;
			this.lblUkupnaCena.Text = "Ukupna cena:";
			// 
			// lblDatumVremeOd
			// 
			this.lblDatumVremeOd.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblDatumVremeOd.AutoSize = true;
			this.lblDatumVremeOd.Location = new System.Drawing.Point(719, 222);
			this.lblDatumVremeOd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDatumVremeOd.Name = "lblDatumVremeOd";
			this.lblDatumVremeOd.Size = new System.Drawing.Size(96, 19);
			this.lblDatumVremeOd.TabIndex = 0;
			this.lblDatumVremeOd.Text = "Vreme od:";
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
			this.Size = new System.Drawing.Size(1415, 786);
			this.Load += new System.EventHandler(this.UCRadSaRezervacijom_Load);
			this.gbUnosStola.ResumeLayout(false);
			this.gbUnosStola.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStolovi)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbUnosStola;
		private System.Windows.Forms.Label lblUkupnaCenaNapomena;
		private System.Windows.Forms.Label lblDatumVremeNapomena;
		private System.Windows.Forms.TextBox txtVremeOd;
		private System.Windows.Forms.Label lblUkupnaCena;
		private System.Windows.Forms.Label lblDatumVremeOd;
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
		private System.Windows.Forms.Label lblKeteringMeniVrednost;
		private System.Windows.Forms.Label lblKeteringMeni;
		private System.Windows.Forms.Button btnDodajSto;
		private System.Windows.Forms.DataGridView dgvStolovi;
		private System.Windows.Forms.Button btnObrisiStolove;
		private System.Windows.Forms.ComboBox cbStolovi;
		private System.Windows.Forms.Label lblSto;
		private TextBox txtVremeDo;
		private Label lblDatumVremeDo;
		private Label label1;
		private DateTimePicker dtpDatum;

		public GroupBox GbUnosStola { get => gbUnosStola; set => gbUnosStola = value; }
		public Label LblUkupnaCenaNapomena { get => lblUkupnaCenaNapomena; set => lblUkupnaCenaNapomena = value; }
		public Label LblDatumVremeNapomena { get => lblDatumVremeNapomena; set => lblDatumVremeNapomena = value; }
		public DateTimePicker DtpDatum { get => dtpDatum; set => dtpDatum = value; }
		public TextBox TxtVremeOd { get => txtVremeOd; set => txtVremeOd = value; }
		public TextBox TxtVremeDo { get => txtVremeDo; set => txtVremeDo = value; }
		public Label LblUkupnaCena { get => lblUkupnaCena; set => lblUkupnaCena = value; }
		public Label LblDatumVreme { get => lblDatumVremeOd; set => lblDatumVremeOd = value; }
		public ComboBox CbTipProslave { get => cbTipProslave; set => cbTipProslave = value; }
		public Label LblTipProslave { get => lblTipProslave; set => lblTipProslave = value; }
		public Label LblUkupnaCenaVrednost { get => lblUkupnaCenaVrednost; set => lblUkupnaCenaVrednost = value; }
		public Label LblRadnikVrednost { get => lblRadnikVrednost; set => lblRadnikVrednost = value; }
		public Label LblRadnik { get => lblRadnik; set => lblRadnik = value; }
		public ComboBox CbKlijent { get => cbKlijent; set => cbKlijent = value; }
		public Label LblKlijent { get => lblKlijent; set => lblKlijent = value; }
		public ComboBox CbMesto { get => cbMesto; set => cbMesto = value; }
		public Label LblMesto { get => lblMesto; set => lblMesto = value; }
		public Button BtnIzaberiKeteringMeni { get => btnIzaberiKeteringMeni; set => btnIzaberiKeteringMeni = value; }
		public Label LblKeteringMeniVrednost { get => lblKeteringMeniVrednost; set => lblKeteringMeniVrednost = value; }
		public Label LblKeteringMeni { get => lblKeteringMeni; set => lblKeteringMeni = value; }
		public Button BtnDodajSto { get => btnDodajSto; set => btnDodajSto = value; }
		public DataGridView DgvStolovi { get => dgvStolovi; set => dgvStolovi = value; }
		public Button BtnObrisiStolove { get => btnObrisiStolove; set => btnObrisiStolove = value; }
		public ComboBox CbStolovi { get => cbStolovi; set => cbStolovi = value; }
		public Label LblSto { get => lblSto; set => lblSto = value; }
	}
}
