using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepciones_9_
{
	class ExceptionTest
	{
		
		static void Main()
		{
			
			int num_1 = 0, num_2 = 0;
			

			


			try
			{
				Console.WriteLine("Introduzca numero: ");
				num_1 = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Introduzca numero: ");
				num_2 = Convert.ToInt32(Console.ReadLine());

				int result = num_1 / num_2; ;
				Console.WriteLine("{0} dividido por {1} = {2}", num_1, num_2, result);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			Console.ReadKey();
		}
	}
}
