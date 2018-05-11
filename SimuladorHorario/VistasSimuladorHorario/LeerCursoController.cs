using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasSimuladorHorario
{
    class LeerCursoController
    {
        LeerCursoForm LeerCursoForm;

        public LeerCursoController(LeerCursoForm leerCursoForm)
        {
            LeerCursoForm = leerCursoForm;
            LeerCursoForm.OnLeerCurso += VistasLeerCurso_OnLeerCurso;
        }
        public void VistasLeerCurso_OnLeerCurso(object sender, EventArgs e)
        {
            LeerCursoForm leerCursoForm = new LeerCursoForm();
            LeerCursoController leerCursoController = new LeerCursoController(leerCursoForm);
            leerCursoForm.Show();
            leerCursoForm.Enabled = false;
        }
    }
}
