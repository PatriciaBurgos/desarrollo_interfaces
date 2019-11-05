using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diseño_mejorado
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			SlidePanel.Height = button1.Height;
			SlidePanel.Top = button1.Top;
			primerControlCustomizado1.BringToFront();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			SlidePanel.Height = button1.Height;
			SlidePanel.Top = button1.Top;
			primerControlCustomizado1.BringToFront();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SlidePanel.Height = button2.Height;
			SlidePanel.Top = button2.Top;
			segundoControlCustomizado1.BringToFront();
		}
	}
}
