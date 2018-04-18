using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    class Administrador:Usuario
    {
        public Administrador(string nombreUsuario, string contraseña) :
            base(nombreUsuario, contraseña)
        {

        }
    }
}
