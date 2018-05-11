using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasSimuladorHorario
{
    class LeerCursoController
    {
        LeerCursoForm leerCursoForm;

        public LeerCursoController(LeerCursoForm leerCursoForm)
        {
            this.leerCursoForm = leerCursoForm;
            this.leerCursoForm.OnLeerCurso += VistasLeerCurso_OnLeerCurso;
            this.leerCursoForm.OnRegresar += VistasLeerCurso_OnRegresar;
        }
        public void VistasLeerCurso_OnLeerCurso(object sender, EventArgs e)
        {
            LeerCursoForm leerCursoForm = new LeerCursoForm();
            LeerCursoController leerCursoController = new LeerCursoController(leerCursoForm);
            leerCursoForm.Show();
            leerCursoForm.Enabled = false;
        }
        private void VistasLeerCurso_OnRegresar(object sender, EventArgs e)
        {
            GestorForm gestorForm = new GestorForm();
            GestorController gestorController = new GestorController(gestorForm);
            gestorForm.Show();
            leerCursoForm.Enabled = false;
        }
}
}
