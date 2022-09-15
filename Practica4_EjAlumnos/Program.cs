/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 15/9/2022
 * Time: 8:44 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Practica4_EjAlumnos
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayList lista1;
			
			lista1 = CargarAlumnos();
			
			// Imprimo alumnos con promedio mayor a 8
			foreach(Alumno i in lista1)
			{
				if (i.GetPromedio() > 8)
				{
					i.imprimir();
				}
			}
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		// Funcion para cargar alumnos a una lista y retornar dicha lista
		public static ArrayList CargarAlumnos()
		{
			ArrayList listaAlumnos = new ArrayList();
			bool salir = false;
			
			Console.Write("Ingrese nombre (ENTER vacío para terminar): ");
			string nom = Console.ReadLine().ToUpper();
			if (nom == "") { salir = true; }
			
			while(!salir)
			{
				Console.Write("Apellido: ");
				string apellido = Console.ReadLine().ToUpper();
				
				Console.Write("DNI: ");
				int dni = int.Parse(Console.ReadLine());
				
				Console.Write("Legajo: ");
				int leg = int.Parse(Console.ReadLine());
				
				Console.Write("Promedio: ");
				double prom = double.Parse(Console.ReadLine());
				
				Alumno a = new Alumno(nom, apellido, dni, leg, prom);
				listaAlumnos.Add(a);
				
				Console.Write("Nombre: ");
				nom = Console.ReadLine().ToUpper();
				if (nom == "") { salir = true; }
			}
			return listaAlumnos;
		}
	}
	
	class Alumno
	{
		// Atributos o propiedades
		private string nombre;
		private string apellido;
		private int DNI;
		private int legajo;
		private double promedio;
		
		// Constructor por defecto
		public Alumno(){}
		
		// Constructor con parametros
		public Alumno(string nombre, string apellido, int dni, int legajo, double promedio)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.DNI = dni;
			this.legajo = legajo;
			
			if (promedio > 10 || promedio < 0)
			{
				this.promedio = 4;
			}
			else
			{
				this.promedio = promedio;
			}
		}
		
		// Metodos getters y setters
		public string GetNombre()
		{
			return nombre;
		}
		public string GetApellido()
		{
			return apellido;
		}
		public int GetDNI()
		{
			return DNI;
		}
		public int GetLegajo()
		{
			return legajo;
		}
		public double GetPromedio()
		{
			return promedio;
		}
		public void SetPromedio(double promedioNuevo)
		{
			this.promedio = promedioNuevo;
		}
		
		// Metodo para imprimir los datos
		public void imprimir()
		{
			Console.WriteLine(
				"Nombre: " + GetNombre() + "\n" +
				"Apellido: " + GetApellido() + "\n" +
				"DNI: " + GetDNI() + "\n" +
				"Legajo: " + GetLegajo() + "\n" +
				"Promedio: " + GetPromedio() + "\n"
			);
		}
	}
}