using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maquina_refrescos_6_
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				MessageBox.Show("Introduzca dinero");
			}else
			{
				float dinero = 0;
				dinero =Convert.ToSingle(textBox1.Text);
				if(dinero < 1)
				{
					MessageBox.Show("Falta dinero");
				}else
				{
					textBox2.Text = (dinero - 1).ToString();
				}
				
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(textBox1.Text != "")
			{
				label4.Text = "COCACOLA NORMAL";
			}
			else
				MessageBox.Show("Introduzca dinero");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
				label4.Text = "COCA COLA LIGHT";
			else
				MessageBox.Show("Introduzca dinero");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
				label4.Text = "COCA COLA ZERO";
			else
				MessageBox.Show("Introduzca dinero");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
				label4.Text = "FANTA NARANJA";
			else
				MessageBox.Show("Introduzca dinero");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
				label4.Text = "FANTA LIMON";
			else
				MessageBox.Show("Introduzca dinero");
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
				label4.Text = "AQUARIUS";
			else
				MessageBox.Show("Introduzca dinero");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
				label4.Text = "AGUA";
			else
				MessageBox.Show("Introduzca dinero");
		}
	}
}
