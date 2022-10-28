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
			Turno turno1 = new Turno("","08:00",false);
			consultorioMedico.agregarTurno(turno1);
			Turno turno2 = new Turno("","08:30",false);
			consultorioMedico.agregarTurno(turno2);
			Turno turno3 = new Turno("","09:00",false);
			consultorioMedico.agregarTurno(turno3);
			Turno turno4 = new Turno("","09:30",false);
			consultorioMedico.agregarTurno(turno4);
			Turno turno5 = new Turno("","10:00",false);
			consultorioMedico.agregarTurno(turno5);
			Turno turno6 = new Turno("","10:30",false);
			consultorioMedico.agregarTurno(turno6);
			Turno turno7 = new Turno("","11:00",false);
			consultorioMedico.agregarTurno(turno7);
			Turno turno8 = new Turno("","11:30",false);
			consultorioMedico.agregarTurno(turno8);
			Turno turno9 = new Turno("","12:00",false);
			consultorioMedico.agregarTurno(turno9);
			
			bool salir = false;
			
			while (!salir) {
			Console.WriteLine("====================== MENÚ ======================");
			Console.WriteLine("1 - Asignar turno");
			Console.WriteLine("2 - Actualizar el diagnóstico de un paciente");
			Console.WriteLine("3 - Cancelar un turno");
			Console.WriteLine("4 - Ver turnos asignados");
			Console.WriteLine("5 - Ver obras sociales de los pacientes");
			Console.WriteLine("6 - Agregar paciente");
			Console.WriteLine("7 - Eliminar paciente");
			Console.WriteLine("8 - Ver pacientes");
			Console.WriteLine("0 - Salir ");
			string opcion = Console.ReadLine();
			Console.WriteLine("================================================== ");
			
			switch(opcion){
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
			bool hayDisponibles = false;
			
			ArrayList conjuntoTurnos;
			conjuntoTurnos = medico1.GetTurnos(); // Tomo la lista de turnos de medico
			
			foreach(Turno turno in conjuntoTurnos)
			{
				// Recorro los turnos y si alguno NO está asignado, entonces hayDisponibles es TRUE
				if (!turno.GetAsignado())
				{
					hayDisponibles = true;
				}
			}
			
			// Si hay turnos disponibles brindo la opción de elegir alguno
			if (hayDisponibles)
			{			
				Console.Write("Ingrese el nombre y apellido del paciente: ");
				string nombre = Console.ReadLine().ToUpper();
				
				// Variable para controlar que el usuario pueda volver a elegir turno en caso de seleccionar uno no disponible
				bool turnoAsignado = false;
				while (!turnoAsignado)
				{
					Console.WriteLine("\nSeleccione una opción: ");
					Console.WriteLine("1) 08:00 hs.");
					Console.WriteLine("2) 08:30 hs.");
					Console.WriteLine("3) 09:00 hs.");
					Console.WriteLine("4) 09:30 hs.");
					Console.WriteLine("5) 10:00 hs.");
					Console.WriteLine("6) 10:30 hs.");
					Console.WriteLine("7) 11:00 hs.");
					Console.WriteLine("8) 11:30 hs.");
					Console.WriteLine("9) 12:00 hs.");
					Console.WriteLine("0) Atrás.");
					
					string opcion = Console.ReadLine();
					
					switch(opcion){
						case "1": 
							// Si el turno en la posición elegida NO está ocupado, se lo da al paciente y pasa a figurar como asignado
							if (!medico1.verTurno(0).GetAsignado())
							{
								medico1.verTurno(0).SetNombrePaciente(nombre);
								medico1.verTurno(0).SetAsignado(true);
								// Cierro el bucle
								turnoAsignado = true;
								
								Console.WriteLine("\nSe le asignó a {0} el turno de las {1} hs.", nombre, medico1.verTurno(0).GetHora());
							}
							// Sino, avisa por consola que está ocupado
							else
							{
								Console.WriteLine("\nTurno ocupado, por favor seleccione otro.");
							};
							break;
						case "2":
							// Si el turno en la posición elegida NO está ocupado, se lo da al paciente y pasa a figurar como asignado
							if (!medico1.verTurno(1).GetAsignado())
							{
								medico1.verTurno(1).SetNombrePaciente(nombre);
								medico1.verTurno(1).SetAsignado(true);
								// Cierro el bucle
								turnoAsignado = true;
								
								Console.WriteLine("\nSe le asignó a {0} el turno de las {1} hs.", nombre, medico1.verTurno(1).GetHora());
							}
							// Sino, avisa por consola que está ocupado
							else
							{
								Console.WriteLine("\nTurno ocupado, por favor seleccione otro.");
								// Cierro el bucle
								turnoAsignado = true;
							};
							break;
						case "3":
							// Si el turno en la posición elegida NO está ocupado, se lo da al paciente y pasa a figurar como asignado
							if (!medico1.verTurno(2).GetAsignado())
							{
								medico1.verTurno(2).SetNombrePaciente(nombre);
								medico1.verTurno(2).SetAsignado(true);
								// Cierro el bucle
								turnoAsignado = true;
								
								Console.WriteLine("\nSe le asignó a {0} el turno de las {1} hs.", nombre, medico1.verTurno(2).GetHora());
							}
							// Sino, avisa por consola que está ocupado
							else
							{
								Console.WriteLine("\nTurno ocupado, por favor seleccione otro.");
							};
							break;
						case "4":
							// Si el turno en la posición elegida NO está ocupado, se lo da al paciente y pasa a figurar como asignado
							if (!medico1.verTurno(3).GetAsignado())
							{
								medico1.verTurno(3).SetNombrePaciente(nombre);
								medico1.verTurno(3).SetAsignado(true);
								// Cierro el bucle
								turnoAsignado = true;
								
								Console.WriteLine("\nSe le asignó a {0} el turno de las {1} hs.", nombre, medico1.verTurno(3).GetHora());
							}
							// Sino, avisa por consola que está ocupado
							else
							{
								Console.WriteLine("\nTurno ocupado, por favor seleccione otro.");
							};
							break;
						case "5":
							// Si el turno en la posición elegida NO está ocupado, se lo da al paciente y pasa a figurar como asignado
							if (!medico1.verTurno(4).GetAsignado())
							{
								medico1.verTurno(4).SetNombrePaciente(nombre);
								medico1.verTurno(4).SetAsignado(true);
								// Cierro el bucle
								turnoAsignado = true;
								
								Console.WriteLine("\nSe le asignó a {0} el turno de las {1} hs.", nombre, medico1.verTurno(4).GetHora());
							}
							// Sino, avisa por consola que está ocupado
							else
							{
								Console.WriteLine("\nTurno ocupado, por favor seleccione otro.");
							};
							break;
						case "6":
							// Si el turno en la posición elegida NO está ocupado, se lo da al paciente y pasa a figurar como asignado
							if (!medico1.verTurno(5).GetAsignado())
							{
								medico1.verTurno(5).SetNombrePaciente(nombre);
								medico1.verTurno(5).SetAsignado(true);
								// Cierro el bucle
								turnoAsignado = true;
								
								Console.WriteLine("\nSe le asignó a {0} el turno de las {1} hs.", nombre, medico1.verTurno(5).GetHora());
							}
							// Sino, avisa por consola que está ocupado
							else
							{
								Console.WriteLine("\nTurno ocupado, por favor seleccione otro.");
							};
							break;
						case "7":
							// Si el turno en la posición elegida NO está ocupado, se lo da al paciente y pasa a figurar como asignado
							if (!medico1.verTurno(6).GetAsignado())
							{
								medico1.verTurno(6).SetNombrePaciente(nombre);
								medico1.verTurno(6).SetAsignado(true);
								// Cierro el bucle
								turnoAsignado = true;
								
								Console.WriteLine("\nSe le asignó a {0} el turno de las {1} hs.", nombre, medico1.verTurno(6).GetHora());
							}
							// Sino, avisa por consola que está ocupado
							else
							{
								Console.WriteLine("\nTurno ocupado, por favor seleccione otro.");
							};
							break;
						case "8":
							// Si el turno en la posición elegida NO está ocupado, se lo da al paciente y pasa a figurar como asignado
							if (!medico1.verTurno(7).GetAsignado())
							{
								medico1.verTurno(7).SetNombrePaciente(nombre);
								medico1.verTurno(7).SetAsignado(true);
								// Cierro el bucle
								turnoAsignado = true;
								
								Console.WriteLine("\nSe le asignó a {0} el turno de las {1} hs.", nombre, medico1.verTurno(7).GetHora());
							}
							// Sino, avisa por consola que está ocupado
							else
							{
								Console.WriteLine("\nTurno ocupado, por favor seleccione otro.");
							};
							break;
						case "9":
							// Si el turno en la posición elegida NO está ocupado, se lo da al paciente y pasa a figurar como asignado
							if (!medico1.verTurno(8).GetAsignado())
							{
								medico1.verTurno(8).SetNombrePaciente(nombre);
								medico1.verTurno(8).SetAsignado(true);
								// Cierro el bucle
								turnoAsignado = true;
								
								Console.WriteLine("\nSe le asignó a {0} el turno de las {1} hs.", nombre, medico1.verTurno(8).GetHora());
							}
							// Sino, avisa por consola que está ocupado
							else
							{
								Console.WriteLine("\nTurno ocupado, por favor seleccione otro.");
							};
							break;
						case "0":
							// Cierro el bucle
							turnoAsignado = true;
							break;
						}
					}
			}
			// De no haber turnos disponibles se envía el siguiente mensaje
			else { Console.WriteLine("Horarios no disponibles, llamar próximo día de atención."); }
			// Turno turno1 = new Turno(nombre, hora); // Creo el turno
			// medico1.agregarTurno(turno1); // Agrego el turno
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
					Console.WriteLine("\nEl diagnostico de {0} (DNI {1}) se modificó con éxito.", p.GetNombre(), dni);
				}
			}
		}
		
		// Funcion para cancelar turno
		public static void eliminarTurno(Medico medico1)
		{
			Console.WriteLine("Seleccione el turno a cancelar: ");
			Console.WriteLine("1) 08:00 hs.");
			Console.WriteLine("2) 08:30 hs.");
			Console.WriteLine("3) 09:00 hs.");
			Console.WriteLine("4) 09:30 hs.");
			Console.WriteLine("5) 10:00 hs.");
			Console.WriteLine("6) 10:30 hs.");
			Console.WriteLine("7) 11:00 hs.");
			Console.WriteLine("8) 11:30 hs.");
			Console.WriteLine("9) 12:00 hs.");
			
			string opcion = Console.ReadLine();
			
			switch(opcion){
				case "1": medico1.verTurno(0).SetNombrePaciente(""); medico1.verTurno(0).SetAsignado(false); break;
				case "2": medico1.verTurno(1).SetNombrePaciente(""); medico1.verTurno(1).SetAsignado(false);break;
				case "3": medico1.verTurno(2).SetNombrePaciente(""); medico1.verTurno(2).SetAsignado(false);break;
				case "4": medico1.verTurno(3).SetNombrePaciente(""); medico1.verTurno(3).SetAsignado(false);break;
				case "5": medico1.verTurno(4).SetNombrePaciente(""); medico1.verTurno(4).SetAsignado(false);break;
				case "6": medico1.verTurno(5).SetNombrePaciente(""); medico1.verTurno(5).SetAsignado(false);break;
				case "7": medico1.verTurno(6).SetNombrePaciente(""); medico1.verTurno(6).SetAsignado(false);break;
				case "8": medico1.verTurno(7).SetNombrePaciente(""); medico1.verTurno(7).SetAsignado(false);break;
				}
			
		}
		
		// Funcion para listar los turnos dados
		public static void verTurnos(Medico medico1)
		{
			ArrayList conjuntoTurnos;
			conjuntoTurnos = medico1.GetTurnos(); // Tomo la lista de turnos de medico
			
			foreach (Turno turno in conjuntoTurnos)
			{
				if (turno.GetAsignado())
				{
					string nombre = turno.GetNombrePaciente();
					string hora = turno.GetHora();
					Console.WriteLine("Paciente: {0}\nTurno: {1} hs.\n", nombre, hora);
				}
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
				string obraSocial = p.GetObraSocial();
				bool existe = false;
				
				foreach (string o in obrasSociales)
				{
					if (obraSocial == o)
					{
						existe = true;
						break;
					}
				}
				
				if  (!existe)
				{
					obrasSociales.Add(obraSocial);
				}
			}
			
			// Recorro e imprimo las obras sociales en orden alfabetico
			obrasSociales.Sort();
			Console.WriteLine("Las obras sociales que atiende el médico son las siguientes: \n");
			foreach (string os in obrasSociales)
			{
				Console.WriteLine(os);
			}
		}
		
		// Funcion para agregar paciente
		public static void agregarPaciente(Medico medico1)
		{
			string nombre;
			int dni;
			string obraSocial;
			int nroAfiliado;
			
			Console.Write("Nombre y apellido del paciente: ");
			nombre = Console.ReadLine().ToUpper();
			Console.Write("DNI: ");
			dni = int.Parse(Console.ReadLine());
			Console.Write("Obra social (“particular” si no posee): ");
			obraSocial = Console.ReadLine().ToUpper();
			Console.Write("Nro de afiliado (0 si no posee obra social): ");
			nroAfiliado = int.Parse(Console.ReadLine());
			
			Paciente paciente1 = new Paciente(nombre, dni, obraSocial, nroAfiliado);
			
			medico1.agregarPaciente(paciente1);
			
			Console.WriteLine("{0} agregado/a a la lista de pacientes con éxito.", nombre);
			
		}
		
		// Funcion para eliminar paciente
		public static void eliminarPaciente(Medico medico1)
		{
			int dni;
			bool existe = false;
			Console.Write("Ingrese el DNI del paciente a borrar: ");
			dni = int.Parse(Console.ReadLine());
			
			ArrayList conjuntoPacientes;
			conjuntoPacientes = medico1.GetPacientes(); // Tomo la lista de pacientes de medico
			
			foreach (Paciente i in conjuntoPacientes)
			{
				if (dni == i.GetDni())
				{
					medico1.eliminarPaciente(i);
					Console.WriteLine("\n{0} (DNI {1}) ha sido eliminado/a con éxito.", i.GetNombre(), i.GetDni());
					existe = true;
					break; // Break porque no tiene sentido seguir buscando, ya que no se repiten pacientes
				}
			}
			
			if (!existe) { Console.WriteLine("\nNo existe un/a paciente con el DNI indicado."); }
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