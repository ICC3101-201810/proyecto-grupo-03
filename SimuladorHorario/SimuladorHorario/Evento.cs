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
        public DateTime horaInicio;
        public DateTime horaFin;
        DayOfWeek dia;
        string sala;
        TipoEvento tipoEvento;
        public Evento(string nombre,DateTime horaInicio, DateTime horaFin,
            DayOfWeek dia, string sala,TipoEvento tipoEvento)
        {
            this.nombre = nombre;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.dia = dia;
            this.sala = sala;
            this.tipoEvento = tipoEvento;

        }

    }
}
