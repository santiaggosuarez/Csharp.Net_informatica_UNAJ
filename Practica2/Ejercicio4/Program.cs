/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 2/9/2022
 * Time: 6:34 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Ejercicio4
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Haga un programa de aplicación que lea por consola una sucesión de palabras que termina con la palabra vacía.
			// Imprima el porcentaje de palabras que comienzan con ‘s’, la longitud de cada palabra leída y el promedio de caracteres por palabra.
			// Ayuda: si st es una variable de tipo string, st.Length devuelve la cantidad de caracteres del string
			
			Console.Write("Ingrese una palabra (vacío para terminar): ");
			string pal = Console.ReadLine();
			int pal_s = 0, pal_total = 0, char_total = 0;
      double porcentaje_s, promedio_char;
			ArrayList lista = new ArrayList();
			ArrayList lista_long = new ArrayList();
			
			while (pal != ""){
				pal = pal.ToLower();
				lista.Add(pal);
        
        Console.Write("Ingrese una palabra: ");
			  pal = Console.ReadLine();
			}
			
			if (lista.Count > 0) {
				foreach (string i in lista) {
					if (i[0] == 's'){
						pal_s += 1;
					}
					lista_long.Add(i + " " + i.Length);
					char_total += i.Length;
				}
			}
			pal_total = lista.Count;
			porcentaje_s = (100*pal_s)/pal_total;
			promedio_char = char_total/pal_total;
			
			Console.WriteLine("\nPorcentaje de palabras que comienzan con 'S': {0}%", porcentaje_s);
			Console.WriteLine("Promedio de caracteres por palabra: {0}", promedio_char);
      Console.WriteLine("Longitud de cada palabra:");
      foreach(string i in lista_long){
        Console.WriteLine(i);
      }
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}