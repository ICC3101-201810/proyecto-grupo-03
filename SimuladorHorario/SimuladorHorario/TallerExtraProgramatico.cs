using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    class TallerExtraProgramatico:Curso
    {
        List<Evento> eventosExtraP;

        public TallerExtraProgramatico(List<Evento> eventosExtraP,
            string nombre, string profesor, List<Evento> horario):
            base(nombre, profesor, horario)
        {
            this.eventosExtraP = eventosExtraP;

        }
    }
}
