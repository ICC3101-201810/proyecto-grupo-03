using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasSimuladorHorario
{
    public class RegistrarseController
    {
        RegistrarseForm registrarseForm;

        public RegistrarseController(RegistrarseForm registrarseForm)
        {
            this.registrarseForm = registrarseForm;
            this.registrarseForm.OnRegistrarse += VistasRegistrarse_OnRegistrarse;
            Console.WriteLine("hola");
        }

        private void VistasRegistrarse_OnRegistrarse(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            registrarseForm.Enabled = false;
        }
    }
}
