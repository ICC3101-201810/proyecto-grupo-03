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
            this.gestorForm.OnEliminarCurso += VistasGestor_OnEliminarCurso;
            this.gestorForm.OnLeerCurso += VistasGestor_OnLeerCurso;
        }

        private void VistasGestor_OnCrearCurso(object sender, EventArgs e)
        {
            CrearCursoForm crearCursoForm = new CrearCursoForm();
            CrearCursoController crearCursoController = new CrearCursoController(crearCursoForm);
            crearCursoForm.Show();
        }
        private void VistasGestor_OnEliminarCurso(object sender, EventArgs e)
        {
            EliminarCursoForm eliminarCursoForm = new EliminarCursoForm();
            EliminarCursoController eliminarCursoController = new EliminarCursoController(eliminarCursoForm);
            eliminarCursoForm.Show();
        }
        private void VistasGestor_OnLeerCurso(object sender, EventArgs e)
        {
            LeerCursoForm leerCursoForm = new LeerCursoForm();
            leerCursoForm.Show();
        }
    }
}
