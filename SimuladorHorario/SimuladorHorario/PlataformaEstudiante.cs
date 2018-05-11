using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorHorario
{
    [Serializable()]
    public static class PlataformaEstudiante
    {
        public static void MenuPlataformaEstudiante(Estudiante estudiante)
        {
            #region
            /*
            InicioPlataforma:
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

    */
            #endregion

        }
        
        public static bool ChequearCompatibilidadHorario(Estudiante estudiante, CursoCurricular cursoInscribir)
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
                if (listaBloquesUsados.Contains(evento.hora)) { return false; }
            }
            return true;
        }

        public static bool ChequearCompatibilidadPreRequisito(Estudiante estudiante, CursoCurricular cursoCurricular)
        {
            foreach (string cur in cursoCurricular.cursosPreRequisito)
            {
                if (!estudiante.avanceMalla.Contains(cur)) { return false; }
            }
            return true;
        }

        public static Estudiante InscribirCurso(Estudiante estudiante, string cursoInscripcion)
        {
            MessageBox.Show(cursoInscripcion);
            CursoCurricular curso = Aplicacion.GetCursoCurricular().Find(x => x.nombre == cursoInscripcion);

            bool compatibilidadHorario = ChequearCompatibilidadHorario(estudiante, curso);
            bool compatibilidadPreRequisito = ChequearCompatibilidadPreRequisito(estudiante, curso);

            if (estudiante.listaInscripcion.Contains(curso))
            {
                MessageBox.Show("El Curso ya está inscrito.", "Error de Inscripcion");
            }
            else
            {
                if (compatibilidadHorario == false)
                {
                    MessageBox.Show($"El curso {curso.nombre} posee un tope de horario\n", "Error de Inscripcion");
                }
                else if (compatibilidadPreRequisito == false)
                {
                    MessageBox.Show($"Todavia no has aprobado el curso {curso.nombre}", "Error de Inscripcion");
                }
                else if ((compatibilidadHorario == false) || (compatibilidadPreRequisito == false))
                {
                    MessageBox.Show($"No puedes inscribir el curso {curso.nombre}", "Error de Inscripcion");
                }
                else
                {
                    //MessageBox.Show("Agregado Exitosamente");
                    estudiante.listaInscripcion.Add(curso);
                    return estudiante;
                }
            }

            return estudiante;
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
