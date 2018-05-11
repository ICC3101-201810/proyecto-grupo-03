using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasSimuladorHorario
{
    class GestorController
    {
        GestorForm gestorForm;

        public GestorController(GestorForm gestorForm)
        {
            this.gestorForm = gestorForm;
            this.gestorForm.OnCrearCurso += VistasGestor_OnCrearCurso;
        }

        private void VistasGestor_OnCrearCurso(object sender, EventArgs e)
        {

            CrearCursoForm crearCursoForm = new CrearCursoForm();
            crearCursoForm.Show();
        }
    }
}
