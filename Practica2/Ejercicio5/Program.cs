/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 5/9/2022
 * Time: 6:04 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio5
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Implemente un programa de aplicación que simule el funcionamiento de una calculadora que permita al usuario
			// realizar las cuatro operaciones elementales e imprimir el resultado de la operación. Para ello el programa debe
			// mostrar un menú de opciones con cada una de las operaciones, luego de seleccionar la operación el programa
			// pide ingresar dos números, realiza la operación solicitada e imprime el resultado. Cada operación se resuelve con
			// una función. El usuario debe poder realizar tantas operaciones como desee hasta seleccionar una opción de salida. 

      calculadora();
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static double suma(double num1, double num2) {
			return num1 + num2;
		}
		static double resta(double num1, double num2 ) {
			return num1 - num2;
		}
		static double multiplicar(double num1, double num2) {
			return num1 * num2;
		}
		static double dividir(double num1, double num2) {
			return num1 / num2;
		}
		
		static void calculadora(){
			
      			Console.WriteLine("Ingrese la operación que desea realizar: ");
			Console.WriteLine("1 = Suma");
			Console.WriteLine("2 = Resta");
			Console.WriteLine("3 = Multiplicación");
			Console.WriteLine("4 = División");
			Console.WriteLine("0 = Salir");
			string op = Console.ReadLine();
      
		      while(op != "1" && op != "2" && op != "3" && op != "4" && op != "0"){
		        Console.Write("Por favor ingrese una operación válida: ");
		        op = Console.ReadLine();
		      }
			
			while(op != "0") {
  			Console.WriteLine("\nIngrese los dos números a operar: ");
  			double valor1 = double.Parse(Console.ReadLine());
  			double valor2 = double.Parse(Console.ReadLine());
  			
  				switch(op) {
  					case "1":
  						Console.WriteLine("El resultado es: {0)}\n",suma(valor1,valor2));
  						break;
  					case "2":
  						Console.WriteLine("La resta es: {0)}\n",resta(valor1,valor2));
  						break;
  					case "3":
  						Console.WriteLine("El producto es: {)}\n",multiplicar(valor1,valor2));
  						break;
  					case "4":
  						Console.WriteLine("El cociente es: {0)}\n",dividir(valor1,valor2));
				              break;
				  				}
		        Console.WriteLine("Ingrese la operación que desea realizar: ");
		        Console.WriteLine("1 = Suma");
		        Console.WriteLine("2 = Resta");
		        Console.WriteLine("3 = Multiplicación");
		        Console.WriteLine("4 = División");
		        Console.WriteLine("0 = Salir");
		        op = Console.ReadLine();
		
		        while(op != "1" && op != "2" && op != "3" && op != "4" && op != "0"){
		        Console.Write("Por favor ingrese una operación válida: ");
		        op = Console.ReadLine();
		        }
			}
		}
	}
}