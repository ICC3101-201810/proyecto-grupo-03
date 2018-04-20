using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    abstract class Curso
    {
        public string nombre { get; private set; }
        string profesor;
        List<Evento> horarios;
        public TipoCurso tipo { get; private set; }

        public Curso(string nombre, string profesor, List<Evento> horarios, TipoCurso tipo)

        {
            this.nombre = nombre;
            this.profesor = profesor;
            this.horarios = horarios;
            this.tipo = tipo;

        }

    }
}
