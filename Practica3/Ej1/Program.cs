/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 9/9/2022
 * Time: 10:39 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Ej1
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Escriba un programa de aplicación que reciba una lista de palabras e informe cuáles son palíndromos usando una función.
			
			// Declaro e inicializo la lista a revisar.
			ArrayList lista1 = new ArrayList() {"palindromo","ana","menem","neuquen","santiago"};
			// Declaro la lista que almacenará los palindromos
			ArrayList lista2 = new ArrayList();
			
			// Recorro la lista y si una palabra es palindromo la agrego a la lista correspondiente
			foreach (string i in lista1){
				if (esPalindromo(i)) { lista2.Add(i); }
			}
			
			// Imprimo la lista de palindromos
			Console.WriteLine("Lista de palindromos:");
			imprimirLista(lista2);
			
			Console.ReadKey(true);
		}
		
		// Funcion para definir si una palabra es palindromo
		public static bool esPalindromo(string pal1){
			int j = pal1.Length -1;
				
			for (int i = 0; i < j; i++){
				if (pal1[i] != pal1[j]) {
					return false;
				}
				j = j-1;
			}
			return true;
		}
		
		// Funcion para imprimir strings de un arraylist
		public static void imprimirLista(ArrayList lista){
			foreach (string i in lista){
				Console.WriteLine(i);
			}
		}
		
	}
}