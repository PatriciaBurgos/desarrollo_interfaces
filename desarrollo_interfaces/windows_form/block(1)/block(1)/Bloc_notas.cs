using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace block_1_
{
	public partial class Bloc : Form
	{
		public Bloc()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = printDialog1.ShowDialog();

			// If the result is OK then print the document.
			if (result == DialogResult.OK)
			{
				MessageBox.Show("Estás imprimiendo");
			} else
			{
				this.Close();
			}

		}
	}
}
