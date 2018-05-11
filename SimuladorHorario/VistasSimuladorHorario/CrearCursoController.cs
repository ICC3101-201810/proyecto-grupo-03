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

        }
        private void VistasCrearCurso_OnAgregarEvento(object sender, EventArgs e)
        {
            AgregarEventoForm agregarEventoForm = new AgregarEventoForm();
            AgregarEventoController agregarEventoController = new AgregarEventoController(agregarEventoForm);
            agregarEventoForm.ShowDialog();
        }
    }
}
