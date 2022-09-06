/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 5/9/2022
 * Time: 8:14 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 5/9/2022
 * Time: 8:14 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio7
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Implemente una función que reciba una matriz (arreglo de dos dimensiones)
			// pasada como parámetro, e imprima por consola la suma de sus elementos

      // Creación de la matriz (su suma da 78)
			double [,] matriz = new double[,] {{ 1, 2, 3, 4 },{ 5, 6, 7, 8 },{ 9, 10, 11, 12 }};
			
			Console.WriteLine("Suma total de los elementos: " + sumaMatriz(matriz));
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static double sumaMatriz(double [,] mat){
			double suma = 0;
      // Con get length obtenemos el largo de cada dimensión (0,1)
			int row = mat.GetLength(0);
			int column = mat.GetLength(1);
      // Primero se selecciona la fila (i) y con el for anidado se recorre la columna (k) dentro de ella
			for(int i = 0; i < row; i++){
				for (int k = 0; k < column; k++){
					suma += mat[i,k];
				}
			}
			return suma;
		}
	}
}