using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyudaHelpProvider
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();

			
			this.helpProvider1.SetShowHelp(this.button1, true);
			this.helpProvider1.SetHelpString(this.button1, "This is my button");

		}
	}
}
