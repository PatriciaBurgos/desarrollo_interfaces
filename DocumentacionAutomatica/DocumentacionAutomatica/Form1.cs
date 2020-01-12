using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentacionAutomatica
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>Método para cambiar el color del botón.</summary>
		/// 
		/// <remarks>Al pulsar en el botón, este método hace que se cambie el color a verde</remarks>
		/// 
		/// <example>Mover el cursor hasta el botón y pulsar con el ratón.</example>
		/// 
		/// <code>
		/// public partial class Form1 : Form
		///		{
		///			public Form1()
		///				{
		///					InitializeComponent();
		///				}
		///			private void button1_Click(object sender, EventArgs e)
		///				{
		///					button1.BackColor = Color.FromArgb(0, 128, 0);
		///				}
		///		}		
		/// </code>
		/// 
		/// <permission cref="System.Security.PermissionSet">Todo el mundo puede acceder a este método</permission>
		/// 
		/// <param name="sender">Es un objeto</param>
		/// <param name="e">Es un EventArgs</param>
		private void button1_Click(object sender, EventArgs e)
		{
			button1.BackColor = Color.FromArgb(0, 128, 0);
		}
	}
}
