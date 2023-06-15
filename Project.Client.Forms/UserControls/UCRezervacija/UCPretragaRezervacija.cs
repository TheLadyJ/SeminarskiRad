﻿using Project.Client.Forms.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Client.Forms.UserControls.UCRezervacija
{
	public partial class UCPretragaRezervacija : UserControl
	{
		public UCPretragaRezervacija()
		{
			InitializeComponent();
		}

		private void btnIzaberiKeteringMeni_Click(object sender, EventArgs e)
		{
			FrmIzaberiKeteringMeni frmIzaberiKeteringMeni = new FrmIzaberiKeteringMeni();
			frmIzaberiKeteringMeni.ShowDialog();
		}
	}
}
