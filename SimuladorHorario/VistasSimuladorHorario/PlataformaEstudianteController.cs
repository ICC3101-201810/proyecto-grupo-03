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
            plataformaEstudianteForm.ActualizarAgenda(estudiante.listaInscripcion);
        }


        private void VistasEditarPerfil_OnEditarPerfil(object sender, EventArgs e)
        {
            EditarPerfil editarPerfil = new EditarPerfil();
            EditarPerfilController editarPerfilController = new EditarPerfilController(editarPerfil,usuarioActivo);
            editarPerfil.ShowDialog();
        }

        private void OnCerrarSesion(object sender, EventArgs e)
        {
            Aplicacion.usuarios.Add(usuarioActivo);
            LoginForm loginForm = new LoginForm();
            LoginController loginController = new LoginController(loginForm);
            loginForm.Show();
            usuarioActivo = null;
            plataformaEstudianteForm.Hide();
        }


    }
}
