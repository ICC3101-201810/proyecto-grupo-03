using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorHorario
{
    [Serializable()]
    public class Evento
    {
        public string nombre { get; private set; }
        public string hora { get; private set; }
        public string fecha { get; private set; }
        public string sala { get; private set; }
        public TipoEvento tipo { get; private set; }
        public bool primerPeriodo = false;

        public Evento(string nombre, string hora, string sala, TipoEvento tipo, bool primerPeriodo = false)
        {
            this.nombre = nombre;
            this.hora = hora;
            this.sala = sala;
            this.tipo = tipo;
            this.fecha = "NONE";
            this.primerPeriodo = primerPeriodo;
        }

        public Evento(string nombre, string hora, string fecha, string sala, TipoEvento tipo, bool primerPeriodo = false)
        {
            this.nombre = nombre;
            this.hora = hora;
            this.fecha = fecha;
            this.sala = sala;
            this.tipo = tipo;
            this.primerPeriodo = primerPeriodo;
        }

        public DateTime GetDateTime()
        {

            fecha = fecha.Replace(':', '-');
            int dia = Convert.ToInt32(fecha.Split('-')[0]);
            int mes = Convert.ToInt32(fecha.Split('-')[1]);
            int año = Convert.ToInt32(fecha.Split('-')[2]);

            DateTime date = new DateTime(año,mes,dia);
            return date;
        }

       
    }
}
