using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    [Serializable()]
    public class Agenda
    {
        List<Evento> listaEventosAgenda;

        public Agenda(List<Evento> listaEventosAgenda)
        {
            this.listaEventosAgenda = listaEventosAgenda;
        }

    } 
}
