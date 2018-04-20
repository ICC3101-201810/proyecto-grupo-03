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
        Concentracion concentracion;
        Especialidad especialidad;
        public List<Curso> listaInscripcion { get; private set; }
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
        
    }
}
