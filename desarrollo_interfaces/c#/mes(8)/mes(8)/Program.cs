using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mes_8_
{
	class Program
	{
		static void Main(string[] args)
		{
			int mes = 0;
			int año = 0;

			Console.WriteLine("Introduzca mes: ");
			mes = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Introduzca año: ");
			año = Convert.ToInt32(Console.ReadLine());

			switch (mes)
			{
				case (1):
					Console.WriteLine("Mes: 1\nAño: " +año+"\nDias: 31");
					break;
				case (2):
					if (((año % 4 == 0) && (año % 100 != 0)) && (año % 400 == 0)){
						Console.WriteLine("Mes: 2\nAño: " + año + "\nDias: 29");
						break;
					}else
					{
						Console.WriteLine("Mes: 2\nAño: " + año + "\nDias: 28");
						break;
					}
				case (3):
					Console.WriteLine("Mes: 3\nAño: " + año + "\nDias: 31");
					break;
				case (4):
					Console.WriteLine("Mes: 4\nAño: " + año + "\nDias: 30");
					break;
				case (5):
					Console.WriteLine("Mes: 5\nAño: " + año + "\nDias: 31");
					break;
				case (6):
					Console.WriteLine("Mes: 6\nAño: " + año + "\nDias: 30");
					break;
				case (7):
					Console.WriteLine("Mes: 7\nAño: " + año + "\nDias: 31");
					break;
				case (8):
					Console.WriteLine("Mes: 8\nAño: " + año + "\nDias: 31");
					break;
				case (9):
					Console.WriteLine("Mes: 9\nAño: " + año + "\nDias: 30");
					break;
				case (10):
					Console.WriteLine("Mes: 10\nAño: " + año + "\nDias: 31");
					break;
				case (11):
					Console.WriteLine("Mes: 11\nAño: " + año + "\nDias: 30");
					break;
				case (12):
					Console.WriteLine("Mes: 12\nAño: " + año + "\nDias: 31");
					break;
				
			}
			Console.ReadKey();
		}
		
	}
}
