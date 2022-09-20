/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 20/9/2022
 * Time: 8:04 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej_1_2_3_4_5
{
	/// <summary>
	/// Description of Horario.
	/// </summary>
	public class Horario
	{
		// Atributos
		private string dia, hora, materia;
		
		// Constructores
		public Horario()
		{
		}
		public Horario(string dia, string hora, string materia)
		{
			this.dia = dia;
			this.hora = hora;
			this.materia = materia;
		}
		
		// Propiedades
		public string Dia
		{
			set {dia = value;}
			get{return dia;}
		}
		public string Hora
		{
			set {hora = value;}
			get{return hora;}
		}
		public string Materia
		{
			set {materia = value;}
			get{return materia;}
		}
	}
}
