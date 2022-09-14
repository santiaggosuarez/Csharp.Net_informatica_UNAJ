/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 12/9/2022
 * Time: 11:09 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej1_Ej2
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*1) Codifique la clase Hora de tal forma que al ejecutar el siguiente programa de aplicación (Main):
					class Program
					{
					public static void Main(string[] args)
					{
					Hora h=new Hora(23,30,15);
					h.imprimir();
					Console.ReadKey(true);
					}
					}
					se imprima por consola: 23 HORAS, 30 MINUTOS Y 15 SEGUNDOS*/
			
			/* 2) Agregue un segundo constructor a la clase Hora para que pueda recibir la hora en un solo parámetro de clase string.
 * 				Así el siguiente código:
					
					Hora h1=new Hora(23,30,15);
					Hora h2=new Hora("14:25:47");
					h1.imprimir();
					h2.imprimir();
					Console.ReadKey(true);
					
				produce la siguiente salida por consola:
					23 HORAS, 30 MINUTOS Y 15 SEGUNDOS
					14 HORAS, 25 MINUTOS Y 47 SEGUNDOS*/
			
			Hora h1=new Hora(23,30,15);
			Hora h2=new Hora("14:25:47");
			h1.imprimir();
			h2.imprimir();
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	class Hora
	{	
		// Constructor por defecto
		public Hora(){ }
		
		// Constructor con los parametros enteros
		public Hora(int horas,int minutos,int seg){
			
			// Se usa 'this.' para diferenciar la propiedad (horas) del parametro (horas), ya que tienen el mismo nombre
			this.horas = horas;
			// Se usa 'this.' para diferenciar la propiedad (minutos) del parametro (minutos), ya que tienen el mismo nombre
			this.minutos = minutos;
			// NO se usa 'this.' porque la propiedad (segundos) y el parametro (seg) tienen distintos nombres
			segundos = seg;
			
			// Chequeo que los datos ingresados tengan un rango valido, de lo contrario el valor sera '0'
			if (horas  > 23 || horas < 0){ horas = 0; }
			if (minutos  > 59 || minutos < 0){ minutos = 0; }
			if (segundos  > 59 || segundos < 0){ segundos = 0; }
			
		}
		
		// Constructor con los parametros string
		public Hora(string horario){
			
			// Divido el string en sub cadenas para acceder a los valores por medio de indices
			string[] horarioDiv = horario.Split(':');
			
			horas = int.Parse(horarioDiv[0]);
			minutos = int.Parse(horarioDiv[1]);
			segundos = int.Parse(horarioDiv[2]);
			
			// Chequeo que los datos ingresados tengan un rango valido, de lo contrario el valor sera '0'
			if (horas  > 23 || horas < 0){ horas = 0; }
			if (minutos  > 59 || minutos < 0){ minutos = 0; }
			if (segundos  > 59 || segundos < 0){ segundos = 0; }
			
		}
		
		// Atributos o propiedades
		private int horas;
		private int minutos;
		private int segundos;
		
		// Metodo imprimir
		public void imprimir(){
			Console.WriteLine("{0} HORAS, {1} MINUTOS Y {2} SEGUNDOS", horas, minutos, segundos);
		}
	}
}