using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuladorHorario;

namespace VistasSimuladorHorario
{
    class GestorController
    {
        GestorForm gestorForm;
        Usuario usuarioActivo;

        public GestorController(GestorForm gestorForm)
        {
            this.gestorForm = gestorForm;
            this.gestorForm.OnCrearCurso += VistasGestor_OnCrearCurso;
            this.gestorForm.OnEliminarCurso += VistasGestor_OnEliminarCurso;
            this.gestorForm.OnLeerCurso += VistasGestor_OnLeerCurso;
            this.gestorForm.OnCerrarSesion += VistasGestor_OnCerrarSesion;
            this.gestorForm.OnActualizarCurso += VistasGestor_OnActualizarCurso;

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
            LeerCursoController leerCursoController = new LeerCursoController(leerCursoForm);
            leerCursoForm.Show();
        }
        private void VistasGestor_OnCerrarSesion(object sender, EventArgs e)
        {
            Aplicacion.usuarios.Add(usuarioActivo);
            LoginForm loginForm = new LoginForm();
            LoginController loginController = new LoginController(loginForm);
            loginForm.Show();
            usuarioActivo = null;
            gestorForm.Hide();
        }
        private void VistasGestor_OnActualizarCurso(object sender, EventArgs e)
        {
            ActualizarCursoForm actualizarCursoForm = new ActualizarCursoForm();
            ActualizarCursoController actualizarCursoController = new ActualizarCursoController(actualizarCursoForm);
            actualizarCursoForm.Show();
        }
    }
}
