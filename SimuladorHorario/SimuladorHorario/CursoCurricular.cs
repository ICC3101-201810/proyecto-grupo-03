using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    [Serializable()]
    public class CursoCurricular:Curso
    {
        public string nrc { get; private set; }
        public int creditos { get; private set; }
        public List<string> cursosPreRequisito;
        public Especialidad especialidad;
        public List<Evento> eventosCurso { get; private set; }        

        public CursoCurricular(string nrc, int creditos,
            List<string> cursosPreRequisito, Especialidad especialidad,
            List<Evento> eventosCurso, string nombre, string profesor,
            TipoCurso tipo):base(nombre,profesor, tipo)
        {
            this.nrc = nrc;
            this.creditos = creditos;
            this.cursosPreRequisito = cursosPreRequisito;
            this.especialidad = especialidad;
            this.eventosCurso = eventosCurso;
            tipo = TipoCurso.Curricular;
        }   
    }
}
