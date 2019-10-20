using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adivino_5_
{
	class Program
	{
		static void Main(string[] args)
		{
			Random r = new Random();
			int aleatorio = r.Next(0, 20);

			int num = 0;
			int intentos = 0;
			bool acierto = false;

			while ((intentos < 5) && (acierto == false))
			{
				intentos++;

				Console.WriteLine("Introduzca un numero entero: ");
				int num_introducido;
				num_introducido = Convert.ToInt32(Console.ReadLine());

				if (num_introducido == aleatorio)
				{
					Console.WriteLine("Numero correcto");
					acierto = true;
					Console.ReadKey();
				}
				else
				{
					if(num_introducido > aleatorio)
					{
						Console.WriteLine("Intentelo con un numero MENOR");
					}
					else
					{
						Console.WriteLine("Intentelo con un numero MAYOR");
					}
				}
			}

			if (acierto == false)
			{
				Console.WriteLine("Lo siento, el numero era: " + aleatorio);
				Console.ReadKey();
			}
				

		}
	}
}
