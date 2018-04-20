using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    static class Gestor
    {
        public static void MenuGestor()
        {
            Console.WriteLine("--Menu Gestor--");
            Console.WriteLine("Que desea hacer: ");
            Console.WriteLine("1. Crear Curso\n" +
                          "2. Leer Curso\n" +
                          "3. Actualizar Curso\n" +
                          "4. Eliminar Curso");

            int opcion = Program.ChequearOpcion(1, 4);
            if (opcion == 1) CrearCurso();
            if (opcion == 2) LeerCurso();
            if (opcion == 3) ActualizarCurso();
            if (opcion == 4) EliminarCurso();

            Console.ReadKey();
        }
        public static void CrearCurso()
        {
            Console.Clear();
            Console.WriteLine("--Crear Curso--");

            Console.Write("NRC: ");
            string nrc = Console.ReadLine();

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Creditos: ");
            int creditos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Especialidad: ");
            string especialidad = Console.ReadLine();



        }   
        public static void LeerCurso()
        {
            Console.WriteLine("Seleccione El NRC del curso que desea leer");
            foreach(CursoCurricular curso_ in Aplicacion.GetCursoCurricular())
            {
                Console.WriteLine($"NRC:{curso_.nrc}\tNombre:{curso_.nombre}");
            }




            List<string> listadoNRC = Aplicacion.GetCursoCurricular().Select(x => x.nrc).ToList();
            
            string option = "";
            while (!listadoNRC.Contains(option))
            {
                Console.Write("NRC: ");
                option = Console.ReadLine();
            }

            CursoCurricular curso = Aplicacion.GetCursoCurricular().Find(x => x.nrc == option);
            Console.Clear();
            Console.WriteLine($"NRC:{curso.nrc}\nNombre:{curso.nombre}\n" +
                $"Creditos:{curso.creditos}\nProfesor{curso.profesor}\n");




        }
        public static void ActualizarCurso()
        {
            return;
        }
        public static void EliminarCurso()
        {
            return;
        }
    }
}
