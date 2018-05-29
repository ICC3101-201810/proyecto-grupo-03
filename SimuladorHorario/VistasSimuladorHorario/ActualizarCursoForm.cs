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
        public event EventHandler<ActualizarCursoEventArgs> OnActualizar;
        public ActualizarCursoForm()
        {
            InitializeComponent();
            especialidadCB.DataSource = Enum.GetValues(typeof(Especialidad));
            InicializarCursoComboBox();

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
            if(actualizarNrcCursoArgs.cambio == "")
            {
                MessageBox.Show("Debe ingresar un cambio");
                return;
            }
            OnActualizar(this, actualizarNrcCursoArgs);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CambiarCreditosB_Click(object sender, EventArgs e)
        {
            ActualizarCursoEventArgs actualizarCreditosCursoArgs = new ActualizarCursoEventArgs();
            actualizarCreditosCursoArgs.parametro = "creditos";
            actualizarCreditosCursoArgs.nrc = CursosCB.SelectedItem.ToString().Split(':')[0];
            actualizarCreditosCursoArgs.cambio = creditosTB.Text;
            if (actualizarCreditosCursoArgs.cambio == "")
            {
                MessageBox.Show("Debe ingresar un cambio");
                return;
            }
            OnActualizar(this, actualizarCreditosCursoArgs);
        }

        private void CambiarEspecialidadB_Click(object sender, EventArgs e)
        {
            ActualizarCursoEventArgs actualizarEspecialidadCursoArgs = new ActualizarCursoEventArgs();
            actualizarEspecialidadCursoArgs.parametro = "especialidad";
            actualizarEspecialidadCursoArgs.nrc = CursosCB.SelectedItem.ToString().Split(':')[0];
            actualizarEspecialidadCursoArgs.cambio = especialidadCB.SelectedText;
            OnActualizar(this, actualizarEspecialidadCursoArgs);

        }
    }
}
