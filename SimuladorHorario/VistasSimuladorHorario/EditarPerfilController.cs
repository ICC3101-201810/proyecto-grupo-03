using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuladorHorario;

namespace VistasSimuladorHorario
{
    class EditarPerfilController
    {
        EditarPerfil editarPerfil = new EditarPerfil();
        Estudiante estudianteActivo;
        public EditarPerfilController(EditarPerfil editarPerfil, Usuario usuarioActivo)
        {
            this.editarPerfil = editarPerfil;
            this.estudianteActivo = (Estudiante)usuarioActivo;
        }

      

    }
}
