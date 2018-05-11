using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuladorHorario;

namespace VistasSimuladorHorario
{
    class InscribirCursoController
    {
        InscribirCursoForm InscribirCursoForm;

        public InscribirCursoController(InscribirCursoForm inscribirCursoForm)
        {
            InscribirCursoForm = inscribirCursoForm;
            inscribirCursoForm.OnInscribir += VistasInscribirCurso_OnInscribir;
        }

        public void VistasInscribirCurso_OnInscribir(object sender, EventArgs e)
        {
        
        }

    }
}
