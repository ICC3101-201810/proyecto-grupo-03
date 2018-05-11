using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    [Serializable()]
    public class Horario
    {
        List<Evento> eventosHorario;

        public Horario(List<Evento> listaEventosHorario)
        {
            this.eventosHorario = listaEventosHorario;
        }

        
    }
}
