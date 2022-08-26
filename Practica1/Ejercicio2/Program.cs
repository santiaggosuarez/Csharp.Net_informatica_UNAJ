/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 26/8/2022
 * Time: 9:08 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Implemente un programa de aplicación que permita al usuario ingresar números por la consola.
			// A medida que se van ingresando los valores el sistema debe mostrar por la consola la suma acumulada de los mismos.
			// El proceso termina cuando se ingresa un 0. Informar al final la cantidad total de números ingresados y sumados.
			
			// Declaración de variables para: guardar la suma, la cantidad de números ingresados y hacer el chequeo de que los valores sean númericos
			int num, suma = 0, cant = 0;
			String numIngresado;
			bool chequeoNum;
			
			// Se pide ingreso de un número
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
			
			while (num != 0){
				// Se nuestra la suma e incrementa la cantidad de números
				suma += num;
				Console.Write("La suma hasta el momento es: " + suma);
				cant++;
				
				// Volver a pedir número
				Console.Write("\nIngrese un número: ");
				numIngresado = Console.ReadLine();
			
				// Chequear si el valor ingresado se puede convertir a número
				chequeoNum = int.TryParse(numIngresado, out num);
				
				// El programa no continua hasta que se ingrese un valor válido
				while (!chequeoNum){
				Console.Write("Por favor ingrese un valor númerico: ");
				numIngresado = Console.ReadLine();
			
				chequeoNum = int.TryParse(numIngresado, out num);
			}
				}
			
			// Finalización del programa con la suma y cantidad total
			Console.Write("\nSuma total: {0} \nCantidad de números ingresados: {1}", suma, cant);
			
			Console.Write("\n\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}












