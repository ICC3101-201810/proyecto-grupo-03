using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasSimuladorHorario
{
    public class Controller
    {
        LoginForm loginForm;
        PlataformaEstudianteForm plataformaEstudianteForm;

        public Controller(LoginForm loginForm, PlataformaEstudianteForm plataformaEstudianteForm)
        {
            this.loginForm = loginForm;
            this.plataformaEstudianteForm = plataformaEstudianteForm;
        }

        public void ShowLogin() { loginForm.Show(); }
        public void ShowPlataformaEstudiante() { plataformaEstudianteForm.Show(); }







    }
}
