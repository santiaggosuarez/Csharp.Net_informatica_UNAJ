/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 11/10/2022
 * Time: 4:51 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto2022
{
	class Program
	{
		public static void Main(string[] args)
		{
			bool salir = false;
			
			while (!salir) {
			Console.WriteLine("============ MENÚ ==================");
			Console.WriteLine("1 - Asignar turno");
			Console.WriteLine("2 - Actualizar el diagnóstico de un paciente");
			Console.WriteLine("3 - Cancelar un turno");
			Console.WriteLine("4 - Ver turnos asignados");
			Console.WriteLine("5 - Ver obras sociales de los pacientes");
			Console.WriteLine("6 - Agregar paciente");
			Console.WriteLine("7 - Eliminar paciente");
			Console.WriteLine("8 - Ver pacientes");
			Console.WriteLine("0 - Salir ");
			Console.WriteLine("========================================================");
			
			string op = Console.ReadLine();
			
			switch(op){
				case "1": ; break;
				case "2": ;break;
				case "3": ;break;
				case "4": ;break;
				case "5":  ;break;
				case "6": ;break;
				case "7": ;break;
				case "8": ;break;
				
				case "0": Console.WriteLine("Hasta luego!"); salir = true; break;
				}
			}
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}