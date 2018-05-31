using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimuladorHorario;

namespace VistasSimuladorHorario
{
    public partial class ActualizarAvanceDeMallaForm : Form
    {
        Estudiante estudianteActivo;
        public event EventHandler<ActualizarAvanceEventArgs> OnAgregarCurso;
        public event EventHandler<ActualizarAvanceEventArgs> OnEliminarCurso;
        public event EventHandler OnRegresar;
        public ActualizarAvanceDeMallaForm()
        {
            InitializeComponent();
            InicializarAlumnosCB();
            InicializarCursosDisponiblesLB();
            InicializarAvanceMallaLB();
        }

        public void InicializarAlumnosCB()
        {
            List<string> nombresAlumnos = new List<string>();
            bool flag = true;
            foreach (Usuario user in Aplicacion.usuarios)
            {
                if (user is Estudiante)
                {
                    if (flag) { estudianteActivo = (Estudiante)user; flag = false; }
                    nombresAlumnos.Add(user.nombre);
                }
            }
            AlumnosCB.DataSource = nombresAlumnos;
            
        }

        public void ActualizarEstudianteActivo()
        {
            foreach (Usuario user in Aplicacion.usuarios)
            {
                if ((string)AlumnosCB.SelectedItem == user.nombre)
                {
                    estudianteActivo = (Estudiante)user;
                }
            }
        }

        public void InicializarCursosDisponiblesLB()
        {
            List<string> nombresCursos = new List<string>();
            foreach (CursoCurricular c in Aplicacion.cursos)
            {
                if (!nombresCursos.Contains(c.nombre) && !estudianteActivo.avanceMalla.Contains(c.nombre))
                {
                    nombresCursos.Add(c.nombre);
                }
            }
            CursosDisponiblesLB.DataSource = nombresCursos;
        }

        public void InicializarAvanceMallaLB()
        {

            List<string> nombresCursos = new List<string>();
            foreach(string s in estudianteActivo.avanceMalla)
            {
                nombresCursos.Add(s);
            }

            AvanceMallaLB.DataSource = nombresCursos;
        }

        private void ActualizarAvanceDeMallaForm_Load(object sender, EventArgs e)
        {

        }

        private void AlumnosCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarEstudianteActivo();
            InicializarAvanceMallaLB();
            InicializarCursosDisponiblesLB();
        }

        private void ActualizarAvanceDeMallaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Aplicacion.SerializeAll();
            System.Environment.Exit(0);
        }

        private void AgregarCursoB_Click(object sender, EventArgs e)
        {
            ActualizarAvanceEventArgs actualizarAvanceEventArgs = new ActualizarAvanceEventArgs();
            actualizarAvanceEventArgs.nombreEstudiante = estudianteActivo.nombre;
            actualizarAvanceEventArgs.curso = (string)CursosDisponiblesLB.SelectedItem;
            OnAgregarCurso(this, actualizarAvanceEventArgs);
            InicializarCursosDisponiblesLB();
            InicializarAvanceMallaLB();    
        }

        private void EliminarCursoB_Click(object sender, EventArgs e)
        {
            ActualizarAvanceEventArgs actualizarAvanceEventArgs = new ActualizarAvanceEventArgs();
            actualizarAvanceEventArgs.nombreEstudiante = estudianteActivo.nombre;
            actualizarAvanceEventArgs.curso = (string)AvanceMallaLB.SelectedItem;
            OnEliminarCurso(this, actualizarAvanceEventArgs);
            InicializarCursosDisponiblesLB();
            InicializarAvanceMallaLB();
        }

        private void RegresarB_Click(object sender, EventArgs e)
        {
            OnRegresar(this, EventArgs.Empty);
            Hide();
        }

        private void AvanceMallaLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
