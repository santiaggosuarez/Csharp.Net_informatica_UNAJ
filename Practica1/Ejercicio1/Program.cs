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
			// Utilizando la misma lógica que en Python, pero programado en C#
			
			// Declaración de las variables a utilizar
			int num, max, min;
			String numIngresado;
			bool chequeoNum;
			
			Console.Write("Ingrese un número (´0´ para finalizar): ");
			numIngresado = Console.ReadLine();
			
			// Chequear si el valor ingresado se puede convertir a número
			chequeoNum = int.TryParse(numIngresado, out num);
			
			// El programa no continua hasta que se ingrese un valor válido
			while (!chequeoNum){
				Console.Write("Por favor ingrese un valor númerico: ");
				numIngresado = Console.ReadLine();
			
				chequeoNum = int.TryParse(numIngresado, out num);
			}
			
			// Se le da a max y min el valor del primer número ingresado
			// Esto permite que el progama funcione aún si se ingresa un número muy alto o muy bajo
			max = num;
			min = num;
			
			while (num != 0){
				if (num > max ){
					max = num;
				}
				else if (num < min){
					min = num;
				}
				
				Console.Write("Ingrese un número: ");
				numIngresado = Console.ReadLine();
				
				chequeoNum = int.TryParse(numIngresado, out num);
				
				while (!chequeoNum){
				Console.Write("Por favor ingrese un valor númerico: ");
				numIngresado = Console.ReadLine();
			
				chequeoNum = int.TryParse(numIngresado, out num);
				}
			}
			
			Console.WriteLine("\nEl numero mayor es {0} y el menor es {1}", max, min);
			
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}









