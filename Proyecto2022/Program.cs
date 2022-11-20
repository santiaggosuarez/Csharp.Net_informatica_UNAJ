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
			// Creo el consulorio médico y le agrego los turnos en los horarios disponibles (de 8 a 12 hs.).
			// Cada turno tiene un string vacio como nombre, ya que aún no se le asignó a ningún paciente.
			// Cada turno tiene un horario.
			// Cada turno se inicializa sin estar asignado (false).
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
			
			// Agrego pacientes para hacer pruebas
			Paciente paciente1 = new Paciente("Santiago Suárez",40856658,"PARTICULAR",0);
			consultorioMedico.agregarPaciente(paciente1);
			Paciente paciente2 = new Paciente("Belén Salinas",40766666,"OSDE",1244);
			consultorioMedico.agregarPaciente(paciente2);
			Paciente paciente3 = new Paciente("Jorge Pérez",1234,"GALENO",1010);
			consultorioMedico.agregarPaciente(paciente3);
			Paciente paciente4 = new Paciente("Micaela Herrera",10,"GALENO",9876);
			consultorioMedico.agregarPaciente(paciente4);
			
			// Variable booleana para controlar la salida del menú principal
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
				case "4": listarTurnos(consultorioMedico);break;
				case "5": verObras(consultorioMedico);break;
				case "6": agregarPaciente(consultorioMedico);break;
				case "7": eliminarPaciente(consultorioMedico);break;
				case "8": listarPacientes(consultorioMedico);break;
				
				case "0": Console.WriteLine("Hasta luego!"); salir = true; break;
				}
			}
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		// Funcion para imprimir lista de pacientes
		public static void imprimirPacientes(Medico medico1)
		{
			ArrayList conjuntoPacientes;
			conjuntoPacientes = medico1.GetPacientes(); // Tomo la lista de pacientes de medico
			
			for(int i = 0; i < conjuntoPacientes.Count; i++)
			{
				Paciente p = medico1.verPaciente(i);
				Console.WriteLine("{2}) {0} (DNI: {1})", p.GetNombre(), p.GetDni(), i+1);
			}
		}
		
		// Funcion para dar turno
		public static void darTurno(Medico medico1)
		{
			// Variable booleana para controlar si se quiere asignar turno
			bool salir = false;
			
			while (!salir)
			{
				// Variable booleana para controlar si hay turnos disponibles
				bool hayDisponibles = false;
				
				foreach(Turno turno in medico1.GetTurnos()) // Tomo los turnos de medico
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
					// Elijo el paciente de la lista de pacientes
					Console.WriteLine("Seleccione el paciente a asignar: ");
					imprimirPacientes(medico1);
					int opcionPaciente = int.Parse(Console.ReadLine());
					
					Paciente pacienteAsignar = medico1.verPaciente(opcionPaciente - 1);
					
					// Tomo la lista de turnos de medico
					ArrayList conjuntoTurnos = new ArrayList();
					conjuntoTurnos = medico1.GetTurnos();
					
					Console.WriteLine("\nSeleccione el horario: ");
					
					// Lista para guardar los turnos disponibles
					ArrayList turnosDisponibles = new ArrayList();
					
					// Int para numerar los turnos al imprimirlos
					int numeroTurno = 1;
					
					for(int i = 0; i < conjuntoTurnos.Count; i++)
					{
						// Si el turno no esta asignado lo muestro para que el usuario pueda elegirlo
						if ( ! medico1.verTurno(i).GetAsignado())
						{
							Turno turnoAsignar = medico1.verTurno(i);
							string horaTurno = turnoAsignar.GetHora();
							
							Console.WriteLine("{0}) {1}", numeroTurno, horaTurno);
							numeroTurno += 1;
							
							turnosDisponibles.Add(turnoAsignar);
						}
					}
					Console.WriteLine("0) Atrás.");
					int opcion = int.Parse(Console.ReadLine());
					
					if (opcion == 0) {salir = true;}
					else
					{
						foreach(Turno t in conjuntoTurnos)
						{
							// Obtengo la hora elegida de la lista turnoDisponibles y la hora del conjuntoTurnos de medico para compararlas y que sean iguales
							Turno turnoElegido = (Turno) turnosDisponibles[opcion - 1];
							string horaElegida = turnoElegido.GetHora();
							string horaTurnoMedico = t.GetHora();
							
							if (horaElegida == horaTurnoMedico)
							{
								string nombre = pacienteAsignar.GetNombre();
								t.SetNombrePaciente(nombre);
								t.SetAsignado(true);
								Console.WriteLine("\nSe le asignó a {0} el turno de las {1} hs.", nombre.ToUpper(), t.GetHora());
								salir = true;
							}
						}
					}
				}
				// De no haber turnos disponibles se envía el siguiente mensaje
				else { Console.WriteLine("Horarios no disponibles, llamar próximo día de atención."); salir = true; }
			}
		}
			
		// Funcion para actualizar diagnostico de paciente
		public static void actualizarDiagnostico(Medico medico1)
		{
			// Muestro los pacientes
			Console.WriteLine("Seleccione al paciente:");
			imprimirPacientes(medico1);
			Console.WriteLine("");
			int opcion = int.Parse(Console.ReadLine());
			
			// Me coloco en el paciente elegido
			Paciente pacienteElegido = new Paciente();
			pacienteElegido = medico1.verPaciente(opcion - 1);
			
			// Declaro e inicializo las variables DIAGNOSTICO
			string diagnosticoAntiguo = pacienteElegido.GetDiagnostico().ToUpper();
			Console.Write("Ingrese el nuevo diagnóstico de {0}: ", pacienteElegido.GetNombre());
			string diagnosticoNuevo = Console.ReadLine().ToUpper();
			
			// Actualizo el diagnostico
			pacienteElegido.SetDiagnostico(diagnosticoNuevo);
			Console.WriteLine("\nEl diagnóstico de {0} se modificó de '{1}' a '{2}' ", pacienteElegido.GetNombre().ToUpper(),diagnosticoAntiguo,diagnosticoNuevo);
		}
		
		// Funcion para cancelar turno
		public static void eliminarTurno(Medico medico1)
		{	
			// Tomo la lista de turnos de medico
			ArrayList conjuntoTurnos = new ArrayList();
			conjuntoTurnos = medico1.GetTurnos();
			
			// Lista para guardar los turnos que estan asignados
			ArrayList turnosAsignados = new ArrayList();
			
			// Variable booleana para controlar si hay turnos
			bool noHayTurnos = true;
			
			// Recorro la lista de turnos de medico para saber si hay turnos asignados
			foreach (Turno turno in conjuntoTurnos)
			{
				if (turno.GetAsignado())
				{
					noHayTurnos = false;
				}
			}
			
			// Si no hay turnos lo aviso por consola
			if (noHayTurnos) {Console.WriteLine("No hay turnos asignados actualmente.");}
			
			// Sino, doy la opcion de cancelar
			else
			{
				Console.WriteLine("Seleccione el turno a cancelar:\n");
				
				// Variable INT para enumerar los turnos al imprimirlos
				int numeroTurno = 1;
				
				for(int i = 0; i < conjuntoTurnos.Count; i++)
				{
					// Si el turno esta asignado lo muestro para que el usuario pueda eliminarlo
					if (medico1.verTurno(i).GetAsignado())
					{
						Turno turnoAsignado = medico1.verTurno(i);
						string horaTurno = turnoAsignado.GetHora();
						
						Console.WriteLine("{0}) Turno: {1} hs. (Paciente: {2})", numeroTurno, horaTurno, turnoAsignado.GetNombrePaciente());
						numeroTurno += 1;
						
						turnosAsignados.Add(turnoAsignado);
					}
				}
				Console.WriteLine("0) Atrás.");
				int opcion = int.Parse(Console.ReadLine());
				
				if (opcion == 0) {bool salir = true;}
				else
				{
					foreach(Turno t in conjuntoTurnos)
					{
						// Obtengo la hora elegida de la lista turnosAsignados y la hora del conjuntoTurnos de medico para compararlas y que sean iguales
						Turno turnoElegido = (Turno) turnosAsignados[opcion - 1];
						string horaElegida = turnoElegido.GetHora();
						string horaTurnoMedico = t.GetHora();
						
						if (horaElegida == horaTurnoMedico)
						{
							t.SetNombrePaciente("");
							t.SetAsignado(false);
							Console.WriteLine("\nSe canceló el turno de las {0} hs.", t.GetHora());
							//salir = true;
						}
					}
				}	
			}
		}
		
		// Funcion para listar los turnos dados
		public static void listarTurnos(Medico medico1)
		{
			// Variable booleana para controlar si hay turnos
			bool noHayTurnos = true;
			
			// Recorro la lista de turnos de medico y si un turno está asignado lo imprimo
			foreach (Turno turno in medico1.GetTurnos())
			{
				if (turno.GetAsignado())
				{
					string nombre = turno.GetNombrePaciente();
					string hora = turno.GetHora();
					Console.WriteLine("Turno: {0} hs. (Paciente: {1})", hora, nombre);
					noHayTurnos = false;
				}
			}
			
			// Si no hay turnos lo aviso por consola
			if (noHayTurnos) {Console.WriteLine("No hay turnos asignados actualmente.");}	
		}
		
		// Funcion para listar las obras sociales que atiende el medico (sin repeticiones)
		public static void verObras(Medico medico1)
		{
			// Creo una lista donde voy a guardar las obras sociales
			ArrayList obrasSociales = new ArrayList();
			
			// Si no hay pacientes entonces no hay obras sociales y lo aviso por consola
			if (medico1.cantidadPacientes() == 0) {Console.WriteLine("No hay obras sociales disponibles.");}
			
			// Si hay pacientes entonces imprimo sus obras sociales
			else
			{
				// Recorro la lista de pacientes de medico y obtengo la obra social de cada paciene
				foreach (Paciente p in medico1.GetPacientes())
				{
					string obraSocial = p.GetObraSocial();
					bool existe = false;
					
					// Recorro la lista de obras sociales para saber si la obra social del paciente ya está incluida
					foreach (string o in obrasSociales)
					{
						if (obraSocial == o)
						{
							existe = true;
							break;
						}
					}
					
					// Si la obra social del paciente NO está incluida entonces se agrega a la lista de obras sociales
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
		}
		
		// Funcion para agregar paciente
		public static void agregarPaciente(Medico medico1)
		{
			// Declaro e inicializo las variables (datos del paciente) NOMBRE, DNI, OBRA SOCIAL y NRO DE AFILIADO
			Console.Write("Nombre y apellido del paciente: ");
			string nombre = Console.ReadLine().ToUpper();
			Console.Write("DNI: ");
			int dni = int.Parse(Console.ReadLine());
			Console.Write("Obra social (“particular” si no posee): ");
			string obraSocial = Console.ReadLine().ToUpper();
			Console.Write("Nro de afiliado (0 si no posee obra social): ");
			int nroAfiliado = int.Parse(Console.ReadLine());
			
			// Creo el paciente con los datos dados
			Paciente paciente1 = new Paciente(nombre, dni, obraSocial, nroAfiliado);
			
			// Agrego el paciente a la lista del médico y lo anuncio por consola
			medico1.agregarPaciente(paciente1);
			Console.WriteLine("\n{0} ha sido agregado/a a la lista de pacientes con éxito.", nombre);
			
		}
		
		// Funcion para eliminar paciente
		public static void eliminarPaciente(Medico medico1)
		{
			// Muestro los pacientes que hay
			imprimirPacientes(medico1);
			
			// Declaro e inicializo las variables DNI (para buscar al paciente a eliminar) y EXISTE (para saber si dicho paciente existe)
			bool existe = false;
			Console.Write("\nIngrese el DNI del paciente a borrar: ");
			int dni = int.Parse(Console.ReadLine());
			
			// Recorro la lista de pacientes de medico en busca del paciente con el DNI ingresado
			foreach (Paciente i in medico1.GetPacientes())
			{
				if (dni == i.GetDni())
				{
					medico1.eliminarPaciente(i);
					Console.WriteLine("\n{0} ha sido eliminado/a con éxito.", i.GetNombre());
					existe = true;
					break;
				}
			}
			
			// Si no existe se avisa por teclado
			if (!existe) { Console.WriteLine("\nNo existe un/a paciente con el DNI indicado."); }
		}
		
		// Funcion para listar pacientes
		public static void listarPacientes(Medico medico1)
		{
			Console.WriteLine("Lista de pacientes:");
			
			 // Tomo la lista de pacientes de medico
			ArrayList conjuntoPacientes;
			conjuntoPacientes = medico1.GetPacientes();
			
			// Chequeo si hay pacientes cargados
			if (medico1.cantidadPacientes() == 0) {Console.WriteLine("No hay pacientes cargados actualmente.");}
			
			// Recorro la lista para obtener los datos de cada paciente e imprimirlos
			else
			{
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
}