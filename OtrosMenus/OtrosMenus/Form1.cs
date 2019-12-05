using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtrosMenus
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openfile = new OpenFileDialog();
			openfile.Title = "Archivos de Imágenes";
			openfile.Filter = "JPEG files|*.JPG";
			openfile.InitialDirectory = @"C:\Users\Lenovo\Desktop";
			if(openfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				try
				{
					pictureBox1.ImageLocation = openfile.FileName;
				}
				catch
				{
					MessageBox.Show("Error: No se puede leer el archivo del disco");
				}
			}
		}

		private void fileToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			UpdateStatus(e.ClickedItem);
		}

		private void UpdateStatus(ToolStripItem item)
		{
			
			string men = String.Format("{0} selected", item.Text);
			this.toolStripStatusLabel1.Text = men;			
			
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{
			
		}



		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			
		}
	}
}
