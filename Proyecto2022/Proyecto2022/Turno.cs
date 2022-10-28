/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 11/10/2022
 * Time: 8:32 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Proyecto2022
{
	/// <summary>
	/// Description of Turno.
	/// </summary>
	public class Turno
	{
		// Atributos o estados
		private string  nombrePaciente;
		private string hora;
		private bool asignado;
		
		// Constructor por defecto
		public Turno()
		{
		}
		
		// Constructor sin paciente
		public Turno(string hora)
		{
			this.hora = hora;
			this. asignado = false;
		}
		
		// Constructor con paciente
		public Turno(string nombrePaciente, string hora)
		{
			this.nombrePaciente = nombrePaciente;
			this.hora = hora;
			this. asignado = true;
		}
		
		// Propiedades getters y setters
		public string GetNombrePaciente()
		{
			return nombrePaciente;
		}
		public string GetHora()
		{
			return hora;
		}
		public bool GetAsignado()
		{
			return asignado;
		}
		public void SetNombrePaciente(string nombreNuevo)
		{
			nombrePaciente = nombreNuevo;
		}
		public void SetHora(string horaNueva)
		{
			hora = horaNueva;
		}
		public void SetAsignado(bool asignadoNuevo)
		{
			asignado = asignadoNuevo;
		}
	
	}
}
