/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 20/9/2022
 * Time: 8:59 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Ej_1_2_3_4_5
{
	/*3) Implemente la clase Profesor para modelar profesores en una Universidad. Agréguele como estado lo que
		considere necesario para el problema. Considere que un profesor conoce la lista de materias que dicta.
		Como comportamiento Implemente el método dictadoDeCurso(string materia) que le agrega esa materia
		nueva a la lista de materias que dicta.
	 */
	/// <summary>
	/// Description of Profesor.
	/// </summary>
	public class Profesor
	{
		// Atributos
		string nombre, apellido;
		ArrayList listaMaterias;
		
		// Constructores
		public Profesor()
		{
		}
		public Profesor(string nombre, string apellido, ArrayList lista)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			listaMaterias = lista;
		}
		
		// Propiedades
		public string Nombre
		{
			set {nombre = value;}
			get {return nombre;}
		}
		public string Apellido
		{
			set {apellido = value;}
			get {return apellido;}
		}
		public ArrayList ListaMaterias
		{
			get {return listaMaterias;}
		}
		
		// Metodos
		public void dictadoDeCurso(string materia)
		{
			bool existe = false;
			foreach (string i in listaMaterias)
			{
				if (i == materia) { existe = true; break; }
			}
			if (!existe)
			{
				listaMaterias.Add(materia);
			}
		}
	}
}
