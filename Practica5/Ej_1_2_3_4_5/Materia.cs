/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 21/9/2022
 * Time: 9:08 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Ej_1_2_3_4_5
{
	// 4) Implemente la clase Materia que permita asociarle el profesor y la lista de los alumnos inscriptos en ella.
	
	/// <summary>
	/// Description of Materia.
	/// </summary>
	public class Materia
	{
		// Atributos
		string nombreMateria;
		Profesor profe;
		ArrayList listaAlumnos;
		
		// Constructores
		public Materia()
		{
		}
		public Materia(string nombre, Profesor profe, ArrayList listaAlumnos)
		{
			this.nombreMateria = nombre;
			this.profe = profe;
			this.listaAlumnos = listaAlumnos;
		}
		
		// Propiedades
		public string NombreMateria
		{
			set {nombreMateria = value;}
			get {return nombreMateria;}
		}
		public Profesor Profe
		{
			set {profe = value;}
			get {return profe;}
		}
		public ArrayList ListaAlumnos
		{
			set {listaAlumnos = value;}
			get {return listaAlumnos;}
		}
	}
}
