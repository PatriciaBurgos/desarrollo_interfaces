using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estadocivil_10_
{
	//Haz un programa que tenga un array de string donde vengan los estados civiles(Casado, Soltero, Divorciado, Viudo). 
	//El usuario tendrá que poner su estado civil y se mostrará por pantalla: "Su estado civil es "
	//Si el estado civil no existe deberá aparecer: "Su estado civil es indeterminado"

	class Program
	{
		static void Main(string[] args)
		{
			String[] estados = new String[4] { "Casado", "Soltero", "Divorciado", "Viudo" };
			String estado = " ";

			Console.Write("Indique su estado civil: ");
			for (int i = 0; i<estados.Length; i++)
			{
				
					Console.Write(estados[i] +" ");
			}
			Console.WriteLine("\n");
			estado=Console.ReadLine();

			bool check = false;

			for (int i =0; i<estados.Length && check == false; i++)
			{
				if (estado == "Casado")
				{
					Console.WriteLine("Su estado civil es " + estados[0]);
					check = true;
				} else if (estado == "Soltero")
				{
					Console.WriteLine("Su estado civil es " + estados[1]);
					check = true;
				}
				else if (estado == "Divorciado")
				{
					Console.WriteLine("Su estado civil es " + estados[2]);
					check = true;
				}
				else if (estado == "Viudo")
				{
					Console.WriteLine("Su estado civil es " + estados[3]);
					check = true;
				}
				else
				{
					Console.WriteLine("Su estado civil es indeterminado");
					check = true;
				}
			}
			Console.ReadKey();
		}
		
	}
}
