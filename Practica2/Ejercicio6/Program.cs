/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 5/9/2022
 * Time: 6:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio6
{
	class Program
	{
		public static void Main(string[] args)
		{
      //Defina una función que reciba una palabra y retorne en un vector la cantidad de cada una de las vocales que contiene. 
			string pal;
			int j;
			int [] cant_voc = new int[5]{0,0,0,0,0};
			char [] voc = new char[5]{'A','E','I','O','U'};
			Console.Write("Ingrese una palabra: ");
			pal = Console.ReadLine();
      pal = pal.ToUpper();
			contar(pal,ref cant_voc);
			j = 0;
			foreach(int i in cant_voc){
      Console.WriteLine("Letras " + voc[j] + ": " + i);
				j += 1;
			}
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
		static void contar(string p, ref int [] vec)
		{
			for(int i=0;i<p.Length;i++)
			{ char c;
				c = p[i];
				switch (c)
				{
						case 'A': vec[0]=vec[0]+1;break;
						case 'E': vec[1]=vec[1]+1;break;
						case 'I': vec[2]=vec[2]+1;break;
						case 'O': vec[3]=vec[3]+1;break;
						case 'U': vec[4]=vec[4]+1;break;
				}
			}
		}
	}
}