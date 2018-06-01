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
    public partial class ActualizarCursoForm : Form
    {
        public CursoCurricular cursoActivo;
        public event EventHandler<ActualizarCursoEventArgs> OnActualizar;
        public event EventHandler OnRegresar;
        public event EventHandler OnActualizarPreRequisitos;
        public ActualizarCursoForm()
        {
            InitializeComponent();
            especialidadCB.DataSource = Enum.GetValues(typeof(Especialidad));
            InicializarCursoComboBox();
            ActualizarCursoActivo();

        }

        public void InicializarCursoComboBox()
        {
            List<string> listaCursos = new List<string>();
            foreach (CursoCurricular curso in Aplicacion.cursos)
            {
                if (!listaCursos.Contains(curso.nrc + ":" + curso.nombre + "\t" + curso.profesor))
                {
                    listaCursos.Add(curso.nrc + ":" + curso.nombre + ":" + curso.profesor);
                }
            }
            CursosCB.DataSource = listaCursos;
        }

        public void ActualizarCursoActivo()
        {
            foreach (CursoCurricular c in Aplicacion.cursos)
            {
                if (c.nombre == ((string)CursosCB.SelectedItem).Split(':')[1]) cursoActivo = c;
            }

        }

        private void ActualizarCursoForm_Load(object sender, EventArgs e)
        {

        }

        private void ActualizarCursoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Aplicacion.SerializeAll();
            Environment.Exit(0);
        }

        private void CambiarNrcB_Click(object sender, EventArgs e)
        {
            ActualizarCursoEventArgs actualizarNrcCursoArgs = new ActualizarCursoEventArgs();
            actualizarNrcCursoArgs.parametro = "nrc";
            actualizarNrcCursoArgs.nrc = CursosCB.SelectedItem.ToString().Split(':')[0];
            actualizarNrcCursoArgs.cambio = NrcTB.Text;
            if((string)actualizarNrcCursoArgs.cambio == "")
            {
                MessageBox.Show("Debe ingresar un cambio");
                return;
            }
            OnActualizar(this, actualizarNrcCursoArgs);
            InicializarCursoComboBox();
        }

        private void CursosCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarCursoActivo();
        }

        private void CambiarCreditosB_Click(object sender, EventArgs e)
        {
            ActualizarCursoEventArgs actualizarCreditosCursoArgs = new ActualizarCursoEventArgs();
            actualizarCreditosCursoArgs.parametro = "creditos";
            actualizarCreditosCursoArgs.nrc = CursosCB.SelectedItem.ToString().Split(':')[0];
            actualizarCreditosCursoArgs.cambio = creditosTB.Text;
            if (actualizarCreditosCursoArgs.cambio.ToString() == "")
            {
                MessageBox.Show("Debe ingresar un cambio");
                return;
            }
            OnActualizar(this, actualizarCreditosCursoArgs);
            InicializarCursoComboBox();
        }

        private void CambiarEspecialidadB_Click(object sender, EventArgs e)
        {
            ActualizarCursoEventArgs actualizarEspecialidadCursoArgs = new ActualizarCursoEventArgs();
            actualizarEspecialidadCursoArgs.parametro = "especialidad";
            actualizarEspecialidadCursoArgs.nrc = CursosCB.SelectedItem.ToString().Split(':')[0];
            actualizarEspecialidadCursoArgs.cambio = especialidadCB.SelectedItem;
            OnActualizar(this, actualizarEspecialidadCursoArgs);
            InicializarCursoComboBox();

        }

        private void CambiarProfesorB_Click(object sender, EventArgs e)
        {
            ActualizarCursoEventArgs actualizarProfesorCursoArgs = new ActualizarCursoEventArgs();
            actualizarProfesorCursoArgs.parametro = "profesor";
            actualizarProfesorCursoArgs.nrc = CursosCB.SelectedItem.ToString().Split(':')[0];
            string nombre = NombreProfesorTB.Text;
            string apellido = ApellidoProfesorTB.Text;
            actualizarProfesorCursoArgs.cambio = apellido.ToUpper() + "/" + nombre.ToUpper();
            OnActualizar(this, actualizarProfesorCursoArgs);
            InicializarCursoComboBox();
        }

        private void RegresarB_Click(object sender, EventArgs e)
        {
            OnRegresar(this, EventArgs.Empty);
            this.Hide();
        }

        private void ActualizarPreRequisitos_Click(object sender, EventArgs e)
        {
            OnActualizarPreRequisitos(this, EventArgs.Empty);

        }
    }
}
