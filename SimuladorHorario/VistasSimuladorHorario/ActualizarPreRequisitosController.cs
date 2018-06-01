using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuladorHorario;

namespace VistasSimuladorHorario
{
    class ActualizarPreRequisitosController
    {
        ActualizarPreRequisitosForm actualizarPreRequisitosForm;

        public ActualizarPreRequisitosController(ActualizarPreRequisitosForm actualizarPreRequisitosForm)
        {
            this.actualizarPreRequisitosForm = actualizarPreRequisitosForm;
            actualizarPreRequisitosForm.OnAgregarCurso += VistasActualizarPreRequisitos_OnAgregarCurso;
            actualizarPreRequisitosForm.OnEliminarCurso += VistasActualizarPreRequisitos_OnEliminarCurso;
        }

        public void VistasActualizarPreRequisitos_OnAgregarCurso(object sender, ActualizarPreRequisitosEventArgs e)
        {
            Gestor.AñadirPreRequisito(e.curso, e.cambio);
        }

        public void VistasActualizarPreRequisitos_OnEliminarCurso(object sender, ActualizarPreRequisitosEventArgs e)
        {
            Gestor.EliminarPreRequisito(e.curso, e.cambio);
        }

        private void VistasActualizarPreRequisitos_OnRegresar(object sender, EventArgs e)
        {
            GestorForm gestorForm = new GestorForm();
            GestorController gestorController = new GestorController(gestorForm);
            gestorForm.Show();
        }
    }
}
