/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 14/9/2022
 * Time: 9:03 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej7
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*7) Cree una clase llamada Operación con tres campos: operando1, operando2 y operador. Cada instancia creada
				deberá devolver el resultado correspondiente mediante la llamada a un método evaluar que será encargado
				de efectuar la operación solicitada. El programa de aplicación deberá imprimir todos los resultados
				calculados.
				Por ejemplo:
				Operación op=new Operación(3,4,”+”);
				Console.WriteLine(op.evaluar()); //imprime 7 según el ejemplo*/
			
			Operacion op=new Operacion(3,4,'+');
			Console.WriteLine(op.evaluar());	
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	class Operacion
	{
		// Atributos o propiedades
		private double operando1;
		private double operando2;
		private char operador;
		
		// Constructor
		public Operacion(double operando1, double operando2, char operador){
			this.operando1 = operando1;
			this.operando2 = operando2;
			this.operador = operador;
		}
		
		// Metodo para operar
		public double evaluar(){
			switch(operador){
					case '+': return operando1 + operando2;
					case '-': return operando1 - operando2;
					case '*': return operando1 * operando2;
					case '/': return operando1 / operando2;
					default: return 0;
			}
		}
	}
}