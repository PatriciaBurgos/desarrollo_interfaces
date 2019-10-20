using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_3_
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

			if (num_1 > num_2)
			{
				Console.WriteLine(num_1 + " es mayor que " + num_2);
				Console.ReadKey();
			}
			else if (num_1 < num_2)
			{
				Console.WriteLine(num_2 + " es mayor que " + num_1);
				Console.ReadKey();
			}
			else if (num_2 == num_1){
				Console.WriteLine(num_1 + " es igual que " + num_2);
				Console.ReadKey();
			}
		}
	}
}
