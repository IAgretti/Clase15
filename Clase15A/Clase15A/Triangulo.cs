
using System;

namespace Clase15A
{
	/// <summary>
	/// Description of Triangulo.
	/// </summary>
	public class Triangulo
	{
		public int l1, l2, l3;
		
		public void Ingreso(){
			Console.Write("Ingrese el valor del lado 1: ");
			l1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Ingrese el valor del lado 2: ");
			l2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Ingrese el valor del lado 3: ");
			l3 = Convert.ToInt32(Console.ReadLine());			              
		}
		public string TipoTriangulo(){
			string tipo = "";
			if ((l1 == l2) && (l1==l3))
				tipo = "EQUILÁTERO";
			else if ((l1 == l2) && (l1 != l3) || (l2 == l3) && (l3 != l1) || (l3 == l1) && (l1 != l2))
				tipo = "ISÓSCELES";
			else if ((l1 != l2) && (l1 != l3) && (l2 != l3))
				tipo = "ESCALENO";
			return tipo;
		}
		public void Imprimir(){
			Console.WriteLine("El triángulo formado con los lados ingresados es: " + TipoTriangulo());
		}
	}
}
