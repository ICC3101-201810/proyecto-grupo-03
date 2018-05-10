using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    [Serializable()]
    public class Horario:IHorarioMostrable
    {
        List<Evento> eventosHorario;

        public Horario(List<Evento> listaEventosHorario)
        {
            this.eventosHorario = listaEventosHorario;
        }

        public void GuardarImagen()
        {
            throw new NotImplementedException();
        }

        public void Mostrar(List<Evento> listaInformacion)
        {
            throw new NotImplementedException();
        }
    }
}
