using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    static class PlataformaEstudiante
    {
        public static void MenuPlataformaEstudiante()
        {

        }
        public static bool Guardar() { return false; }
        static bool ChequearCompatibilidad(Curso curso, Estudiante estudiante) { return false; }
        static void InscribirCurso(Curso curso) { return; }
        static void EliminarCursoInscrito(Curso curso) { return; }
        static int ContarCreditos(List<Curso> listaCursosInscritos) { return 1; }
        
    }
}
