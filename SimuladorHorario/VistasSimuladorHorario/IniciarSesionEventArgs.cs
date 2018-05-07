using SimuladorHorario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasSimuladorHorario
{
    public class IniciarSesionEventArgs : EventArgs
    {
        public Usuario usuario { get; set; }
    }
}
