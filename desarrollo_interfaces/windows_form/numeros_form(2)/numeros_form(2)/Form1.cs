using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numeros_form_2_
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		
		private void button1_Click(object sender, EventArgs e)
		{
			int res;
			res = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
			label5.Text =res.ToString();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			label5.Text = ""; 
		}
	}
}
