/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 13/9/2022
 * Time: 9:22 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

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
			
			ArrayList listaPersonas1 = CrearListaPersonas();
			ImprimirPersonas(listaPersonas1);
			
			/* 6) Agregue a la clase Persona un método esMayorQue(Persona p) que devuelva verdadero si la persona que
				recibe el mensaje es más grande que la persona recibida como parámetro. Utilícelo para realizar un
				programa de aplicación (Main) que al recibir la lista de personas del ejercicio anterior retorne la persona
				de mayor edad del grupo.*/
			
			Console.WriteLine("\n=====================EJ 6==============================\n ");
			
			Persona persona1 = new Persona("Isabel II", 96, 12334455);
			Persona persona2 = new Persona("Santiago", 25, 40856658);
			Console.WriteLine("¿{0} es mayor que {1}? {2}", persona1.getNombre(), persona2.getNombre(), persona1.esMayorQue(persona2) );
			
			Persona pMayor = new Persona();
			pMayor = MayorPersona(listaPersonas1);
			Console.Write("La persona mayor de la lista es: ");
			pMayor.imprimir();
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		// Funcion para crear la lista de personas pedida en los puntos 4 y 5
		public static ArrayList CrearListaPersonas(){
			ArrayList listaPersonas = new ArrayList();
			Persona p = new Persona();
			bool salir = false;
			
			Console.WriteLine("Ingrese nombre de pila, DNI y edad o fecha de nacimiento (DD/MM/AAAA): \t (ENTER vacío para finalizar)");
			string datos = Console.ReadLine();
			
			if (datos == ""){salir = true;}
			while (!salir) {
				
				string[] datosDiv = datos.Split(' ');
				
				string nombre = datosDiv[0];
				int dni = int.Parse(datosDiv[1]);
				string edad = datosDiv[2];
				
				// Chequeo si uno de los datos ingresados es una edad o una fecha de nacimiento
				int edadInt;
				bool esNum = int.TryParse(edad, out edadInt);
				if ( esNum )
					{
					p = new Persona(nombre, edadInt, dni);
					}
				else
					{
					DateTime fechaNac = new DateTime();
					fechaNac = DateTime.Parse(edad);
					p = new Persona(nombre, fechaNac, dni);
					}
				
				listaPersonas.Add(p);
				
				//Console.WriteLine("Ingrese nombre de pila, DNI y edad o fecha de nacimiento: ");
				datos = Console.ReadLine();
				if (datos == ""){salir = true;}
			}
			return listaPersonas;
		}
		
		// Funcion para imprimir la lista de personas pedida en el punto 4
		public static void ImprimirPersonas(ArrayList lista){
			int cont = 1;
			foreach(Persona i in lista){
				
				Console.WriteLine("{0}) {1} ({2}) {3}", cont, i.getNombre(), i.getEdad(), i.getDNI());
				//Console.Write(cont + ") ");
				//p.imprimir();
				cont++;
			}
		}
		
		// Funcion para retornar la persona mayor de una lista pedida en el punto 6
		public static Persona MayorPersona(ArrayList lista){
			
			Persona personaMayor =  new Persona();
			
			foreach(Persona i in lista){
				
				if ( i.esMayorQue(personaMayor) ) {
					personaMayor = i;
					}
				}
			return personaMayor;
		}
		
	}
	
	class Persona
	{
		// Atributos o propiedades
		private string nombre;
		private int edad;
		private int DNI;
		private DateTime fechaNacimiento;
		
		// Constructor por defecto
		public Persona() { }
		
		// Constructor con edad int
		public Persona(string nombre, int edad, int DNI){
			this.nombre = nombre;
			this.edad = edad;
			this.DNI = DNI;
		}
		
		// Constructor con edad DateTime
		public Persona(string nombre, DateTime fechaNac, int DNI){
			this.nombre = nombre;
			this.DNI = DNI;
			edad = calcularEdad(fechaNac);
			fechaNacimiento = fechaNac;
		}
		
		// Metodo para imprimir los datos de una persona
		public void imprimir(){
			Console.WriteLine("{0} ({1}) \t {2}", nombre, edad, DNI);
		}
		
		// Metodos getters y setters
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
		
		// Metodo para retornar si una persona es mayor que otra dada por parametro
		public bool esMayorQue(Persona p){
			
			int edad1 = this.getEdad();
			int edad2 = p.getEdad();
			
			if ( edad1 > edad2 )
				{ return true; }
			
			else
				{ return false; }
		}
		
		// Metodo para calcular la edad de una persona a partir de su DateTime fecha de nacimiento
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