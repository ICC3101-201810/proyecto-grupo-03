using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasSimuladorHorario
{
    class EliminarCursoController
    {
        EliminarCursoForm eliminarCursoForm;

        public EliminarCursoController(EliminarCursoForm eliminarCursoForm)
        {
            this.eliminarCursoForm = eliminarCursoForm;
            this.eliminarCursoForm.OnEliminarCurso += VistasEliminarCurso_OnEliminarCurso;
            this.eliminarCursoForm.OnRegresar += VistasEliminarCurso_OnRegresar;
        }

        public void VistasEliminarCurso_OnEliminarCurso(object sender, EventArgs e)
        {
            EliminarCursoForm eliminarCursoForm = new EliminarCursoForm();
            EliminarCursoController eliminarCursoController = new EliminarCursoController(eliminarCursoForm);
            eliminarCursoForm.Show();
            eliminarCursoForm.Enabled = false;
        }

        private void VistasEliminarCurso_OnRegresar(object sender, EventArgs e)
        {
            GestorForm gestorForm = new GestorForm();
            GestorController gestorController = new GestorController(gestorForm);
            gestorForm.Show();
            eliminarCursoForm.Enabled = false;
        }
    }
}
