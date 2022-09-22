/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 21/9/2022
 * Time: 7:29 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Ej_1_2_3_4_5
{
	/*5) Utilizando las clases definidas en los ejercicios anteriores implemente la clase Universidad que tiene
		su conjunto de profesores, un conjunto de materias y un conjunto de alumnos. Entre su
		funcionalidad debe permitar:
		a) La inscripción de alumnos a materias
		b) La asignación de profesores a las materias
		c) Listar el profesor y los alumnos de una determinada materia
		*/
		
	/// <summary>
	/// Description of Universidad.
	/// </summary>
	public class Universidad
	{
		// Atributos
		ArrayList profesores, alumnos, materias;
		
		// Constructores
		public Universidad()
		{
			profesores = new ArrayList();
			alumnos = new ArrayList();
			materias = new ArrayList();;
		}
		
		// Propiedades
		public ArrayList Profesores
		{
			get {return profesores;}
		}
		public ArrayList Alumnos
		{
			get {return alumnos;}
		}
		public ArrayList Materias
		{
			get {return materias;}
		}
	}
}
