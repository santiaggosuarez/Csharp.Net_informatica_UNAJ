/*
 * Creado por SharpDevelop.
 * Usuario: Santiago
 * Fecha: 24/8/2022
 * Hora: 5:44 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio1
{
	class Program
	{
		public static void Main(string[] args)
		{	
			// De una secuencia de números ingresado por teclado, imprimir el máximo y mínimo. Pueden usar el 0 para cortar.
			int num, max = 0, min = 0;
			
			Console.Write("Ingrese un número: ");
			num = int.Parse(Console.ReadLine());
			max = num;
			min = num;
			
			while (num != 0){
				if (num > max ){
					max = num;
				} 
				if (num < min){
					min = num;
				}
				
				Console.Write("Ingrese un número: ");
				num = int.Parse(Console.ReadLine());
			}
			
			Console.WriteLine("El numero mayor es {0} y el menor es {1}", max, min);
			
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
