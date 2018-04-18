using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    interface IHorarioMostrable
    {
        void Mostrar(List<Curso> listaInformacion);
        void GuardarImagen();
    }
}
