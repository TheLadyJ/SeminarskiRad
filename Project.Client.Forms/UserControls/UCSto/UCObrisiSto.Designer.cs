using System.Windows.Forms;

namespace Project.Client.Forms.UserControls.UCSto
{
    partial class UCObrisiSto
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
			this.gbBrisanjeStola = new System.Windows.Forms.GroupBox();
			this.lblNapomena = new System.Windows.Forms.Label();
			this.btnObrisiSto = new System.Windows.Forms.Button();
			this.dgvStolovi = new System.Windows.Forms.DataGridView();
			this.txtKriterijum = new System.Windows.Forms.TextBox();
			this.btnPretraziSto = new System.Windows.Forms.Button();
			this.gbBrisanjeStola.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStolovi)).BeginInit();
			this.SuspendLayout();
			// 
			// gbBrisanjeStola
			// 
			this.gbBrisanjeStola.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gbBrisanjeStola.BackColor = System.Drawing.Color.Transparent;
			this.gbBrisanjeStola.Controls.Add(this.lblNapomena);
			this.gbBrisanjeStola.Controls.Add(this.btnObrisiSto);
			this.gbBrisanjeStola.Controls.Add(this.dgvStolovi);
			this.gbBrisanjeStola.Controls.Add(this.txtKriterijum);
			this.gbBrisanjeStola.Controls.Add(this.btnPretraziSto);
			this.gbBrisanjeStola.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.gbBrisanjeStola.ForeColor = System.Drawing.Color.White;
			this.gbBrisanjeStola.Location = new System.Drawing.Point(4, 4);
			this.gbBrisanjeStola.Margin = new System.Windows.Forms.Padding(4);
			this.gbBrisanjeStola.Name = "gbBrisanjeStola";
			this.gbBrisanjeStola.Padding = new System.Windows.Forms.Padding(4);
			this.gbBrisanjeStola.Size = new System.Drawing.Size(1273, 740);
			this.gbBrisanjeStola.TabIndex = 2;
			this.gbBrisanjeStola.TabStop = false;
			this.gbBrisanjeStola.Text = "Brisanje stola";
			// 
			// lblNapomena
			// 
			this.lblNapomena.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNapomena.AutoSize = true;
			this.lblNapomena.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblNapomena.Location = new System.Drawing.Point(226, 115);
			this.lblNapomena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNapomena.Name = "lblNapomena";
			this.lblNapomena.Size = new System.Drawing.Size(477, 21);
			this.lblNapomena.TabIndex = 26;
			this.lblNapomena.Text = "(Moguće je pretražiti po kapacitetu, ceni ili proizvođaču)";
			// 
			// btnObrisiSto
			// 
			this.btnObrisiSto.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnObrisiSto.BackColor = System.Drawing.Color.White;
			this.btnObrisiSto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(63)))), ((int)(((byte)(37)))));
			this.btnObrisiSto.Location = new System.Drawing.Point(820, 637);
			this.btnObrisiSto.Margin = new System.Windows.Forms.Padding(4);
			this.btnObrisiSto.Name = "btnObrisiSto";
			this.btnObrisiSto.Size = new System.Drawing.Size(361, 43);
			this.btnObrisiSto.TabIndex = 19;
			this.btnObrisiSto.Text = "Obriši sto";
			this.btnObrisiSto.UseVisualStyleBackColor = false;
			this.btnObrisiSto.Click += new System.EventHandler(this.btnObrisiSto_Click);
			// 
			// dgvStolovi
			// 
			this.dgvStolovi.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvStolovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvStolovi.BackgroundColor = System.Drawing.Color.White;
			this.dgvStolovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStolovi.Location = new System.Drawing.Point(91, 191);
			this.dgvStolovi.Margin = new System.Windows.Forms.Padding(4);
			this.dgvStolovi.Name = "dgvStolovi";
			this.dgvStolovi.ReadOnly = true;
			this.dgvStolovi.RowHeadersWidth = 45;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			this.dgvStolovi.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvStolovi.Size = new System.Drawing.Size(1090, 400);
			this.dgvStolovi.TabIndex = 18;
			// 
			// txtKriterijum
			// 
			this.txtKriterijum.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtKriterijum.Location = new System.Drawing.Point(91, 69);
			this.txtKriterijum.Margin = new System.Windows.Forms.Padding(4);
			this.txtKriterijum.Name = "txtKriterijum";
			this.txtKriterijum.Size = new System.Drawing.Size(663, 28);
			this.txtKriterijum.TabIndex = 12;
			// 
			// btnPretraziSto
			// 
			this.btnPretraziSto.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnPretraziSto.BackColor = System.Drawing.Color.White;
			this.btnPretraziSto.ForeColor = System.Drawing.Color.RoyalBlue;
			this.btnPretraziSto.Location = new System.Drawing.Point(820, 69);
			this.btnPretraziSto.Margin = new System.Windows.Forms.Padding(4);
			this.btnPretraziSto.Name = "btnPretraziSto";
			this.btnPretraziSto.Size = new System.Drawing.Size(361, 43);
			this.btnPretraziSto.TabIndex = 6;
			this.btnPretraziSto.Text = "Pretraži sto";
			this.btnPretraziSto.UseVisualStyleBackColor = false;
			this.btnPretraziSto.Click += new System.EventHandler(this.btnPretraziSto_Click);
			// 
			// UCObrisiSto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.BackgroundImage = global::Project.Client.Forms.Properties.Resources.UCSto;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.gbBrisanjeStola);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UCObrisiSto";
			this.Size = new System.Drawing.Size(1284, 752);
			this.Load += new System.EventHandler(this.UCObrisiSto_Load);
			this.gbBrisanjeStola.ResumeLayout(false);
			this.gbBrisanjeStola.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStolovi)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBrisanjeStola;
        private System.Windows.Forms.DataGridView dgvStolovi;
        private System.Windows.Forms.TextBox txtKriterijum;
        private System.Windows.Forms.Button btnPretraziSto;
        private System.Windows.Forms.Button btnObrisiSto;
		private System.Windows.Forms.Label lblNapomena;

		public GroupBox GbBrisanjeStola { get => gbBrisanjeStola; set => gbBrisanjeStola = value; }
		public DataGridView DgvStolovi { get => dgvStolovi; set => dgvStolovi = value; }
		public TextBox TxtKriterijum { get => txtKriterijum; set => txtKriterijum = value; }
		public Button BtnPretraziSto { get => btnPretraziSto; set => btnPretraziSto = value; }
		public Button BtnObrisiSto { get => btnObrisiSto; set => btnObrisiSto = value; }
		public Label LblNapomena { get => lblNapomena; set => lblNapomena = value; }
	}
}
