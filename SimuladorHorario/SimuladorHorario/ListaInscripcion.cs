using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    class ListaInscripcion
    {
        List<Curso> listaCursosInscritos;
        int creditosTotales;

        public ListaInscripcion(List<Curso> listaCursosInscritos, int creditosTotales)
        {
            this.listaCursosInscritos = listaCursosInscritos;
            this.creditosTotales = creditosTotales;
        }
    }
}
