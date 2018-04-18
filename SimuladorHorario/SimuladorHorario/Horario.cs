using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    class Horario:IHorarioMostrable
    {
        List<Evento> listaEventos;

        public Horario(List<Evento> listaEventos)
        {
            this.listaEventos = listaEventos;
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
