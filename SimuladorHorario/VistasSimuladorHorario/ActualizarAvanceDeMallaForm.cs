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
        public ActualizarAvanceDeMallaForm()
        {
            InitializeComponent();
            InicializarAlumnosCB();
            InicializarCursosDisponiblesLB();
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

        public void InicializarCursosDisponiblesLB()
        {
            List<string> nombresCursos = new List<string>();
            foreach (CursoCurricular c in Aplicacion.cursos)
            {
                if (!nombresCursos.Contains(c.nombre))
                {
                    nombresCursos.Add(c.nombre);
                }
            }
            CursosDisponiblesLB.DataSource = nombresCursos;
        }

        public void InicializarAvanceMallaLB()
        {
            AvanceMallaLB.DataSource = estudianteActivo.avanceMalla;

        }

        private void ActualizarAvanceDeMallaForm_Load(object sender, EventArgs e)
        {

        }

        private void AlumnosCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Usuario user in Aplicacion.usuarios)
            {
                if (AlumnosCB.SelectedItem == user.nombre)
                {
                    estudianteActivo = (Estudiante)user;
                }
            }
            InicializarAvanceMallaLB();
        }
    }
}
