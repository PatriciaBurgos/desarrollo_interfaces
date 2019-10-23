using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuenta_bancaria_consola_1_
{
	class Cuenta_ahorro : Cuenta
	{
		private float cuentaMantenimiento;

		public Cuenta_ahorro()
		{
			CuentaMantenimiento = 0;
		}

		public float CuentaMantenimiento { get => cuentaMantenimiento; set => cuentaMantenimiento = value; }

		public void mostrar_estado_cuenta_ahorro()
		{
			Console.WriteLine("\nEstado de la cuenta de ahorro");
			Console.WriteLine("Numero de cuenta: " + getNumCuenta());
			Console.WriteLine("Nombre: " + getNombre());
			Console.WriteLine("Saldo: " + getSaldo());
			Console.WriteLine("Tipo de Interes: " + getTipoInteres());
			Console.WriteLine("Cuota de mantenimiento: " + this.CuentaMantenimiento);
		}
	}
}
