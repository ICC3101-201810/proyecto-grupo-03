using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    class Aplicacion
    {
        List<Usuario> usuarios;
        List<Curso> cursos;
        enum TipoEvento { PRBA, CLAS, LABT, AYUD, EXTRAP, PERS}

        public Aplicacion(List<Usuario> usuarios, List<Curso> cursos)
        {
            this.usuarios = usuarios;
            this.cursos = cursos;
        }
    }
}
