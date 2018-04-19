using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    class Agenda:IHorarioMostrable
    {
        List<Evento> listaEventosAgenda;

        public Agenda(List<Evento> listaEventosAgenda)
        {
            this.listaEventosAgenda = listaEventosAgenda;
        }

        public void GuardarImagen()
        {
            throw new NotImplementedException();
        }

        public void Mostrar(List<Curso> listaInformacion)
        {
            throw new NotImplementedException();
        }
    }
}
