using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion__MySQL
{
	public partial class Form1 : Form
	{
		static MySqlConnection Conex = new MySqlConnection();
		static string serv = "Server=localhost;";
		static string db = "Database=agenda;";
		static string usuario = "UID=root;";
		static string pwd = "Password=josegras;";
		string CadenaDeConexion = serv + db + usuario + pwd;

		public Form1()
		{
			InitializeComponent();
		}

		public void Conectar()
		{
			try
			{
				Conex.ConnectionString = CadenaDeConexion;
				Conex.Open();
				MessageBox.Show("Base de datos conectada");
			}
			catch (Exception)
			{
				MessageBox.Show("Ocurrio un error al conectar la base de datos");
				throw;
			}
		}

		public static void Desconectar()
		{
			Conex.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Conectar();
			cargar_data_grid_view();
			cargar_combo_box();
			Desconectar();
		}

		public void cargar_data_grid_view()
		{
			DataTable dt = new DataTable();
			MySqlCommand cmd = Conex.CreateCommand();
			cmd.CommandText = "select * from contactos";
			MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
			adap.Fill(dt);
			dataGridView2.DataSource = dt;
		}

		public void cargar_combo_box()
		{
			DataTable dt = new DataTable();
			MySqlCommand cmd = Conex.CreateCommand();
			cmd.CommandText = "SELECT cp FROM contactos;";
			MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
			adap.Fill(dt);

			foreach(DataRow row in dt.Rows)
			{
				foreach (DataColumn col in dt.Columns)
				{
					comboBox1.Items.Add(row[col]);
				}
			}
			//Cuando añada la persona, tengo que añadir el cp
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Conectar();
			DataTable dt = new DataTable();
			MySqlCommand cmd = Conex.CreateCommand();
			int num = dataGridView2.RowCount;
			cmd.CommandText = "INSERT INTO contactos VALUES(?id_contacto, ?nombre, ?apellidos, ?telefono, ?direccion, ?cp, ?poblacion)";
			cmd.Parameters.AddWithValue("?id_contacto", num.ToString());
			cmd.Parameters.AddWithValue("?nombre", textBox1.Text);
			cmd.Parameters.AddWithValue("?apellidos", textBox2.Text);
			cmd.Parameters.AddWithValue("?telefono", textBox3.Text);
			cmd.Parameters.AddWithValue("?direccion", textBox4.Text);
			cmd.Parameters.AddWithValue("?cp", textBox5.Text);
			cmd.Parameters.AddWithValue("?poblacion", textBox6.Text);
			MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
			adap.Fill(dt);

			comboBox1.Items.Add(textBox5.Text);
			Desconectar();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			dataGridView2.DataSource = null;
			DataTable dt = new DataTable();
			MySqlCommand cmd = Conex.CreateCommand();
			String cp = comboBox1.SelectedItem.ToString();
			MessageBox.Show(cp);

			cmd.CommandText = "SELECT * FROM contactos WHERE cp like '"+ cp +"';";

			MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
			adap.Fill(dt);
			dataGridView2.DataSource = dt;
		}

		
	}	
}

