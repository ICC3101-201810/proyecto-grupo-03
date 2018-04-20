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
            Program.ImpribirBanner("Bienvenido " + estudiante.nombre);
            Console.WriteLine("Que desea hacer:\n" +
                             "1. Inscribir Curso\n");
            int opcion = Program.ChequearOpcion(1, 3);
            if (opcion == 1) InscribirCurso();

            Console.ReadKey();
        }
        public static bool Guardar()
        {
            return false;
        }
        static bool ChequearCompatibilidad(Curso curso, Estudiante estudiante) { return false; }
        static void InscribirCurso() {

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

            Console.WriteLine("Hasta aqui llegamos");
            Console.ReadKey();
            return;
        }
        static void EliminarCursoInscrito(Curso curso) { return; }
        static int ContarCreditos(List<Curso> listaCursosInscritos) { return 1; }
        
    }
}
