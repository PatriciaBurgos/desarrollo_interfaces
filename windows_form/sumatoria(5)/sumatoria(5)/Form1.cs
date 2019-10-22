using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sumatoria_5_
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int sum = 0;
			decimal tam = numericUpDown1.Value;

			for (int i = 1; i<=tam; i++)
			{
				sum += i;
				if (checkBox1.Checked)
				{
					listBox1.Items.Add ("Sumando: " + i + "; Suma Parcial: " + sum);
				}
			}

			listBox1.Items.Add ("La sumatoria de " + tam + " es " +sum);
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
