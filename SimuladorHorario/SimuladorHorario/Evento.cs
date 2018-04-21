using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    class Evento
    {
        string nombre;
        BloquesHorarios bloque;
        DayOfWeek dia;
        string salaOLugar;
        TipoEvento tipoEvento;

        public Evento(string nombre,BloquesHorarios bloque, DayOfWeek dia, string salaOLugar,TipoEvento tipoEvento)
        {
            this.nombre = nombre;
            this.bloque = bloque;
            this.dia = dia;
            this.salaOLugar = salaOLugar;
            this.tipoEvento = tipoEvento;

        }

    }
}
