using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    [Serializable()]
    public static class Gestor
    {
        public static void MenuGestor(Administrador administrador)
        {
            #region
            /*MenuGestor:
            Console.Clear();
            Program.ImprimirBanner("Bienvenido " + administrador.nombre + " al gestor");
            Console.WriteLine("Que desea hacer: ");
            Console.WriteLine("1. Crear Curso\n" +
                          "2. Leer Curso\n" +
                          "3. Actualizar Curso\n" +
                          "4. Eliminar Curso\n" +
                          "5. Cerrar Sesion");

            int opcion = Program.ChequearOpcion(1, 5);
            if (opcion == 1) CrearCursoCurricular(); Program.Log(opcion.ToString(), "Crear Curso");
            if (opcion == 2) LeerCurso(); Program.Log(opcion.ToString(), "Leer Curso");
            if (opcion == 3) ActualizarCurso();
            if (opcion == 4) EliminarCurso(); Program.Log(opcion.ToString(), "Eliminar Curso");
            if (opcion == 5) return;

            goto MenuGestor;*/
            #endregion
        }
        public static bool CrearCursoCurricular(string nrc, string nombreCurso, string profesor, int creditos, Especialidad especialidad)
        {

            List<string> listadoNRC = Aplicacion.GetCursoCurricular().Select(x => x.nrc).ToList();
            if (listadoNRC.Contains(nrc))
            {
                return false;
            }


            List<Evento> listaEventos = new List<Evento>();
            int quiereAgregarEv = 1;

            Aplicacion.AñadirCurso(new CursoCurricular(nrc, creditos, new List<string>(), especialidad, listaEventos, nombreCurso, profesor, TipoCurso.Curricular));
            return true;
        }

        public static void LeerCurso()
        {
            LeerCurso:
            Console.Clear();
            Program.ImprimirBanner("Leer Curso");
            ImprimirCursos();
            Console.WriteLine("\nSeleccione El NRC del curso que desea leer: ");
            List<string> listadoNRC = Aplicacion.GetCursoCurricular().Select(x => x.nrc).ToList();
            string option = "";


            do
            {
                Console.Write("NRC:> ");
                option = Console.ReadLine();
                if (!listadoNRC.Contains(option)) { Program.ImprimirNegativo("NRC No Valido"); }
            } while (!listadoNRC.Contains(option));

          
            CursoCurricular curso = Aplicacion.GetCursoCurricular().Find(x => x.nrc == option);
            Console.Clear();
            Console.WriteLine($"NRC: {curso.nrc}\nNombre: {curso.nombre}\n" +
                $"Creditos: {curso.creditos}\nProfesor: {curso.profesor}\nEventos:\n");

            foreach (Evento evento in curso.eventosCurso)
            {
                Console.WriteLine($"\t{evento.nombre} [{evento.tipo.ToString()}] hora:{evento.hora} fecha:{evento.fecha}");
            }

            Console.Write("\n¿Leer Otro Curso?\n" +
                "1. Si\n" +
                "2. No\n:> ");
            int opcion = Program.ChequearOpcion(1, 2);
            if (opcion == 1) goto LeerCurso;
            if (opcion == 2) { Console.Clear();return; }
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
                Console.Write("NRC:> ");
                option = Console.ReadLine();
            }

            CursoCurricular curso = Aplicacion.GetCursoCurricular().Find(x => x.nrc == option);

            Aplicacion.cursos.Remove(curso);
            Program.ImprimirPositivo($"Curso {curso.nombre} removido exitosamente!");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();

            return;
        }
        public static void ImprimirCursos()
        {
            foreach(CursoCurricular curso in Aplicacion.GetCursoCurricular())
            {
                Console.WriteLine($"NRC: {curso.nrc}, Nombre: {curso.nombre}");
                
            }
            return;
        }
        

        public static List<Evento> CrearEvento(string fecha, TipoEvento tipoEvento, string sala,string HoraInicio, int duracion)
        {
            List<Evento> listaEvento = new List<Evento>();
            string HoraFin;
            int a = Convert.ToInt32(HoraInicio.Split(':')[0]);

            HoraFin = (a + duracion).ToString() + ":" + "20";

            for(int i = 0; i < duracion; i++)
            {
                string hora = (a + i).ToString() + ":" + "30";
                string nombreEvento = string.Empty;
                Evento evento = new Evento(nombreEvento, hora, sala, tipoEvento);
                listaEvento.Add(evento);
            }


  
            Program.ImprimirPositivo("Evento Agregado");
            return listaEvento;

        }

    }
}
