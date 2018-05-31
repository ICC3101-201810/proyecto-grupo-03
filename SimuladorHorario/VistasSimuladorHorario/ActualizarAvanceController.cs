using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuladorHorario;

namespace VistasSimuladorHorario
{
    class ActualizarAvanceController
    {
        ActualizarAvanceDeMallaForm actualizarAvanceDeMallaForm;

        public ActualizarAvanceController(ActualizarAvanceDeMallaForm actualizarAvanceDeMallaForm)
        {
            this.actualizarAvanceDeMallaForm = actualizarAvanceDeMallaForm;
            actualizarAvanceDeMallaForm.OnAgregarCurso += VistasActualizarAvance_OnAgregarCurso;
            actualizarAvanceDeMallaForm.OnEliminarCurso += VistasActualizarAvance_OnEliminarCurso;
            actualizarAvanceDeMallaForm.OnRegresar += VistasActualizarAvance_OnRegresar;
        }

        public void VistasActualizarAvance_OnAgregarCurso(object sender, ActualizarAvanceEventArgs e)
        {
            Gestor.AñadirAlAvanceMalla(e.nombreEstudiante, e.curso);
        } 

        public void VistasActualizarAvance_OnEliminarCurso(object sender, ActualizarAvanceEventArgs e)
        {
            Gestor.EliminarDelAvanceMalla(e.nombreEstudiante, e.curso);
        }

        private void VistasActualizarAvance_OnRegresar(object sender, EventArgs e)
        {
            GestorForm gestorForm = new GestorForm();
            GestorController gestorController = new GestorController(gestorForm);
            gestorForm.Show();
            
        }
    }
}
