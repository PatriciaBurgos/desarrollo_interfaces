using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyudaContextualTooltips
{
	public partial class Form1 : Form
	{

		ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
		ToolTip toolTip2 = new System.Windows.Forms.ToolTip();
		ToolTip toolTip3 = new System.Windows.Forms.ToolTip();
		const int TIP_X = 50;
		const int TIP_Y = 100;

		public Form1()
		{
			InitializeComponent();
			toolTip1.OwnerDraw = true;
			toolTip1.Draw += new DrawToolTipEventHandler(toolTip1_Draw);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
			toolTip2.SetToolTip(button1, "Botón Gracias");			
			toolTip1.SetToolTip(label1, "Label Buenos Días");			
			toolTip3.SetToolTip(textBox1, "TextBox Adiós");

			//toolTip1.IsBalloon = true;
			toolTip2.IsBalloon = true;
			toolTip3.IsBalloon = true;

			toolTip1.InitialDelay = 500000;

			//toolTip1.ToolTipIcon = ToolTipIcon.Warning;



		}

		public void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
		{
			Font f = new Font("Arial", 10.0f);
			toolTip1.BackColor = System.Drawing.Color.Red;
			e.DrawBackground();
			e.DrawBorder();
			e.Graphics.DrawString(e.ToolTipText, f, Brushes.Black, new PointF(2, 2));
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
		}
	}
}
