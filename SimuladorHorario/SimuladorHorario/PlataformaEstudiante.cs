using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    static class PlataformaEstudiante
    {
        public static void MenuPlataformaEstudiante(Estudiante estudiante)
        {
            InicioPlataforma:
            Console.Clear();
            Program.ImprimirBanner("Bienvenido " + estudiante.nombre + " a la plataforma de estudiante");
            Console.WriteLine("Que desea hacer:\n" +
                             "1. Inscribir Curso\n" +
                             "2. Eliminar curso\n" +
                             "3. Mostrar Cursos Inscritos\n" +
                             "4. Mostrar Avance Curricular\n" +
                             "5. Cerrar Sesion");
            int opcion = Program.ChequearOpcion(1, 5);
            if (opcion == 1) { InscribirCurso(estudiante); goto InicioPlataforma; }

            if (opcion == 2) { EliminarCursoInscrito(estudiante); goto InicioPlataforma; }

            if (opcion == 3) { estudiante.MostrarCursos();goto InicioPlataforma; }

            if (opcion == 4) { estudiante.MostrarAvance(); goto InicioPlataforma; }

            if (opcion == 5) { return; }

        }
        public static bool Guardar()
        {
            return false;
        }
        public static bool ChequearCompatibilidad(Estudiante estudiante, CursoCurricular cursoInscribir)
        {
            List<string> listaBloquesUsados = new List<string>();
            foreach(Curso curso in estudiante.listaInscripcion)
            {
                CursoCurricular cursoCurricular = (CursoCurricular)curso;
                foreach(Evento bloqueHorario in cursoCurricular.eventosCurso)
                {
                    listaBloquesUsados.Add(bloqueHorario.hora);
                }
            }

            foreach(Evento evento in cursoInscribir.eventosCurso)
            {
                if (listaBloquesUsados.Contains(evento.hora)){ return false; }
            }


            return true;
        }
        static void InscribirCurso(Estudiante estudiante)
        {
            int quiereAgregar = 1;
            while (quiereAgregar == 1)
            {

                if (Aplicacion.GetCursoCurricular().Count == 0)
                {
                    Console.WriteLine("No hay cursos disponibles para inscribir");
                    goto SinCursosDisponiblesParaInscribir;
                }

                Console.WriteLine("Seleccione un curso para inscribir: ");
                foreach (CursoCurricular curs in Aplicacion.GetCursoCurricular())
                {
                    Console.WriteLine("NRC:{0}\nNombre: {1}\nProfesor: {2}\n", curs.nrc, curs.nombre, curs.profesor);
                }

                List<string> listadoNRC = Aplicacion.GetCursoCurricular().Select(x => x.nrc).ToList();

                string option = "";


                do
                {
                    Console.Write("NRC:> ");
                    option = Console.ReadLine();
                    if (!listadoNRC.Contains(option)) { Program.ImprimirNegativo("NRC No Valido"); }

                } while (!listadoNRC.Contains(option));

                CursoCurricular curso = Aplicacion.GetCursoCurricular().Find(x => x.nrc == option);

                bool compatibilidad = ChequearCompatibilidad(estudiante, curso);
                if (estudiante.listaInscripcion.Contains(curso))
                {
                    Program.ImprimirNegativo($"El curso {curso.nombre} ya esta agregado\n");
                    //Console.WriteLine("El curso {0} ya esta agregado\n", curso.nombre);
                }
                else if (compatibilidad == false)
                {
                    Program.ImprimirNegativo($"El curso {curso.nombre} posee un tope de horario\n");
                }
                else
                {
                    estudiante.listaInscripcion.Add(curso);
                    Program.ImprimirPositivo("Curso agregado");
                    Program.Log(quiereAgregar.ToString(), "Agregar curso");
                }
                
                Console.WriteLine("\n¿Quiere agregar otro curso?\n" +
                    "1. Si\n" +
                    "2. No");
                int opcion = Program.ChequearOpcion(1, 2);
                if (opcion == 2)
                {
                    quiereAgregar = 2;
                }
            }

            SinCursosDisponiblesParaInscribir:

            //Console.WriteLine("\nPresione cualquier tecla para continuar...");
            //Console.ReadKey();
            return;
        }
        static void EliminarCursoInscrito(Estudiante estudiante)
        {
            Console.Clear();
            if (estudiante.listaInscripcion.Count() == 0)
            {
                Program.ImprimirNegativo("No hay cursos para eliminar");
                Console.WriteLine("Presione cualquier tecla para volver al menu");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("¿Que curso desea eliminar? ");

            for (int i = 0; i < estudiante.listaInscripcion.Count(); i++)
            {
                Console.WriteLine(i+1 + ". " + estudiante.listaInscripcion[i].nombre);
            }
            Console.WriteLine(estudiante.listaInscripcion.Count()+1 + ". Salir");

            int opcion = Program.ChequearOpcion(1, estudiante.listaInscripcion.Count()+1);

            if (opcion != estudiante.listaInscripcion.Count() + 1) 
            {
                estudiante.listaInscripcion.Remove(estudiante.listaInscripcion[opcion-1]);
                Console.Clear();
                Program.ImprimirPositivo("Curso eliminado");
                Program.Log(opcion.ToString(), "Eliminar curso");
                Console.WriteLine("Presione cualquier tecla para volver al menu");
                Console.ReadKey();
            }

            return;
        }
        static int ContarCreditos(List<Curso> listaCursosInscritos) { return 1; }
        static void AgregarEventoPersonal(Estudiante estudiante) { return; }
    }
}
