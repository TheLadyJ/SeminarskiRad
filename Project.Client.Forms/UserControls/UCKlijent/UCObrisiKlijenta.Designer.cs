using System.Windows.Forms;

namespace Project.Client.Forms.UserControls.UCKlijent
{
    partial class UCObrisiKlijenta
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txtKriterijum = new System.Windows.Forms.TextBox();
			this.dgvKlijenti = new System.Windows.Forms.DataGridView();
			this.btnPretraziKlijenta = new System.Windows.Forms.Button();
			this.btnObrisiKlijenta = new System.Windows.Forms.Button();
			this.gbPretraziKlijenta = new System.Windows.Forms.GroupBox();
			this.lblNapomena = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
			this.gbPretraziKlijenta.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtKriterijum
			// 
			this.txtKriterijum.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtKriterijum.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtKriterijum.Location = new System.Drawing.Point(53, 72);
			this.txtKriterijum.Margin = new System.Windows.Forms.Padding(4);
			this.txtKriterijum.Name = "txtKriterijum";
			this.txtKriterijum.Size = new System.Drawing.Size(689, 28);
			this.txtKriterijum.TabIndex = 0;
			// 
			// dgvKlijenti
			// 
			this.dgvKlijenti.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvKlijenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvKlijenti.BackgroundColor = System.Drawing.Color.White;
			this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orchid;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvKlijenti.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvKlijenti.Location = new System.Drawing.Point(53, 177);
			this.dgvKlijenti.Margin = new System.Windows.Forms.Padding(4);
			this.dgvKlijenti.MultiSelect = false;
			this.dgvKlijenti.Name = "dgvKlijenti";
			this.dgvKlijenti.ReadOnly = true;
			this.dgvKlijenti.RowHeadersWidth = 45;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.830189F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			this.dgvKlijenti.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvKlijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvKlijenti.Size = new System.Drawing.Size(1043, 402);
			this.dgvKlijenti.TabIndex = 2;
			// 
			// btnPretraziKlijenta
			// 
			this.btnPretraziKlijenta.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnPretraziKlijenta.BackColor = System.Drawing.Color.White;
			this.btnPretraziKlijenta.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.btnPretraziKlijenta.Location = new System.Drawing.Point(773, 72);
			this.btnPretraziKlijenta.Margin = new System.Windows.Forms.Padding(4);
			this.btnPretraziKlijenta.Name = "btnPretraziKlijenta";
			this.btnPretraziKlijenta.Size = new System.Drawing.Size(323, 39);
			this.btnPretraziKlijenta.TabIndex = 1;
			this.btnPretraziKlijenta.Text = "Pretraži klijenta za brisanje";
			this.btnPretraziKlijenta.UseVisualStyleBackColor = false;
			this.btnPretraziKlijenta.Click += new System.EventHandler(this.btnPretraziKlijenta_Click);
			// 
			// btnObrisiKlijenta
			// 
			this.btnObrisiKlijenta.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnObrisiKlijenta.BackColor = System.Drawing.Color.White;
			this.btnObrisiKlijenta.ForeColor = System.Drawing.Color.SlateBlue;
			this.btnObrisiKlijenta.Location = new System.Drawing.Point(773, 621);
			this.btnObrisiKlijenta.Margin = new System.Windows.Forms.Padding(4);
			this.btnObrisiKlijenta.Name = "btnObrisiKlijenta";
			this.btnObrisiKlijenta.Size = new System.Drawing.Size(323, 39);
			this.btnObrisiKlijenta.TabIndex = 3;
			this.btnObrisiKlijenta.Text = "Obriši klijenta";
			this.btnObrisiKlijenta.UseVisualStyleBackColor = false;
			this.btnObrisiKlijenta.Click += new System.EventHandler(this.btnObrisiKlijenta_Click);
			// 
			// gbPretraziKlijenta
			// 
			this.gbPretraziKlijenta.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gbPretraziKlijenta.BackColor = System.Drawing.Color.Transparent;
			this.gbPretraziKlijenta.Controls.Add(this.lblNapomena);
			this.gbPretraziKlijenta.Controls.Add(this.btnObrisiKlijenta);
			this.gbPretraziKlijenta.Controls.Add(this.btnPretraziKlijenta);
			this.gbPretraziKlijenta.Controls.Add(this.dgvKlijenti);
			this.gbPretraziKlijenta.Controls.Add(this.txtKriterijum);
			this.gbPretraziKlijenta.Font = new System.Drawing.Font("Century Gothic", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.gbPretraziKlijenta.ForeColor = System.Drawing.Color.White;
			this.gbPretraziKlijenta.Location = new System.Drawing.Point(4, 4);
			this.gbPretraziKlijenta.Margin = new System.Windows.Forms.Padding(4);
			this.gbPretraziKlijenta.Name = "gbPretraziKlijenta";
			this.gbPretraziKlijenta.Padding = new System.Windows.Forms.Padding(4);
			this.gbPretraziKlijenta.Size = new System.Drawing.Size(1148, 719);
			this.gbPretraziKlijenta.TabIndex = 2;
			this.gbPretraziKlijenta.TabStop = false;
			this.gbPretraziKlijenta.Text = "Brisanje klijenta";
			// 
			// lblNapomena
			// 
			this.lblNapomena.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNapomena.AutoSize = true;
			this.lblNapomena.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblNapomena.Location = new System.Drawing.Point(164, 114);
			this.lblNapomena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNapomena.Name = "lblNapomena";
			this.lblNapomena.Size = new System.Drawing.Size(526, 21);
			this.lblNapomena.TabIndex = 41;
			this.lblNapomena.Text = "(Moguće je pretražiti po imenu, prezimenu, telefonu ili email-u)";
			// 
			// UCObrisiKlijenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.BackgroundImage = global::Project.Client.Forms.Properties.Resources.UCKlijent;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.gbPretraziKlijenta);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UCObrisiKlijenta";
			this.Size = new System.Drawing.Size(1160, 736);
			this.Load += new System.EventHandler(this.UCObrisiKlijenta_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
			this.gbPretraziKlijenta.ResumeLayout(false);
			this.gbPretraziKlijenta.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtKriterijum;
        private System.Windows.Forms.DataGridView dgvKlijenti;
        private System.Windows.Forms.Button btnPretraziKlijenta;
        private System.Windows.Forms.Button btnObrisiKlijenta;
        private System.Windows.Forms.GroupBox gbPretraziKlijenta;
		private Label lblNapomena;

		public TextBox TxtKriterijum { get => txtKriterijum; set => txtKriterijum = value; }
		public DataGridView DgvKlijenti { get => dgvKlijenti; set => dgvKlijenti = value; }
		public Button BtnPretraziKlijenta { get => btnPretraziKlijenta; set => btnPretraziKlijenta = value; }
		public Button BtnObrisiKlijenta { get => btnObrisiKlijenta; set => btnObrisiKlijenta = value; }
		public GroupBox GbPretraziKlijenta { get => gbPretraziKlijenta; set => gbPretraziKlijenta = value; }
	}
}
