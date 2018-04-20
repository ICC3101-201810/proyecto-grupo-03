using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    class TallerExtraProgramatico : Curso
    {
        List<Evento> eventosExtraP;
        public TipoCurso tipo { get; private set; } 

        public TallerExtraProgramatico(List<Evento> eventosExtraP,
            string nombre, string profesor, List<Evento> horario, TipoCurso tipo):
            base(nombre, profesor, horario, tipo)
        {
            this.eventosExtraP = eventosExtraP;
            tipo = TipoCurso.Extra;

        }
    }
}
