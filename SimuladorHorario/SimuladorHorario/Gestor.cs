using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    [Serializable()]
    static class Gestor
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
        public static void CrearCursoCurricular()
        {
            Console.Clear();

            List<string> listadoNRC = Aplicacion.GetCursoCurricular().Select(x => x.nrc).ToList();
            Console.Write("NRC:> ");
            string nrc = Console.ReadLine();
            if (listadoNRC.Contains(nrc))
            {
                do
                {
                    Program.ImprimirNegativo("Ese NRC ya existe");
                    Console.Write("Ingrese otro NRC:> ");
                    nrc = Console.ReadLine();
                } while (listadoNRC.Contains(nrc));
            }

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Profesor: ");
            string profesor = Console.ReadLine();

            Console.Write("Creditos: ");
            int creditos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Especialidad:\n");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i + 1 + ". " + Enum.GetName(typeof(Especialidad), i));
            }
            Especialidad especialidad = (Especialidad)Program.ChequearOpcion(1, 6);

            List<Evento> listaEventos = new List<Evento>();
            int quiereAgregarEv = 1;
            while (quiereAgregarEv == 1)
            {
                listaEventos.AddRange(CrearEventoM(listaEventos));
                Console.WriteLine("¿Quiere agregar otro evento?\n" +
                                  "1. Si\n" +
                                  "2. No ");
                int opcion = Program.ChequearOpcion(1, 2);
                if (opcion == 2)
                {
                    quiereAgregarEv = 2;
                }
            }
            Program.ImprimirPositivo("Curso agregado");



            Aplicacion.AñadirCurso(new CursoCurricular(nrc, creditos, new List<string>(), especialidad, listaEventos, nombre, profesor, TipoCurso.Curricular));
            Console.Write("Presione una tecla para continuar");
            Console.ReadKey();
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
        

        public static List<Evento> CrearEventoM(List<Evento> listaEventos)
        {
            Console.WriteLine("Ingrese el dia");
            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine(i + 1 + ". " + Enum.GetName(typeof(DayOfWeek), i));
            }
            int opcion = Program.ChequearOpcion(1, 7);
            DayOfWeek dia = (DayOfWeek)opcion;

            Console.WriteLine("Ingrese el tipo de evento");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i + 1 + ". " + Enum.GetName(typeof(TipoEvento), i));
            }
            opcion = Program.ChequearOpcion(1, 6);
            TipoEvento tipoEvento = (TipoEvento)opcion;

            Console.Write("Ingrese la sala:> ");
            string sala = Console.ReadLine();

            List<Evento> listaEvento = new List<Evento>();

            while (true)
            {
                Console.WriteLine("--Agregar bloques de Horario--");

                Console.WriteLine("Ingrese bloque de horario");
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(i + 1 + ". " + Program.ConvertirFormato(Enum.GetName(typeof(BloquesHorarios), i)));
                }
                opcion = Program.ChequearOpcion(1, 14);
                string HoraInicio = (Program.ConvertirFormato(Enum.GetName(typeof(BloquesHorarios),opcion-1))).Replace('-',':');

                Console.WriteLine("Duracion Evento (Horas)\n:>");
                opcion = Program.ChequearOpcion(1, 5);
                string HoraFin;
                int a = Convert.ToInt32(HoraInicio.Split(':')[0]);

                HoraFin = (a + opcion).ToString() + ":" + "20";

                for(int i = 0; i < opcion; i++)
                {
                    string hora = (a + i).ToString() + ":" + "30";
                    string nombreEvento = string.Empty;
                    Evento evento = new Evento(nombreEvento, hora, sala, tipoEvento);
                    listaEvento.Add(evento);
                }
                break;

            }



            Program.ImprimirPositivo("Evento Agregado");
            return listaEvento;

        }

    }
}
