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
        DateTime horaInicio;
        DateTime horaFin;
        DateTime dia;
        string sala;

        public Evento(string nombre,DateTime horaInicio, DateTime horaFin,
            DateTime dia, string sala)
        {
            this.nombre = nombre;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.dia = dia;
            this.sala = sala;
        }

    }
}
