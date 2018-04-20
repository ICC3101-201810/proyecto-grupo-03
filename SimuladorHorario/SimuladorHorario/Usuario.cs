using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    abstract class Usuario
    {
        public string nombre { get; private set; }
        public string contraseña { get; private set; }
        public bool esAdmin { get; private set; }

        public Usuario(string nombre, string contraseña)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
        }

    }
}
