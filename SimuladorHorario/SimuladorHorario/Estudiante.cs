using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    class Estudiante:Usuario
    {
        List<CursoCurricular> avanceMalla;
        string carrera, añoIngreso, concentracion;
        Especialidad especialidad;
        List<Curso> listaInscripcion;
        List<Curso> cursosInscritos;

        public Estudiante(List<CursoCurricular> avanceMalla,
            string carrera, Especialidad especialidad, string añoIngreso,
            string concentracion, List<Curso> cursosInscritos,
            string nombreUsuario, string contraseña, bool esAdmin)
            :base(nombreUsuario, contraseña, esAdmin)
        {
            this.avanceMalla = avanceMalla;
            this.carrera = carrera;
            this.especialidad = especialidad;
            this.añoIngreso = añoIngreso;
            this.concentracion = concentracion;
            listaInscripcion = new List<Curso>();
            this.cursosInscritos = cursosInscritos;
            esAdmin = false;
        }
        
    }
}
