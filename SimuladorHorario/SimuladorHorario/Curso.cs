using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    public abstract class Curso
    {
        public string nombre { get; private set; }

        public string profesor { get; private set; }
        public TipoCurso tipo { get; private set; }

        public Curso(string nombre, string profesor, TipoCurso tipo)

        {
            this.nombre = nombre;
            this.profesor = profesor;
            this.tipo = tipo;

        }

    }
}
