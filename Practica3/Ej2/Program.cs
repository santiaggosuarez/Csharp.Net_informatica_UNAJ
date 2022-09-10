/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 9/9/2022
 * Time: 10:36 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Ej2
{
	class Program
	{
		public static void Main(string[] args)
		{
			/* Desarrolle un programa de aplicación que simule la inscripción de participantes de distintas escuelas a una
			competencia de matemática. De cada alumno se conoce su Dni y el nombre de la escuela a la que representa.
			Pueden inscribirse (en forma desordenada) varios alumnos de la misma escuela. Arme un menú que permita:
			a. Inscribir un alumno (armar una lista de alumnos inscriptos)
			b. Borrar un alumno (eliminarlo de la lista de alumnos inscriptos)
			c. Indicar total de alumnos inscriptos
			d. Indicar total de escuelas que al menos tienen un alumno inscripto (armar una lista de escuelas)
			e. Imprimir el listado de las escuelas, ordenado alfabéticamente, sin repeticiones. */
			
			ArrayList lista_alumnos = new ArrayList();
			
			bool salir = false;
			
			while (!salir) {
			Console.WriteLine("============ COMPETENCIA MATEMÁTICA ==================");
			Console.WriteLine("1 - Incribir alumno");
			Console.WriteLine("2 - Eliminar alumno");
			Console.WriteLine("3 - Ver total de alumnos inscriptos");
			Console.WriteLine("4 - Ver total de escuelas inscriptas");
			Console.WriteLine("5 - Ver escuelas");
			Console.WriteLine("0 - Salir ");
			Console.WriteLine("========================================================");
			
			string op = Console.ReadLine();
			
			switch(op){
				case "1": lista_alumnos = inscribir(lista_alumnos); break;
				case "2": lista_alumnos = borrar(lista_alumnos); Console.WriteLine("Alumno eliminado!"); break;
				case "3": Console.WriteLine("El total de alumnos es: {0}", totalAlumnos(lista_alumnos)); break;
				case "4": Console.WriteLine("El total de escuelas es: {0}", listaEscuelas(lista_alumnos).Count); break;
				case "5": Console.WriteLine("Lista de escuelas:"); imprimirLista(listaOrdenada(listaEscuelas(lista_alumnos))); break;
				
				case "0": Console.WriteLine("Hasta luego!"); salir = true; break;
				}
			}
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		// Funcion para inscribir alumno
		public static ArrayList inscribir(ArrayList lista){
			Console.Write("Ingrese el DNI( '0' para terminar): ");
			string dni = Console.ReadLine();
			while (dni != "0") {
				Console.Write("Ingrese el nombre de la escuela: ");
				string escuela = Console.ReadLine();
				Console.WriteLine("----------------------------------");
				escuela = escuela.ToUpper();
				
				ArrayList dato = new ArrayList();
				dato.Add(dni);
				dato.Add(escuela);
				
				lista.Add(dato);
				
				Console.Write("Ingrese el DNI: ");
				dni = Console.ReadLine();
			}
			
			return lista;
		}
		
		// Funcion para borrar alumno
		public static ArrayList borrar(ArrayList lista){
			Console.Write("Ingrese el DNI del alumno a borrar: ");
			string dni = Console.ReadLine();
			
			for(int j = 0; j < lista.Count; j++){
				foreach(string i in (ArrayList)lista[ j ]){
					if (dni == i){
						lista.RemoveAt( j );
						break;
					}
				}

			}
			return lista;
		}
		
		//Funcion para ver el total de alumnos
		public static int totalAlumnos(ArrayList lista){
			int total = lista.Count;
			return total;
		}
		
		//Funcion para crear la lista de escuelas
		public static ArrayList listaEscuelas(ArrayList lista){
			ArrayList listaEsc = new ArrayList();
			
			foreach (ArrayList j in lista){
				string dato = (string)j[1];
				if (! listaEsc.Contains(dato)){
					listaEsc.Add(dato);
				}
			}
			return listaEsc;
		}
		
		//Funcion para ordenar alfabeticamente la lista
		public static ArrayList listaOrdenada(ArrayList lista){
			lista.Sort();
			return lista;
		}
		
		// Funciones para imprimir strings de un arraylist
		public static void imprimirLista(ArrayList lista){
			foreach (string i in lista){
				Console.WriteLine(i );
			}
		}
		
		public static void imprimirListaAlumnos(ArrayList lista){
			foreach (ArrayList j in lista){
				Console.WriteLine("DNI y escuela:");
				for (int i = 0; i < j.Count; i++){
				Console.WriteLine(j[i]);
				}
			}
		}
	}
}