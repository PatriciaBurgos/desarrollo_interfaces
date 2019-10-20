using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace par_4_
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Introduzca un numero entero: ");
			int num_1;
			num_1 = Convert.ToInt32(Console.ReadLine());


			Console.WriteLine("Introduzca un numero entero: ");
			int num_2;
			num_2 = Convert.ToInt32(Console.ReadLine());


			if ((num_1 % 2 == 0) && (num_2 % 2 == 0))
			{
				Console.WriteLine("Ambos números introducidos son pares.");
				Console.ReadKey();
			}
			else
			{
				Console.WriteLine("Ningun numero introducido es par o al menos uno de ellos no lo es.");
				Console.ReadKey();
			}
		}
	}
}
