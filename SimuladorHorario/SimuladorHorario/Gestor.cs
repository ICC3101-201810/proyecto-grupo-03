using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    static class Gestor
    {
        public static void MenuGestor(Administrador administrador)
        {
            MenuGestor:
            Console.Clear();
            Program.ImpribirBanner("Bienvenido" + administrador.nombre + " al gestor");
            Console.WriteLine("Que desea hacer: ");
            Console.WriteLine("1. Crear Curso\n" +
                          "2. Leer Curso\n" +
                          "3. Actualizar Curso\n" +
                          "4. Eliminar Curso\n" +
                          "5. Cerrar Sesion");

            int opcion = Program.ChequearOpcion(1, 5);
            if (opcion == 1) CrearCurso(); Program.Log(opcion.ToString(), "Crear Curso");
            if (opcion == 2) LeerCurso();Program.Log(opcion.ToString(), "Leer Curso");
            if (opcion == 3) ActualizarCurso();
            if (opcion == 4) EliminarCurso();
            if (opcion == 5) return;

            goto MenuGestor;
        }
        public static void CrearCurso()
        {
            Console.Clear();
            Console.WriteLine("--Crear Curso--");

            List<string> listadoNRC = Aplicacion.GetCursoCurricular().Select(x => x.nrc).ToList();
            string nrc = string.Empty;
            Console.Write("NRC: ");
            while (true)
            {
                Console.Write("NRC: ");
                nrc = Console.ReadLine();

                if (!listadoNRC.Contains(nrc)) { break; }
                else { Console.WriteLine("Ese NRC ya existe!"); }

            }


            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Creditos: ");
            int creditos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Especialidad: ");
            string especialidad = Console.ReadLine();



        }   
        public static void LeerCurso()
        {
            LeerCurso:
            Console.WriteLine("Seleccione El NRC del curso que desea leer:");
            ImprimirCursos();




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
                $"Creditos:{curso.creditos}\nProfesor{curso.profesor}\n\n");

            Console.Write("Leer Otro Curso?\n" +
                "1. Si\n" +
                "2. No\n:> ");
            int opcion = Program.ChequearOpcion(1, 2);
            if (opcion == 1) goto LeerCurso;
            if (opcion == 2) return;
            else return;




        }
        public static void ActualizarCurso()
        {
            return;
        }
        public static void EliminarCurso()
        {

            Program.ImprimirNegativo("Eliminar Curso");
            Console.WriteLine("Seleccione el NRC del curso a eliminar:");
            
            ImprimirCursos();


            List<string> listadoNRC = Aplicacion.GetCursoCurricular().Select(x => x.nrc).ToList();

            string option = "";
            while (!listadoNRC.Contains(option))
            {
                Console.Write("NRC: ");
                option = Console.ReadLine();
            }

            CursoCurricular curso = Aplicacion.GetCursoCurricular().Find(x => x.nrc == option);

            Aplicacion.cursos.Remove(curso);
            Program.ImprimirPositivo($"Curso: {curso.nrc} Removido exitosamente!");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();


            return;
        }
        public static void ImprimirCursos()
        {
            foreach(CursoCurricular curso in Aplicacion.GetCursoCurricular())
            {
                Console.WriteLine($"NRC:{curso.nrc} Nombre:{curso.nombre}");
            }
            return;
        }

    }
}
