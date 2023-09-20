
using System;

namespace Clase15A
{
	class Program
	{
		public static void Main(string[] args)
		{
		
			Triangulo t = new Triangulo();
			t.Ingreso();
			t.Imprimir();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}