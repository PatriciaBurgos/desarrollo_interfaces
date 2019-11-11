using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoAhorcado
{
	public partial class Game : Form
	{
		string[] palabras = new String [100];
		int util_pal = 0;
		string palabra_elegida;
		int aleatorio;
		int num_letras;
		List<Label> labels = new List<Label>();
		int fallos;

		public Game()
		{
			InitializeComponent();
			palabras[0] = "HOLA";
			palabras[1] = "ADIOS";
			palabras[2] = "RATONINA";
			palabras[3] = "CUADRO";
			palabras[4] = "PUERTAS";
			palabras[5] = "MESILLAS";
			palabras[6] = "PERRO";
			palabras[7] = "GATITO";
			util_pal = 7;

			botones_no_disponibles();
			
		}

		public void elegir_palabra()
		{
			Random r = new Random();
			aleatorio = r.Next(0, util_pal);
			palabra_elegida = palabras[aleatorio];
		}

		public void contar_palabras()
		{
			num_letras=palabra_elegida.Length;
			label1.Text = num_letras.ToString();
		}
		
		public void pintar_label_letras()
		{
			char[] char_pal = new char[num_letras];
			for(int i = 0; i<num_letras; i++)
			{
				char_pal[i] = palabra_elegida[i];
			}
			int posicion_inicio = 270;
			
			for (int i = 0; i < num_letras; i++)
			{
				Label label = new Label();
				label.Font = new Font(this.Font.Name, 18, FontStyle.Underline);
				label.Location = new Point (posicion_inicio, 150);
				label.BringToFront();
				//label.Text += char_pal[i];
				 label.Text += "_";
				this.Controls.Add(label);
				labels.Add(label);
				label.AutoSize = true;
				posicion_inicio = label.Right;
			}

			

			for (int i = 0; i<num_letras; i++)
			{
				labels[i].Refresh();
				labels[i].Refresh();
				labels[i].Visible = true;
			}
		}

		public void fallo()
		{
			if(fallos == 1)
			{
				pictureBox1.Visible = true;
			}else if (fallos == 2)
			{
				pictureBox2.Visible = true;
			}
			else if (fallos == 3)
			{
				pictureBox3.Visible = true;
			}
			else if (fallos == 4)
			{
				pictureBox4.Visible = true;
			}
			else if (fallos == 5)
			{
				pictureBox5.Visible = true;
			}
			else if (fallos == 6)
			{
				pictureBox6.Visible = true;
			}
			else if (fallos == 7)
			{
				pictureBox7.Visible = true;
			}
			else if (fallos == 8)
			{
				pictureBox8.Visible = true;
			}
			else if (fallos == 9)
			{
				pictureBox9.Visible = true;
			}
			else if (fallos == 10)
			{
				pictureBox10.Visible = true;
				botones_no_disponibles();
				MessageBox.Show("HA PERDIDO. LA PALABRA ERA "+ palabra_elegida+ ", VUELVA A INICIAR PROGRAMA");
			}
		}
		
		public void botones_no_disponibles()
		{
			button2.Enabled = false;
			button3.Enabled = false;
			button4.Enabled = false;
			button5.Enabled = false;
			button6.Enabled = false;
			button7.Enabled = false;
			button8.Enabled = false;
			button9.Enabled = false;
			button10.Enabled = false;
			button11.Enabled = false;
			button12.Enabled = false;
			button13.Enabled = false;
			button14.Enabled = false;
			button15.Enabled = false;
			button16.Enabled = false;
			button17.Enabled = false;
			button18.Enabled = false;
			button19.Enabled = false;
			button20.Enabled = false;
			button21.Enabled = false;
			button25.Enabled = false;
			button26.Enabled = false;
			button27.Enabled = false;
			button28.Enabled = false;
			button29.Enabled = false;
			button30.Enabled = false;
			button31.Enabled = false;
		}

		public void botones_disponibles()
		{
			button2.Enabled = true;
			button3.Enabled = true;
			button4.Enabled = true;
			button5.Enabled = true;
			button6.Enabled = true;
			button7.Enabled = true;
			button8.Enabled = true;
			button9.Enabled = true;
			button10.Enabled = true;
			button11.Enabled = true;
			button12.Enabled = true;
			button13.Enabled = true;
			button14.Enabled = true;
			button15.Enabled = true;
			button16.Enabled = true;
			button17.Enabled = true;
			button18.Enabled = true;
			button19.Enabled = true;
			button20.Enabled = true;
			button21.Enabled = true;
			button25.Enabled = true;
			button26.Enabled = true;
			button27.Enabled = true;
			button28.Enabled = true;
			button29.Enabled = true;
			button30.Enabled = true;
			button31.Enabled = true;
		}

		public void color_defecto()
		{
			Color c1 = Color.FromArgb(192, 255, 255);
			button2.BackColor = c1;
			button3.BackColor = c1;
			button4.BackColor = c1;
			button5.BackColor = c1;
			button6.BackColor = c1;
			button7.BackColor = c1;
			button8.BackColor = c1;
			button9.BackColor = c1;
			button10.BackColor = c1;
			button11.BackColor = c1;
			button12.BackColor = c1;
			button13.BackColor = c1;
			button14.BackColor = c1;
			button15.BackColor = c1;
			button16.BackColor = c1;
			button17.BackColor = c1;
			button18.BackColor = c1;
			button19.BackColor = c1;
			button20.BackColor = c1;
			button21.BackColor = c1;
			button25.BackColor = c1;
			button26.BackColor = c1;
			button27.BackColor = c1;
			button28.BackColor = c1;
			button29.BackColor = c1;
			button30.BackColor = c1;
			button31.BackColor = c1;

		}

		public void imagenes_invisibles()
		{
			pictureBox1.Visible = false;
			pictureBox2.Visible = false;
			pictureBox3.Visible = false;
			pictureBox4.Visible = false;
			pictureBox5.Visible = false;
			pictureBox6.Visible = false;
			pictureBox7.Visible = false;
			pictureBox8.Visible = false;
			pictureBox9.Visible = false;
			pictureBox10.Visible = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			num_letras = 0;
			palabra_elegida = "";
			aleatorio = 0;
			fallos = 0;
			
			foreach (Label lb in labels) 
			{ 				
				lb.Dispose();
			}
			labels = new List<Label>();

			elegir_palabra();
			//MessageBox.Show(palabra_elegida);
			contar_palabras();
			pintar_label_letras();
			color_defecto();
			botones_disponibles();
			imagenes_invisibles();
						

			if (radioButton1.Checked == true)
			{
				int ale1 = 0;
				int ale2 = 0;

				Random r1 = new Random();
				ale1 = r1.Next(0, palabra_elegida.Length);
				ale2 = r1.Next(0, palabra_elegida.Length);

				Color c1 = Color.FromArgb(0, 255, 0);
				
				foreach (Button bt in panel2.Controls)
				{
					if (bt.Text.ToString() == palabra_elegida[ale1].ToString())
						{
						bt.BackColor = c1;
						bt.Enabled = false;
						labels[ale1].Text = bt.Text.ToString();
					}
				}
				
				foreach (Button bt in panel2.Controls)
				{					
					if (bt.Text.ToString() == palabra_elegida[ale2].ToString())
					{
						bt.BackColor = c1;
						bt.Enabled = false;
						labels[ale2].Text = bt.Text.ToString();
					}
				}
			} else if(radioButton2.Checked == true)
			{
				int ale1 = -1;

				Random r1 = new Random();
				ale1 = r1.Next(0, palabra_elegida.Length);

				Color c1 = Color.FromArgb(0, 255, 0);

				foreach (Button bt in panel2.Controls)
				{
					if (bt.Text.ToString() == palabra_elegida[ale1].ToString())
					{
						bt.BackColor = c1;
						bt.Enabled = false;
						labels[ale1].Text = bt.Text.ToString();
					}
				}

			}
			
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void firstScreen1_Load(object sender, EventArgs e)
		{
		}

		private void aniadir_palabra()
		{
			util_pal++;
			palabras[util_pal]=(textBox1.Text.ToUpper());
			//MessageBox.Show(palabras[util_pal]);
			textBox1.Text = "";
		}

		private void button21_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("Q");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button21.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button21.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'Q')
					{
						labels[i].Text = "Q";
					}
					i++;
				}
			}
			button21.Enabled = false;

			bool fin = true;
			foreach (Label lb in labels)
			{
				if(lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true) {
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void Game_Load(object sender, EventArgs e)
		{

		}

		private void button20_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("W");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button20.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button20.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'W')
					{
						labels[i].Text = "W";
					}
					i++;
				}
			}
			button20.Enabled = false;

			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button19_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("E");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button19.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button19.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'E')
					{
						labels[i].Text = "E";
					}
					i++;
				}
			}
			button19.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button18_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("R");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button18.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button18.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'R')
					{
						labels[i].Text = "R";
					}
					i++;
				}
			}
			button18.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button17_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("T");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button17.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button17.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'T')
					{
						labels[i].Text = "T";
					}
					i++;
				}
			}
			button17.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button16_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("Y");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button16.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button16.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'Y')
					{
						labels[i].Text = "Y";
					}
					i++;
				}
			}
			button16.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button15_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("U");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button15.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button15.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'U')
					{
						labels[i].Text = "U";
					}
					i++;
				}
			}
			button15.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button14_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("I");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button14.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button14.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'I')
					{
						labels[i].Text = "I";
					}
					i++;
				}
			}
			button14.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button13_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("O");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button13.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button13.BackColor = c1;				
				int i=0;
				foreach(char c in palabra_elegida)
				{
					if (c == 'O')
					{
						labels[i].Text = "O";
					}
					i++;
				}		
			}
			button13.Enabled=false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("A");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button2.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button2.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'A')
					{
						labels[i].Text = "A";
					}
					i++;
				}
			}
			button2.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button12_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("P");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button12.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button12.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'P')
					{
						labels[i].Text = "P";
					}
					i++;
				}
			}
			button12.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("S");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button3.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button3.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'S')
					{
						labels[i].Text = "S";
					}
					i++;
				}
			}
			button3.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("D");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button4.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button4.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'D')
					{
						labels[i].Text = "D";
					}
					i++;
				}
			}
			button4.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("F");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button5.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button5.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'F')
					{
						labels[i].Text = "F";
					}
					i++;
				}
			}
			button5.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("G");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button6.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button6.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'G')
					{
						labels[i].Text = "G";
					}
					i++;
				}
			}
			button6.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("H");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button7.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button7.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'H')
					{
						labels[i].Text = "H";
					}
					i++;
				}
			}
			button7.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("J");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button8.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button8.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'J')
					{
						labels[i].Text = "J";
					}
					i++;
				}
			}
			button8.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("K");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button9.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button9.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'K')
					{
						labels[i].Text = "K";
					}
					i++;
				}
			}
			button9.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("L");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button10.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button10.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'L')
					{
						labels[i].Text = "L";
					}
					i++;
				}
			}
			button10.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button11_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("Ñ");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button11.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button11.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'Ñ')
					{
						labels[i].Text = "Ñ";
					}
					i++;
				}
			}
			button11.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button31_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("Z");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button31.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button31.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'Z')
					{
						labels[i].Text = "Z";
					}
					i++;
				}
			}
			button31.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button30_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("X");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button30.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button30.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'X')
					{
						labels[i].Text = "X";
					}
					i++;
				}
			}
			button30.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button29_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("C");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button29.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button29.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'C')
					{
						labels[i].Text = "C";
					}
					i++;
				}
			}
			button29.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button28_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("V");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button28.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button28.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'V')
					{
						labels[i].Text = "V";
					}
					i++;
				}
			}
			button28.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button27_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("B");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button27.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button27.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'B')
					{
						labels[i].Text = "B";
					}
					i++;
				}
			}
			button27.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button26_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("N");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button26.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button26.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'N')
					{
						labels[i].Text = "N";
					}
					i++;
				}
			}
			button26.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button25_Click(object sender, EventArgs e)
		{
			int index = -1;
			index = palabra_elegida.IndexOf("M");

			if (index == -1)
			{
				Color c1 = Color.FromArgb(255, 0, 0);
				button25.BackColor = c1;
				fallos++;
				fallo();
			}
			else
			{
				Color c1 = Color.FromArgb(0, 255, 0);
				button25.BackColor = c1;
				int i = 0;
				foreach (char c in palabra_elegida)
				{
					if (c == 'M')
					{
						labels[i].Text = "M";
					}
					i++;
				}
			}
			button25.Enabled = false;
			bool fin = true;
			foreach (Label lb in labels)
			{
				if (lb.Text == "_")
				{
					fin = false;
					break;
				}
			}
			if (fin == true)
			{
				MessageBox.Show("ENHORABUENA! VUELVA A INICIAR PROGRAMA");
				botones_no_disponibles();
			}
		}

		private void button22_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button23_Click(object sender, EventArgs e)
		{
			if(textBox2.Text == "patri" && textBox3.Text == "patri")
			{
				aniadir_palabra();
			}
			else
			{
				MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTA");
			}
			
		}
	}
}
