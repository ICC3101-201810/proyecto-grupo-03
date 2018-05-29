using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuladorHorario;
using System.Windows.Forms;

namespace VistasSimuladorHorario
{
    class ActualizarCursoController
    {
        ActualizarCursoForm actualizarCursoForm;

        public ActualizarCursoController(ActualizarCursoForm actualizarCursoForm)
        {
            this.actualizarCursoForm = actualizarCursoForm;
            actualizarCursoForm.OnActualizar += VistasActualizarCurso_OnActualizar;
            actualizarCursoForm.OnRegresar += VistasActualizarCurso_OnRegresar;
        }

        private void VistasActualizarCurso_OnActualizar(object sender, ActualizarCursoEventArgs e)
        {
            if(Gestor.ActualizarCurso(e.nrc, e.parametro, e.cambio))
            {
                MessageBox.Show("Cambio Realizado");
            }

        }

        private void VistasActualizarCurso_OnRegresar(object sender, EventArgs e)
        {
            GestorForm gestorForm = new GestorForm();
            GestorController gestorController = new GestorController(gestorForm);
            gestorForm.Show();
            actualizarCursoForm.Enabled = false;
        }
      
    }
}
