using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuladorHorario;
using System.Windows.Forms;

namespace VistasSimuladorHorario
{
    class InscribirCursoController
    {
        InscribirCursoForm inscribirCursoForm;
        Usuario usuarioActivo;


        public InscribirCursoController(InscribirCursoForm inscribirCursoForm, Usuario usuarioActivo)
        {
            this.usuarioActivo = usuarioActivo;
            this.inscribirCursoForm = inscribirCursoForm;
            inscribirCursoForm.OnInscribir += VistasInscribirCurso_OnInscribir;
        }

        public void VistasInscribirCurso_OnInscribir(object sender, InscribirCursoEventArgs e)
        {
            Estudiante estudiante = PlataformaEstudiante.InscribirCurso((Estudiante)usuarioActivo, e.nrc);
            usuarioActivo = estudiante;
            Estudiante estudianteActivo = (Estudiante)usuarioActivo;
            /*foreach(CursoCurricular curso in estudiante.listaInscripcion)
            {
                MessageBox.Show(curso.nombre);
            }*/

        }

    }
}
