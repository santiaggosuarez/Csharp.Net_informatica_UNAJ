/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 20/9/2022
 * Time: 8:12 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Ej_1_2_3_4_5
{
	/*2) Implemente la clase Alumno para modelar alumnos en una Universidad. Agréguele como estado lo que
		considere necesario para el problema. Piense como implementaría los horarios de cursada de un alumno?
		(debe usar la clase del ejercicio anterior)
		Como comportamiento Implemente el método inscripcionACursada(string dia, string hora, string
		materia) que agrega a los horarios del alumno la materia en ese día y hora, si es que tiene libre el
		horario.
		*/
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno
	{
		// Atributos
		private string nombre, apellido;
		private int dni, legajo;
		private ArrayList listaHorarios;
		
		// Constructores
		public Alumno()
		{
		}
		public Alumno(string nombre, string apellido, int dni, int legajo)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.dni = dni;
			this.legajo = legajo;
			
			// Se crea lista de horarios vacia para que se vaya llenando a medida que el alumno se inscribe en materias.
			listaHorarios = new ArrayList();
		}
		
		// Propiedades
		public string Nombre
		{
			set{nombre = value;}
			get{return nombre;}
		}
		public string Apellido
		{
			set{apellido= value;}
			get{return apellido;}
		}
		public int Dni
		{
			set{dni = value;}
			get{return dni;}
		}
		public int Legajo
		{
			set{legajo = value;}
			get{return legajo;}
		}
		public ArrayList ListaHorarios
		{
			get{return listaHorarios;}
		}
		
		// Metodos
		
		// Metodo para inscribir a cursada
		public void inscripcionACursada(string dia, string hora, string materia)
		{
			// Chequeo que el horario no este ocupado
			bool ocupado = false;
			foreach (Horario i in listaHorarios)
			{
				if (i.Dia == dia && i.Hora == hora)
				{
					ocupado = true;
					break;
				}
			}
			
			// Si no esta ocupado se agrega el horario a la listaHorarios
			if (!ocupado)
			{
				Horario h = new Horario(dia,hora,materia);
				listaHorarios.Add(h);
			}
			// Si esta ocupado se avisa por mensaje en consola
			else
			{
				Console.WriteLine("{0} {1} ¡Horario ocupado!", dia, hora);
				Console.ReadKey(true);
			}
		}
	}
}
