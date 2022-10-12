/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 11/10/2022
 * Time: 4:53 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto2022
{
	/// <summary>
	/// Description of Paciente.
	/// </summary>
	public class Paciente
	{
		// Atributos o estados
		private string nombre;
		private int dni;
		private string obraSocial;
		private int nroAfiliado;
		private string diagnostico;
		
		// Constructor por defecto
		public Paciente()
		{
		}
		
		// Constructor con parámetros
		public Paciente(string nombre, int dni, string obraSocial, int nroAfiliado)
		{
			this.nombre = nombre;
			this.dni = dni;
			this.obraSocial = obraSocial;
			this.nroAfiliado = nroAfiliado;
			this. diagnostico = "";
		}
		
		// Propiedades getters y setters
		public string GetNombre()
		{
			return nombre;
		}
		public int GetDni()
		{
			return dni;
		}
		public string GetObraSocial()
		{
			return obraSocial;
		}
		public int GetNroAfiliado()
		{
			return nroAfiliado;
		}
		public string GetDiagnostico()
		{
			return diagnostico;
		}
		
		// Metodos
		
	}
}
