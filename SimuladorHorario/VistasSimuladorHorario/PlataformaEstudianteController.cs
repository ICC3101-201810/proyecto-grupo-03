using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuladorHorario;
using System.Windows.Forms;

namespace VistasSimuladorHorario
{
    public class PlataformaEstudianteController
    {
        PlataformaEstudianteForm plataformaEstudianteForm;
        Usuario usuarioActivo;

        public PlataformaEstudianteController(PlataformaEstudianteForm plataformaEstudianteForm, Usuario usuarioActivo)
        {
            this.usuarioActivo = usuarioActivo;
            this.plataformaEstudianteForm = plataformaEstudianteForm;
            this.plataformaEstudianteForm.OnInscribirCurso += VistasInscribirCurso_OnInscribirCurso;
            this.plataformaEstudianteForm.OnEditarPerfil += VistasEditarPerfil_OnEditarPerfil;
            this.plataformaEstudianteForm.OnCerrarSesion += OnCerrarSesion;
            this.plataformaEstudianteForm.OnCerrandoApp += OnCerrandoApp;
            this.plataformaEstudianteForm.OnAgregarEvento += VistasAgregarEvento_OnClickAgregarEvento;
        }

        private void VistasInscribirCurso_OnInscribirCurso(object sender, EventArgs e)
        {
            InscribirCursoForm inscribirCursoForm = new InscribirCursoForm();
            InscribirCursoController inscribirCursoController = new InscribirCursoController(inscribirCursoForm,usuarioActivo);
            inscribirCursoForm.OnInscribir += VistasInscribirCurso_OnInscribir;
            inscribirCursoForm.ShowDialog();
        }

        private void VistasInscribirCurso_OnInscribir(object sender, InscribirCursoEventArgs e)
        {
            Estudiante estudiante = (Estudiante)usuarioActivo;
            plataformaEstudianteForm.ActualizarHorario(estudiante.listaInscripcion);
            plataformaEstudianteForm.ActualizarAgenda();
        }


        private void VistasEditarPerfil_OnEditarPerfil(object sender, EventArgs e)
        {
            eliminarCursoButton editarPerfil = new eliminarCursoButton();
            EditarPerfilController editarPerfilController = new EditarPerfilController(editarPerfil,usuarioActivo);
            editarPerfil.ShowDialog();
            //MessageBox.Show("WIWI");
            Estudiante estudiante = (Estudiante)usuarioActivo;
            plataformaEstudianteForm.InicializarHorario();
        }

        private void VistasAgregarEvento_OnClickAgregarEvento(object sender, EventArgs e)
        {
            Estudiante estudianteActivo = (Estudiante)usuarioActivo;
            AgregarEventoForm agregarEventoForm = new AgregarEventoForm(estudianteActivo);
            agregarEventoForm.ShowDialog();
            this.plataformaEstudianteForm.ActualizarAgenda();
        }


        private void OnCerrarSesion(object sender, EventArgs e)
        {

            //Aplicacion.usuarios.Add(usuarioActivo);
            LoginForm loginForm = new LoginForm();
            LoginController loginController = new LoginController(loginForm);
            loginForm.Show();
            usuarioActivo = null;
            plataformaEstudianteForm.Hide();
        }

        private void OnCerrandoApp(object sender, EventArgs e)
        {
            Aplicacion.usuarios.Add(usuarioActivo);
            Aplicacion.SerializeAll();
            //MessageBox.Show("Guardado!");
            System.Environment.Exit(0);
        }


    }
}
