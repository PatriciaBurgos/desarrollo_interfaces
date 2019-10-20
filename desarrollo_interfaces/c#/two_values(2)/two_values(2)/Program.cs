using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_values_2_
{
	class Program
	{
		static void Main(string[] args)
		{
			int num_1 = 2;
			int num_2 = 1;
			int sum = 0;
			int res = 0;
			int mul = 0;
			int div = 0;

			sum = num_1 + num_2;
			res = num_1 - num_2;
			mul = num_1 * num_2;
			div = num_1 / num_2;

			Console.WriteLine("La suma de " + num_1 + " + " + num_2 + " es " + sum);
			Console.ReadKey();

			Console.WriteLine("La resta de " + num_1 + " - " + num_2 + " es " + res);
			Console.ReadKey();

			Console.WriteLine("La multiplicacion de " + num_1 + " x " + num_2 + " es " + mul);
			Console.ReadKey();

			Console.WriteLine("La división de " + num_1 + " / " + num_2 + " es " + div);
			Console.ReadKey();
		}
	}
}
