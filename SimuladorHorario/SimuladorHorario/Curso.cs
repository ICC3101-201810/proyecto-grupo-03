using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    [Serializable()]
    public abstract class Curso
    {
        public string nombre;
        public string profesor;
        public TipoCurso tipo;

        public Curso(string nombre, string profesor, TipoCurso tipo)

        {
            this.nombre = nombre;
            this.profesor = profesor;
            this.tipo = tipo;

        }

    }
}
