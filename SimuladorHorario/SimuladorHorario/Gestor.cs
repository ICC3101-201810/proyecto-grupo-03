using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorHorario
{
    [Serializable()]
    public static class Gestor
    {
         
        public static bool CrearCursoCurricular(string nrc, string nombreCurso, string profesor, int creditos, Especialidad especialidad, List<Evento> eventosCurso)
        {
            
            List<string> listadoNRC = Aplicacion.GetCursoCurricular().Select(x => x.nrc).ToList();
            if (listadoNRC.Contains(nrc))
            {
                return false;
            }

            Aplicacion.AñadirCurso(new CursoCurricular(nrc, creditos, new List<string>(), especialidad, eventosCurso, nombreCurso, profesor, TipoCurso.Curricular));
            return true;
        }
        public static void LeerCurso(string nrcCurso)
        {
            foreach (CursoCurricular cursoCur in Aplicacion.cursos)
            {
                if (cursoCur.nrc == nrcCurso)
                {
                    MessageBox.Show(
                        $"Nombre: {cursoCur.nombre}\n" +
                        $"NRC: {cursoCur.nrc}\n" +
                        $"Profesor: {cursoCur.profesor}\n" +
                        $"Creditos: {(cursoCur.creditos).ToString()}\n" +
                        $"Especialidad: {cursoCur.especialidad}\n");

                    string eventoInfo = "";
                    foreach(Evento evento in cursoCur.eventosCurso)
                    {
                        eventoInfo += evento.primerPeriodo.ToString() +"\n" + evento.tipo.ToString() + "\n"+ evento.fecha + ": " + evento.hora +"\n\n";
                    }
                    
                    break;
                }



            }

        }
        public static bool ActualizarCurso(string nrc, string parametro, object cambio)
        {
            CursoCurricular curso = Aplicacion.GetCursoCurricular().Find(x => x.nrc == nrc);
            if (parametro == "nrc")
            {
                foreach(CursoCurricular c in Aplicacion.GetCursoCurricular())
                {
                    if (c.nrc == (string)cambio)
                    {
                        MessageBox.Show("Ese NRC ya existe");
                        return false;
                    }
                }
                curso.nrc =cambio.ToString();
            }

            else if (parametro == "nombre")
            {
                curso.nombre = cambio.ToString();
                
            }

            else if (parametro == "creditos")
            {
                curso.creditos = (int)cambio;
            }

            else if(parametro == "especialidad")
            {
                curso.especialidad = (Especialidad)Enum.Parse(typeof(Especialidad), cambio.ToString());
            }

            else if(parametro == "profesor")
            {
                curso.profesor = cambio.ToString();
            }
            return true;
        }
        public static void EliminarCurso(string nrcCurso)
        {
            foreach (CursoCurricular cursoCur in Aplicacion.cursos)
            {
                if (cursoCur.nrc == nrcCurso)
                {
                    Aplicacion.cursos.Remove(cursoCur);
                    MessageBox.Show($"El curso {cursoCur.nombre} ha sido eliminado");
                    break;
                }
            }

            #region
            /*
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
            */
            #endregion
            return;
        }
        public static List<Evento> CrearEvento(string nombre, string fecha, TipoEvento tipoEvento, string sala,string HoraInicio, int duracion)
        {
            List<Evento> listaEvento = new List<Evento>();
            string HoraFin;
            int horas = Convert.ToInt32(HoraInicio.Split(':')[0]);

            HoraFin = (horas + duracion).ToString() + ":" + "20";

            for(int i = 0; i < duracion; i++)
            {
                string hora = (horas + i).ToString() + ":" + "30";
                string nombreEvento = nombre;
                Evento evento = new Evento(nombreEvento, hora, sala, tipoEvento);
                listaEvento.Add(evento);
            }

            return listaEvento;

        }
        public static void AñadirAlAvanceMalla(string nombreEstudiante, string curso)
        {
            
            foreach(Usuario user in Aplicacion.usuarios)
            {
                if (nombreEstudiante == user.nombre)
                {
                    Estudiante estudiante = (Estudiante)user;
                    estudiante.avanceMalla.Add(curso);
                }
            }
        }
        public static void EliminarDelAvanceMalla(string nombreEstudiante, string curso)
        {
            foreach(Usuario user in Aplicacion.usuarios)
            {
                if(nombreEstudiante == user.nombre)
                {
                    Estudiante estudiante = (Estudiante)user;                   
                    estudiante.avanceMalla.Remove(curso);
                }
            }
        }
            

    }
}
