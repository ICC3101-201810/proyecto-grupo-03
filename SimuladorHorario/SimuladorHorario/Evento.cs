using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    class Evento
    {
        BloquesHorarios bloque;
        DayOfWeek dia;
        string salaOLugar;
        TipoEvento tipoEvento;

        public Evento(BloquesHorarios bloque, DayOfWeek dia, string salaOLugar,TipoEvento tipoEvento)
        {
            this.bloque = bloque;
            this.dia = dia;
            this.salaOLugar = salaOLugar;
            this.tipoEvento = tipoEvento;

        }

    }
}
