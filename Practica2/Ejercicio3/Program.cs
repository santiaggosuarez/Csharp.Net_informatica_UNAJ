/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 2/9/2022
 * Time: 12:58 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Practica2
{
	class Program
	{
		public static void Main(string[] args)
		{
			// 3- Escriba un programa de aplicación que lea 2 palabras y determine si son palíndromos entre ellas. (Ej: “abbccd” y “dccbba” son palíndromos). 
			
			Console.WriteLine("Ingrese dos palabras a comparar: ");
			String pal1 = Console.ReadLine();
			String pal2 = Console.ReadLine();
			
			pal1 = pal1.ToLower();
			pal2 = pal2.ToLower();
			
			bool palind;
							
			if (pal1.Length  == pal2.Length){
				
				palind = true;
				int largo_pal2 = pal2.Length;
				int j = largo_pal2 -1;
				
					for (int i = 0; i < largo_pal2; i++ ){
					if (pal1[i] != pal2[j]) {
						palind = false;
						break;
					}
					else {
						j = j -1;
						palind = true;
					}
				}
 			}
			else {
				palind = false;
			}
			
			if (palind){
				Console.WriteLine("\nES palindromo.");
			}
			else {
				Console.WriteLine("\nNO es palindromo.");
			}
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}