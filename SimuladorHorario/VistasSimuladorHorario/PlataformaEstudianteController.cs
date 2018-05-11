using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasSimuladorHorario
{
    class PlataformaEstudianteController
    {
        PlataformaEstudianteForm plataformaEstudianteForm;

        public PlataformaEstudianteController(PlataformaEstudianteForm plataformaEstudianteForm)
        {
            this.plataformaEstudianteForm = plataformaEstudianteForm;
            this.plataformaEstudianteForm.OnInscribirCurso += VistasInscribirCurso_OnInscribirCurso;
        }

        private void VistasInscribirCurso_OnInscribirCurso(object sender, EventArgs e)
        {
            InscribirCursoForm inscribirCursoForm = new InscribirCursoForm();
            InscribirCursoController inscribirCursoController = new InscribirCursoController(inscribirCursoForm);
            inscribirCursoForm.ShowDialog();
        }

    }
}
