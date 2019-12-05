using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuContextual
{
	public partial class Form1 : Form
	{
		int contador_grande = 0;
		int contador_pequenio = 0;
		public Form1()
		{
			InitializeComponent();
		}

		
		private void grandeToolStripMenuItem_Click(object sender, EventArgs e)
		{			
			if(contador_grande != 2)
			{
				button1.Height = button1.Height * 2;
				button1.Width = button1.Width * 2;
				contador_grande++;
				contador_pequenio--;
			}
			
		}

		private void pequeñoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (contador_pequenio != 2)
			{
				button1.Height = button1.Height / 2;
				button1.Width = button1.Width / 2;
				contador_pequenio++;
				contador_grande--;
			}
		}

		private void fondoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				button1.BackColor = colorDialog1.Color;
			}
		}

		private void textoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				button1.ForeColor = colorDialog1.Color;
			}
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
