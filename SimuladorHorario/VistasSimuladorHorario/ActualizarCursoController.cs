using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuladorHorario;

namespace VistasSimuladorHorario
{
    class ActualizarCursoController
    {
        ActualizarCursoForm actualizarCursoForm;

        public ActualizarCursoController(ActualizarCursoForm actualizarCursoForm)
        {
            this.actualizarCursoForm = actualizarCursoForm;
            actualizarCursoForm.OnActualizar += VistasActualizarCurso_OnActualizar;
        }

        public void VistasActualizarCurso_OnActualizar(object sender, ActualizarCursoEventArgs e)
        {
            Gestor.ActualizarCurso(e.nrc, e.parametro, e.cambio);
        }

        public static implicit operator ActualizarCursoController(ActualizarCursoEventArgs v)
        {
            throw new NotImplementedException();
        }
    }
}
