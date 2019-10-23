using cuenta_bancaria_consola_1_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuenta_bancaria_form_2_
{
	public partial class Form1 : Form
	{
		Cuenta count = new Cuenta();
		Cuenta_ahorro save_count = new Cuenta_ahorro(); 

		public Form1()
		{
			InitializeComponent();

			count.setNombre("Noelia Hernadez");
			count.setNumCuenta("es9841298452");
			count.setSaldo(2050);
			count.setTipoInteres(2);

			save_count.setNombre("Noelia Hernadez");
			save_count.setNumCuenta("es9841298452");
			save_count.setSaldo(2050);
			save_count.setTipoInteres(2);
			save_count.CuentaMantenimiento = 75;
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			label12.Text = count.getNumCuenta();
			label13.Text = count.getNombre();
			label14.Text = count.getSaldo().ToString();
			label15.Text = count.getTipoInteres().ToString();

			label16.Text = save_count.getNumCuenta();
			label17.Text = save_count.getNombre();
			label18.Text = save_count.getSaldo().ToString();
			label19.Text = save_count.getTipoInteres().ToString();
			label20.Text = save_count.CuentaMantenimiento.ToString();
		}

		private void label12_Click(object sender, EventArgs e)
		{

		}
	}
}
