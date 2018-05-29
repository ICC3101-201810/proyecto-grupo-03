using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasSimuladorHorario
{
    class CrearCursoController
    {
        CrearCursoForm crearCursoForm;
        public CrearCursoController(CrearCursoForm crearCursoForm)
        {
            this.crearCursoForm = crearCursoForm;
            this.crearCursoForm.OnAgregarEvento += VistasCrearCurso_OnAgregarEvento;
            this.crearCursoForm.OnRegresar += VistasCrearCurso_OnRegresar;

        }
        private void VistasCrearCurso_OnAgregarEvento(object sender, EventArgs e)
        {
            AgregarEventoForm1 agregarEventoForm = new AgregarEventoForm1(crearCursoForm);
            AgregarEventoController agregarEventoController = new AgregarEventoController(agregarEventoForm);
            agregarEventoForm.ShowDialog();
        }
        private void VistasCrearCurso_OnRegresar(object sender, EventArgs e)
        {
            GestorForm gestorForm = new GestorForm();
            GestorController gestorController = new GestorController(gestorForm);
            gestorForm.Show();
            crearCursoForm.Enabled = false;
        }
    }
}
