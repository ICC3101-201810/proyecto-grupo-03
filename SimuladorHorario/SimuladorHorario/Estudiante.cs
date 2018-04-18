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
        string carrera, especialidad, añoIngreso, concentracion;
        List<Curso> listaInscripcion;
        List<Curso> listaCursoDisponible;

        public Estudiante(List<CursoCurricular> avanceMalla,
            string carrera, string especialidad, string añoIngreso,
            string concentracion, List<Curso> listaInscripcion,
            List<Curso> listaCursoDisponible,
            string nombreUsuario, string contraseña):base(nombreUsuario, contraseña)
        {
            this.avanceMalla = avanceMalla;
            this.carrera = carrera;
            this.especialidad = especialidad;
            this.añoIngreso = añoIngreso;
            this.concentracion = concentracion;
            this.listaInscripcion = listaInscripcion;
            this.listaCursoDisponible = listaCursoDisponible;
        }
        
    }
}
