using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    public class TallerExtraProgramatico : Curso
    {
        List<Evento> eventosExtraP;

        public TallerExtraProgramatico(List<Evento> eventosExtraP,
            string nombre, string profesor, TipoCurso tipo):
            base(nombre, profesor, tipo)
        {
            this.eventosExtraP = eventosExtraP;
            tipo = TipoCurso.Extra;

        }
    }
}
