using Project.Client.Forms.ServerCommunication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Client.Forms.GUIController.RadnikGUIController
{
	public class RadnikovaGlavnaController
	{ 
		public void ZatvoriKonekciju()
		{
			Communication.Instance.Close();
		}
	}


}
