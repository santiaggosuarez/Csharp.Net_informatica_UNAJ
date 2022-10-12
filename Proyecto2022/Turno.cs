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
		private ArrayList horariosTurnos;
		
		// Constructor por defecto
		public Turno()
		{
		}
		
		// Constructor con parámetros
		public Turno(string nombrePaciente, string hora)
		{
			this.nombrePaciente = nombrePaciente;
			this.hora = hora;
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
		public void SetNombrePaciente(string nombreNuevo)
		{
			nombrePaciente = nombreNuevo;
		}
		public void SetHora(string horaNueva)
		{
			hora = horaNueva;
		}
		public ArrayList GetHorariosTurnos()
		{
			return horariosTurnos;
		}
		
		// Metodos
		public void agregarTurno(Turno ht)
		{
			horariosTurnos.Add(ht);
		}
		public void eliminarTurno(Turno ht)
		{
			horariosTurnos.Remove(ht);
		}
		public int cantidadTurnos()
		{
			return horariosTurnos.Count;
		}
		public bool existeTurno(Turno ht)
		{
			return horariosTurnos.Contains(ht);
		}
		public Turno recuperarElemento(int pos)
		{
			return horariosTurnos[pos];
		}
	}
}
