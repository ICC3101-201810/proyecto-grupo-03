using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    class Estudiante:Usuario
    {
        public List<CursoCurricular> avanceMalla { get; private set; }
        public Concentracion concentracion { get; private set; }
        public Especialidad especialidad { get; private set; }
        public List<Curso> listaInscripcion { get; protected set; }
        List<Curso> cursosInscritos;

        public Estudiante(List<CursoCurricular> avanceMalla,
            Especialidad especialidad,
            Concentracion concentracion,string nombreUsuario, 
            string contraseña, bool esAdmin)
            :base(nombreUsuario, contraseña, esAdmin)
        {
            this.avanceMalla = avanceMalla;
            this.especialidad = especialidad;
            this.concentracion = concentracion;
            listaInscripcion = new List<Curso>();
            cursosInscritos = new List<Curso>();
        }


        public void MostrarCursos()
        {
            Console.Clear();
            Program.ImprimirBanner($"Lista Inscripcion {nombre}\n");
            foreach(Curso curso in listaInscripcion)
            {
                if (curso is CursoCurricular)
                {
                    Console.WriteLine($"NRC: {((CursoCurricular)curso).nrc} Nombre: {curso.nombre}");
                    continue;
                }
                Console.WriteLine(curso.nombre);

            }

            Console.WriteLine("\npresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        public void MostrarAvance()
        {
            Console.Clear();
            Program.ImprimirBanner($"Avance Curricular {nombre}\n");
            foreach (CursoCurricular curso in avanceMalla)
            {
                Console.WriteLine($"NRC: {curso.nrc} Nombre: {curso.nombre}");
            }

            Console.WriteLine("\npresione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        
    }
}
