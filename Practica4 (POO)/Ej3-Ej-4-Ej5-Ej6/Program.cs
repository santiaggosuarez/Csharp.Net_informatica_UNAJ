/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 13/9/2022
 * Time: 9:22 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej3_Ej_4_Ej5_Ej6
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*
  			    3) Defina una clase Persona con 3 campos: Nombre, Edad y DNI. En el constructor utilice parámetros
				cuyos nombres coincidan con los campos privados del objeto (usar this). Definir un método que permita
				imprimir los datos de la persona con el siguiente formato:
				Nombre (Edad) <TAB> DNI.
				Ejemplo: Juan Perez (40) 2098745 */
				
			Console.WriteLine("\n=====================EJ 3==============================\n ");
		
			Persona yo = new Persona("Santiago", 25, 40856658);
			yo.imprimir();
				
		      /*    4) Escriba un programa de aplicación (Main) que permita al usuario crear varias personas y guardarlas
				en un ArrayList. Una vez finalizada la entrada de datos, el programa debe imprimir en la consola el listado
				de datos de dichas personas usando el método imprimir, respetando el siguiente formato:
				Nro. orden) Nombre (Edad) <TAB> DNI.
				Ejemplo:
				1) Juan Perez (40) 2098745
				2) José García (41) 1965412
				...

			   5)  Modifique el programa anterior agregando un campo privado FechaNacimiento. Defina un nuevo
				constructor que reciba como parámetro el nombre, la fecha de nacimiento (un DateTime) y el dni. En base a
				la fecha de nacimiento y la fecha actual debe calcular y guardar la edad. Utilice ambos constructores para
				resolver el ejercicio anterior, permitiendo ahora que el usuario tipee las entradas como:
				"Nombre<TAB>Documento<TAB>Edad<ENTER>" o  "Nombre<TAB>Documento<TAB>fecha de nacimiento<ENTER>".
			 */
			
			Console.WriteLine("\n===================EJ 4 y EJ 5=========================\n ");
			
			ArrayList listaPersonas = new ArrayList();
			bool salir = false;
			
			Console.WriteLine("Ingrese nombre de pila, DNI y edad o fecha de nacimiento (DD/MM/AAAA): ");
			string datos = Console.ReadLine();
			
			if (datos == ""){salir = true;}
			while (!salir) {
				
				listaPersonas.Add(datos);
				
				//Console.WriteLine("Ingrese nombre de pila, DNI y edad o fecha de nacimiento: ");
				datos = Console.ReadLine();
				if (datos == ""){salir = true;}
			}
			
			int cont = 1;
			foreach(string i in listaPersonas){
				string[] datosDiv = i.Split(' ');
				
				string nombre = datosDiv[0];
				int dni = int.Parse(datosDiv[1]);
				string edad = datosDiv[2];
				
				if (edad.Length < 3)
					{
					// Llamada a la funcion si el dato ingresado es una edad
					int edadInt = int.Parse(edad);
					Persona p = new Persona(nombre, edadInt, dni);
					
					Console.WriteLine("{0}) {1} ({2}) {3}", cont, p.getNombre(), p.getEdad(), p.getDNI());
					//Console.Write(cont + ") ");
					//p.imprimir();
					cont++;
					}
				else
					{
					// Llamada a la funcion si el dato ingresado es un DateTime
					DateTime fechaNac = new DateTime();
					fechaNac = DateTime.Parse(edad);
					Persona p = new Persona(nombre, fechaNac, dni);
					
					Console.WriteLine("{0}) {1} ({2}) {3}", cont, p.getNombre(), p.getEdad(), p.getDNI());
					//Console.Write(cont + ") ");
					//p.imprimir();
					cont++;
					}	
				}
			
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	class Persona
	{
		
		public Persona() {
			
		}
		
		public Persona(string nombre, int edad, int DNI){
			this.nombre = nombre;
			this.edad = edad;
			this.DNI = DNI;
		}
		
		public Persona(string nombre, DateTime fechaNac, int DNI){
			this.nombre = nombre;
			this.DNI = DNI;
			edad = calcularEdad(fechaNac);
		}
		
		private string nombre;
		private int edad;
		private int DNI;
		private DateTime fechaNacimiento;
		
		public void imprimir(){
			Console.WriteLine("{0} ({1}) \t {2}", nombre, edad, DNI);
		}
		
		public string getNombre(){
			return nombre;
		}
		public int getEdad(){
			return edad;
		}
		public void setEdad(int edad){
			this.edad = edad;
		}
		public int getDNI(){
			return DNI;
		}
		int calcularEdad(DateTime fechaNacimiento){
			
			int anio = DateTime.Now.Year - fechaNacimiento.Year;
			int mes = DateTime.Now.Month - fechaNacimiento.Month;
			int dia = DateTime.Now.Day - fechaNacimiento.Day;
			
			if(mes < 0)
				{ return anio - 1; }
			
			else if (mes == 0 && dia <= 0)
				{ return  anio -1; }
			
			else if (mes == 0 && dia > 0)
				{ return  anio; }
			
			else
				{ return anio; }
		}
		
	}
}