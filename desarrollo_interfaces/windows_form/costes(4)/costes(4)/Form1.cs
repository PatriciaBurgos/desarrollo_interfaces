using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace costes_4_
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			label2.Text = "2€";
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			label2.Text = "2,5€";
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			label2.Text = "5€";
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
