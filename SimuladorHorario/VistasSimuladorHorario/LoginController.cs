using SimuladorHorario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasSimuladorHorario
{
    public class LoginController
    {
        LoginForm loginForm;
        Usuario usuarioActivo = null;
        public LoginController(LoginForm loginForm)
        {
            this.loginForm = loginForm;
            this.loginForm.OnIniciarSesion += VistasLogin_OnIniciarSesion;
            this.loginForm.OnRegistro += VistasRegistro_OnRegistro;
        }

        private void VistasLogin_OnIniciarSesion(object sender, IniciarSesionEventArgs e)
        {
            usuarioActivo = e.usuario;
            PlataformaEstudianteForm plataformaEstudianteForm = new PlataformaEstudianteForm();
            plataformaEstudianteForm.Show();
            loginForm.Enabled = false;
        }

        private void VistasRegistro_OnRegistro(object sender, EventArgs e)
        {
            RegistrarseForm registrarseForm = new RegistrarseForm();
            registrarseForm.Show();
            loginForm.Enabled = false;
        }

    }
}
