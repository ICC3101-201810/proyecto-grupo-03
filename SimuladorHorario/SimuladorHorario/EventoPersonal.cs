using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    [Serializable()]
    public class EventoPersonal:Evento
    {
        public string nombre { get; private set; }
        public string hora { get; private set; }
        public string fecha { get; private set; }
        public string sala { get; private set; }
        public TipoEvento tipo { get; private set; }
        public bool primerPeriodo = false;

        public EventoPersonal(string nombre, string hora, string fecha, string sala) : base(nombre, hora, fecha, sala,TipoEvento.PERS,true)
        {
            this.nombre = nombre;
            this.hora = hora;
            this.fecha = fecha;
            this.sala = sala;
        }

        public override string ToString()
        {
            string text = fecha.Replace(':','-') + "  " +hora +"      " + nombre;
            return text;
        }

    }
}
