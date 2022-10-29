/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 11/10/2022
 * Time: 9:18 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Proyecto2022
{
	/// <summary>
	/// Description of Medico.
	/// </summary>
	public class Medico
	{
		// Atributos o estados
		private ArrayList pacientes;
		private ArrayList turnos;
		
		// Constructor por defecto
		public Medico()
		{
			pacientes  = new ArrayList();
			turnos  = new ArrayList();
		}
		
		// Propiedades getters y setters
		public ArrayList GetPacientes()
		{
			return pacientes;
		}
		public ArrayList GetTurnos()
		{
			return turnos;
		}
		
		// Metodos
		
		// PACIENTES
		public void agregarPaciente(Paciente pn)
		{
			pacientes.Add(pn);
		}
		public void eliminarPaciente(Paciente pn)
		{
			pacientes.Remove(pn);
		}
		public int cantidadPacientes()
		{
			return pacientes.Count;
		}
		public bool existePaciente(Paciente pn)
		{
			return pacientes.Contains(pn);
		}
		public Paciente verPaciente(int pos)
		{
			return (Paciente) pacientes[pos];
		}
		
		// TURNOS
		public void agregarTurno(Turno turnoNuevo)
		{
			turnos.Add(turnoNuevo);
		}
		public void eliminarTurno(Turno tn)
		{
			turnos.Remove(tn);
		}
		public int cantidadTurnos()
		{
			return turnos.Count;
		}
		public bool existeTurno(Turno tn)
		{
			return turnos.Contains(tn);
		}
		public Turno verTurno(int pos)
		{
			return (Turno) turnos[pos];
		}
	}
}
