using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    class Evento
    {
        public string nombre { get; private set; }
        public string hora { get; private set; }
        public string fecha { get; private set; }
        public string sala { get; private set; }
        public TipoEvento tipo { get; private set; }

        public Evento(string nombre, string hora, string sala, TipoEvento tipo)
        {
            this.nombre = nombre;
            this.hora = hora;
            this.sala = sala;
            this.tipo = tipo;
            this.fecha = "NONE";
        }

        public Evento(string nombre, string hora, string fecha, string sala, TipoEvento tipo)
        {
            this.nombre = nombre;
            this.hora = hora;
            this.fecha = fecha;
            this.sala = sala;
            this.tipo = tipo;
        }

       
    }
}
