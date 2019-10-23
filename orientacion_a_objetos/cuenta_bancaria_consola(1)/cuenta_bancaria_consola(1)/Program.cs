using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuenta_bancaria_consola_1_
{
	class Program
	{
		static void Main(string[] args)
		{
			Cuenta count = new Cuenta();
			Cuenta_ahorro save_count = new Cuenta_ahorro();

			count.setNombre("Noelia Hernadez");
			count.setNumCuenta("es9841298452");
			count.setSaldo(2050);
			count.setTipoInteres(2);

			save_count.setNombre("Noelia Hernadez");
			save_count.setNumCuenta("es9841298452");
			save_count.setSaldo(2050);
			save_count.setTipoInteres(2);
			save_count.CuentaMantenimiento = 75;

			count.mostrar_estado_cuenta();
			save_count.mostrar_estado_cuenta_ahorro();
			Console.ReadKey();
			
		}
	}
	
}
