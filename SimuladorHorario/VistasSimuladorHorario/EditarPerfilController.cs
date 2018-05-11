using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuladorHorario;
using System.Windows.Forms;

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
            this.editarPerfil.OnGuardar += VistasEditarPerfil_OnGuardar;
            editarPerfil.cargarInfo(estudianteActivo);
        }

        private void VistasEditarPerfil_OnGuardar(object sender, EventArgs e)
        {
            editarPerfil.Guardar(estudianteActivo);
            MessageBox.Show("Cambios Realizados Exitosamente!");
            editarPerfil.Close();
        }

      

    }
}
