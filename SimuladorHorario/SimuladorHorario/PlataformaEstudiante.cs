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
            Program.ImprimirBanner("Bienvenido " + estudiante.nombre+ " a la plataforma de estudiante");
            Console.WriteLine("Que desea hacer:\n" +
                             "1. Inscribir Curso");
            int opcion = Program.ChequearOpcion(1, 1);
            if (opcion == 1) InscribirCurso();

            Console.ReadKey();
        }
        public static bool Guardar()
        {
            return false;
        }
        public static bool ChequearCompatibilidad(Estudiante estudiante)
        {
            List<DayOfWeek> diasSemana = new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Tuesday,
                DayOfWeek.Wednesday,DayOfWeek.Thursday, DayOfWeek.Friday};
            
            foreach (DayOfWeek dia in diasSemana)
            {
                for (int i = 0; i<estudiante.listaInscripcion.Count(); i++)
                {

                    for (int j = 0;j<estudiante.listaInscripcion.Count(); i++)
                    {
                        if (estudiante.listaInscripcion[i] == estudiante.listaInscripcion[j])
                        {
                            continue;
                        }
                       
                    }
                }
            }
            return false;
        }
        static void InscribirCurso()
        {
            if (Aplicacion.GetCursoCurricular().Count == 0)
            {
                Console.WriteLine("No hay cursos disponibles para inscribir");
                goto SinCursosDisponiblesParaInscribir;
            }

            Console.WriteLine("Seleccione un curso para inscribir");
            foreach(CursoCurricular curs in Aplicacion.GetCursoCurricular())
            {
                Console.WriteLine("NRC:{curs.nrc}\nNombre: {curs.nombre}\nProfesor: {curs.profesor}\n");
            }

            List<string> listadoNRC = Aplicacion.GetCursoCurricular().Select(x => x.nrc).ToList();

            string option="";
            while (!listadoNRC.Contains(option))
            {
                Console.Write("NRC: ");
                option = Console.ReadLine();
            }

            CursoCurricular curso = Aplicacion.GetCursoCurricular().Find(x => x.nrc == option);

            SinCursosDisponiblesParaInscribir:

            Console.WriteLine("Hasta aqui llegamos");
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
            return;
        }
        static void EliminarCursoInscrito(Estudiante estudiante)
        {
            Console.Clear();
            if (estudiante.listaInscripcion.Count == 0)
            {
                Program.ImprimirNegativo("No hay cursos para eliminar");
                Console.WriteLine("Presione una tecla para volver al menu");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Que curso desea eliminar: ");

            for (int i = 0; i<estudiante.listaInscripcion.Count(); i++)
            {
                Console.WriteLine(i+1 + ". " + estudiante.listaInscripcion[i].nombre);
            }

            Console.WriteLine(estudiante.listaInscripcion.Count() + ". Salir");
            int opcion = Program.ChequearOpcion(1, estudiante.listaInscripcion.Count());
            if (opcion == estudiante.listaInscripcion.Count()) return;
            estudiante.listaInscripcion.Remove(estudiante.listaInscripcion[opcion-1]);
            Console.Clear();
            Program.ImprimirPositivo("Curso eliminado");
            return;
        }
        static int ContarCreditos(List<Curso> listaCursosInscritos) { return 1; }
        
    }
}
