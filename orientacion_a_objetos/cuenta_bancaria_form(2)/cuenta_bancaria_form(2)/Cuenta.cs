using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuenta_bancaria_consola_1_
{
	public class Cuenta
	{
		private string numCuenta;
		private string nombre;
		private float saldo;
		private float tipoInteres;

		public Cuenta()
		{
			numCuenta = "";
			nombre = "";
			saldo = 0;
			tipoInteres = 0;
		}

		public void setNumCuenta(string num)
		{
			numCuenta = num;
		}
		public void setNombre(string nom)
		{
			nombre = nom;
		}
		public void setSaldo(float sal)
		{
			saldo = sal;
		}
		public void setTipoInteres(float interes)
		{
			tipoInteres = interes;
		}

		public string getNumCuenta()
		{
			return numCuenta;
		}
		public string getNombre()
		{
			return nombre;
		}
		public float getSaldo()
		{
			return saldo;
		}
		public float getTipoInteres()
		{
			return tipoInteres;
		}

		public void mostrar_estado_cuenta()
		{



			Console.WriteLine("Estado de la cuenta");
			Console.WriteLine("Numero de cuenta: " + getNumCuenta());
			Console.WriteLine("Nombre: " + getNombre());
			Console.WriteLine("Saldo: " + getSaldo());
			Console.WriteLine("Tipo de Interes: " + getTipoInteres());
		}
	}
}
