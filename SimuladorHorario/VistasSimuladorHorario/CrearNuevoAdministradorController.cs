using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasSimuladorHorario
{
    class CrearNuevoAdministradorController
    {
        CrearNuevoAdministradorForm crearNuevoAdministradorForm;

        public CrearNuevoAdministradorController(CrearNuevoAdministradorForm crearNuevoAdministradorForm)
        {
            this.crearNuevoAdministradorForm = crearNuevoAdministradorForm;
            this.crearNuevoAdministradorForm.OnCrearNuevoAdministrador += VistasCrearNuevoAdministrador_OnCrearNuevoAdministrador;
            this.crearNuevoAdministradorForm.OnRegresar += VistasCrearNuevoAdministrador_OnRegresar;
        }

        private void VistasCrearNuevoAdministrador_OnCrearNuevoAdministrador(object sender, EventArgs e)
        {
            GestorForm gestorForm = new GestorForm();
            GestorController gestorController = new GestorController(gestorForm);
            gestorForm.Show();
            crearNuevoAdministradorForm.Enabled = false;
        }

        private void VistasCrearNuevoAdministrador_OnRegresar(object sender, EventArgs e)
        {
            GestorForm gestorForm = new GestorForm();
            GestorController gestorController = new GestorController(gestorForm);
            gestorForm.Show();
            crearNuevoAdministradorForm.Enabled = false;
        }
    }
}
