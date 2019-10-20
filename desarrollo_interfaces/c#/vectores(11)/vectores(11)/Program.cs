using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vectores_11_
{
	//Noelia: Crea un programa que tenga un vector con dimension 5 de numeros aleatorios, generados por el programa
	//* (que no se lo pidas al usuario ni lo introduczad tu) y ordena el vector de menor a mayor y de mayor a menor


	class Program
	{
		static void Main(string[] args)
		{
			Random r = new Random();
			int[] aleatorio = new int[5];
			int aux;

			for (int i = 0; i<aleatorio.Length; i++)
			{
				aleatorio[i] = r.Next(0, 9);
			}

			Console.Write("Vector: ");
			for (int i = 0; i < aleatorio.Length; i++)
			{
				Console.Write(aleatorio[i] + " ");
			}
			Console.Write("\n");

			for (int i =0; i<aleatorio.Length-1; i++)
			{
				for (int j = i+1; j<aleatorio.Length; j++)
				{
					if (aleatorio[j] > aleatorio[i])
					{
						aux = aleatorio[i];
						aleatorio[i] = aleatorio[j];
						aleatorio[j] = aux;
					}
				}
			}
			Console.Write("Vector de mayor a menor: ");
			for (int i = 0; i < aleatorio.Length; i++)
			{
				Console.Write(aleatorio[i] + " ");
			}
			Console.Write("\n");

			for (int i = 0; i < aleatorio.Length-1; i++)
			{
				for (int j = i + 1; j < aleatorio.Length; j++)
				{
					if (aleatorio[j] < aleatorio[i])
					{
						aux = aleatorio[i];
						aleatorio[i] = aleatorio[j];
						aleatorio[j] = aux;
					}
				}
			}
			Console.Write("Vector de menor a mayor: ");
			for (int i = 0; i < aleatorio.Length; i++)
			{
				Console.Write(aleatorio[i] + " ");
			}
			Console.Write("\n");
			Console.ReadKey();
		}
		
	}
}
