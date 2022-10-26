/*
 * Created by SharpDevelop.
 * User: Santiago
 * Date: 11/10/2022
 * Time: 4:51 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Proyecto2022
{
	class Program
	{
		public static void Main(string[] args)
		{
			Medico consultorioMedico = new Medico();
			
			bool salir = false;
			
			while (!salir) {
			Console.WriteLine("============ MENÚ ==================");
			Console.WriteLine("1 - Asignar turno");
			Console.WriteLine("2 - Actualizar el diagnóstico de un paciente");
			Console.WriteLine("3 - Cancelar un turno");
			Console.WriteLine("4 - Ver turnos asignados");
			Console.WriteLine("5 - Ver obras sociales de los pacientes");
			Console.WriteLine("6 - Agregar paciente");
			Console.WriteLine("7 - Eliminar paciente");
			Console.WriteLine("8 - Ver pacientes");
			Console.WriteLine("0 - Salir ");
			Console.WriteLine("========================================================");
			
			string op = Console.ReadLine();
			
			switch(op){
				case "1": darTurno(consultorioMedico); break;
				case "2": actualizarDiagnostico(consultorioMedico);break;
				case "3": eliminarTurno(consultorioMedico);break;
				case "4": verTurnos(consultorioMedico);break;
				case "5": verObras(consultorioMedico);break;
				case "6": agregarPaciente(consultorioMedico);break;
				case "7": eliminarPaciente(consultorioMedico);break;
				case "8": verPacientes(consultorioMedico);break;
				
				case "0": Console.WriteLine("Hasta luego!"); salir = true; break;
				}
			}
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		// Funcion para dar turno
		public static void darTurno(Medico medico1)
		{
			string nombre, hora;
			
			Console.WriteLine("Ingrese el nombre del paciente: ");
			nombre = Console.ReadLine();
			Console.WriteLine("Ingrese el horario del turno: ");
			hora = Console.ReadLine();
			
			Turno turno1 = new Turno(nombre, hora); // Creo el turno
			medico1.agregarTurno(turno1); // Agrego el turno
		}
		
		// Funcion para actualizar diagnostico de paciente
		public static void actualizarDiagnostico(Medico medico1)
		{
			// Declaro y asigno variables DNI y DIAGNOSTICO
			Console.WriteLine("Ingrese el DNI del paciente: ");
			int dni = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el nuevo diagnostico: ");
			string diagnostico = Console.ReadLine();
			
			
			ArrayList conjuntoPacientes;
			conjuntoPacientes = medico1.GetPacientes(); // Tomo la lista de pacientes de medico
			
			foreach (Paciente p in conjuntoPacientes)
			{
				if (p.GetDni() == dni)
				{
					p.SetDiagnostico(diagnostico);
				}
			}
			Console.WriteLine("El diagnostico se modificó con éxito.");
		}
		
		// Funcion para cancelar un turno dado
		public static void eliminarTurno(Medico medico1)
		{
			Console.WriteLine("Ingrese el horario del turno a eliminar: ");
			string hora = Console.ReadLine();
			
			bool existe = false;
			
			ArrayList conjuntoTurnos;
			conjuntoTurnos = medico1.GetTurnos(); // Tomo la lista de turnos de medico
			
			foreach (Turno t in conjuntoTurnos)
			{
				if (hora == t.GetHora())
				{
					existe = true;
					medico1.eliminarTurno(t);
					break;
				}
			}
			
			if (existe)
			{
				Console.WriteLine("El turno se eliminó con éxito.");
			}
		}
		
		// Funcion para listar los turnos dados
		public static void verTurnos(Medico medico1)
		{
			ArrayList conjuntoTurnos;
			conjuntoTurnos = medico1.GetTurnos(); // Tomo la lista de turnos de medico
			
			foreach (Turno t in conjuntoTurnos)
			{
				string nombre = t.GetNombrePaciente();
				string hora = t.GetHora();
				
				Console.WriteLine("Paciente: {0} Horario del turno: {1}", nombre, hora);
			}
		}
		
		// Funcion para listar las obras sociales que atiende el medico (sin repeticiones)
		public static void verObras(Medico medico1)
		{
			ArrayList obrasSociales = new ArrayList();
			
			ArrayList conjuntoPacientes;
			conjuntoPacientes = medico1.GetPacientes(); // Tomo la lista de pacientes de medico
			
			foreach (Paciente p in conjuntoPacientes)
			{
				string obra = p.GetObraSocial();
				bool existe = false;
				
				foreach (string obraSocial in obrasSociales)
				{
					if (obra == obraSocial)
					{
						existe = true;
						break;
					}
				}
				
				if  (!existe)
				{
					obrasSociales.Add(obra);
				}
			}
		}
		
		// Funcion para agregar paciente
		public static void agregarPaciente(Medico medico1)
		{
			string nombre;
			int dni;
			string obraSocial;
			int nroAfiliado;
			
			Console.WriteLine("Nombre del paciente: ");
			nombre = Console.ReadLine();
			Console.WriteLine("DNI: ");
			dni = int.Parse(Console.ReadLine());
			Console.WriteLine("Obra social: ");
			obraSocial = Console.ReadLine();
			Console.WriteLine("Nro de afiliado: ");
			nroAfiliado = int.Parse(Console.ReadLine());
			
			Paciente paciente1 = new Paciente(nombre, dni, obraSocial, nroAfiliado);
			
			medico1.agregarPaciente(paciente1);
			
		}
		
		// Funcion para eliminar paciente
		public static void eliminarPaciente(Medico medico1)
		{
			int dni;
			Console.WriteLine("Ingrese el DNI del paciente a borrar: ");
			dni = int.Parse(Console.ReadLine());
			
			ArrayList conjuntoPacientes;
			conjuntoPacientes = medico1.GetPacientes(); // Tomo la lista de pacientes de medico
			
			foreach (Paciente i in conjuntoPacientes)
			{
				if (dni == i.GetDni())
				{
					medico1.eliminarPaciente(i);
					break; // Break porque no tiene sentido seguir buscando, ya que no se repiten pacientes
				}
			}
		}
		
		// Funcion para listar pacientes
		public static void verPacientes(Medico medico1)
		{
			ArrayList conjuntoPacientes;
			conjuntoPacientes = medico1.GetPacientes(); // Tomo la lista de pacientes de medico
			
			foreach (Paciente p in conjuntoPacientes)
			{
				string nombre = p.GetNombre();
				int dni = p.GetDni();
				string obraSocial = p.GetObraSocial();
				int nroAfiliado = p.GetNroAfiliado();
				string diagnostico = p.GetDiagnostico();
				
				Console.WriteLine("Paciente: {0}\nDNI: {1}\nObra social: {2}\nNro de afiliado: {3}\nDiagnostico: {4}\n", nombre, dni, obraSocial, nroAfiliado, diagnostico);
			}
		}
	}
}