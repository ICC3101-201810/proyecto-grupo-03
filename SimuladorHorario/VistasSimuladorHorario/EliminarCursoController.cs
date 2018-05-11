using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasSimuladorHorario
{
    class EliminarCursoController
    {
        EliminarCursoForm EliminarCursoForm;

        public EliminarCursoController(EliminarCursoForm eliminarCursoForm)
        {
            EliminarCursoForm = eliminarCursoForm;
            EliminarCursoForm.OnEliminarCurso += VistasEliminarCurso_OnEliminarCurso;
        }

        public void VistasEliminarCurso_OnEliminarCurso(object sender, EventArgs e)
        {
            EliminarCursoForm eliminarCursoForm = new EliminarCursoForm();
            EliminarCursoController eliminarCursoController = new EliminarCursoController(eliminarCursoForm);
            eliminarCursoForm.Show();
            eliminarCursoForm.Enabled = false;
        }
    }
}
