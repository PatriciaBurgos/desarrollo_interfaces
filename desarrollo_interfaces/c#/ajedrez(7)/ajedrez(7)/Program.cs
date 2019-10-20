using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajedrez_7_
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int fila = 0; fila <8; fila++)
			{
				for (int colum = 1; colum <9; colum++)
				{
					
					if (colum%2==0 && fila%2==0)
					{
						Console.Write("B ");
					}else if (colum % 2 == 0 && fila % 2 != 0)
					{
						Console.Write("N ");
					}else if(colum % 2 != 0 && fila % 2 == 0)
					{
						Console.Write("N ");
					}else
					{
						Console.Write("B ");
					}
					
				}
				Console.Write("\n");
			}

			int pos_fila = 0;
			int pos_col = 0;

			Console.WriteLine("\n¿En qué posición está tu alfil?");
			do
			{
				Console.Write("\nPosición fila: ");
				pos_fila = Convert.ToInt32(Console.ReadLine());
				Console.Write("\nPosición columna: ");
				pos_col = Convert.ToInt32(Console.ReadLine());

			} while (pos_fila <= 0 || pos_fila > 8 || pos_col <= 0 || pos_col > 8);

			for (int fila = 1; fila < 9; fila++)
			{
				for (int colum = 1; colum < 9; colum++)
				{
					if (fila == pos_fila && colum == pos_col)
					{
						Console.Write("* ");
					}
					else if (colum % 2 == 0 && fila % 2 == 0)
					{
						Console.Write("B ");
					}
					else if (colum % 2 == 0 && fila % 2 != 0)
					{
						Console.Write("N ");
					}
					else if (colum % 2 != 0 && fila % 2 == 0)
					{
						Console.Write("N ");
					}
					else
					{
						Console.Write("B ");
					}

				}
				Console.Write("\n");
			}



			Console.ReadKey();
		}
	}
}
