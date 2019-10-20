using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sietes_6_
{
	class Program
	{
		static void Main(string[] args)
		{
			/*FOR*/
			string cadena_numeros = "";			
			int cuenta = 0;
			

			Console.WriteLine("Introduzca una cadena de numeros: ");			
			cadena_numeros = Console.ReadLine();

			int length = cadena_numeros.Length;
			char[] arr;

			arr = cadena_numeros.ToCharArray(0, length);

			for (int i = 0; i<length; i++)
			{
				if (arr[i] == '7')
				{
					cuenta +=1;
				}
			}

			Console.WriteLine("(FOR) En la cadena hay " + cuenta + " Sietes" );


			/*FOR EACH*/
			
			int cont = 0;

			foreach (char num in cadena_numeros)
			{
				if (num == '7')
				{
					cont++;
				}
			}
			Console.WriteLine("(FOREACH) En la cadena hay " + cuenta + " Sietes");


			/*DO WHILE*/

			int conta = 0;
			int numeros = 0;
			int sol = 0;

			Console.WriteLine("Introduzca una cadena de numeros: ");
			numeros = Convert.ToInt32(Console.ReadLine());

			do
			{
				sol = numeros % 10;
				if (sol == 7)
				{
					conta++;
				}
				numeros = numeros / 10;
				
			} while (sol != 0);

			Console.WriteLine("(DO WHILE) En la cadena hay " + cuenta + " Sietes");
			Console.ReadKey();

		}
	}
}
