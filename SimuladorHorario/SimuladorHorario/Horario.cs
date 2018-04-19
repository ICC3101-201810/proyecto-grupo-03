using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    class Horario:IHorarioMostrable
    {
        List<Evento> listaEventosHorario;

        public Horario(List<Evento> listaEventosHorario)
        {
            this.listaEventosHorario = listaEventosHorario;
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
