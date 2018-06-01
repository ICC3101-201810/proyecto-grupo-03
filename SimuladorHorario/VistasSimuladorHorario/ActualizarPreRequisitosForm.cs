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
    public partial class ActualizarPreRequisitosForm : Form
    {
        ActualizarCursoForm parent;
        CursoCurricular cursoActivo;
        public event EventHandler<ActualizarPreRequisitosEventArgs> OnAgregarCurso;
        public event EventHandler<ActualizarPreRequisitosEventArgs> OnEliminarCurso;
        public ActualizarPreRequisitosForm(ActualizarCursoForm parent)
        {
            this.parent = parent;
            cursoActivo = parent.cursoActivo;
            InitializeComponent();
            InicializarCursosDisponiblesLB();
            InicializarPreRequisitosLB();
        }

        public void InicializarCursosCB()
        {
            List<string> nombresCursos = new List<string>();
            foreach(CursoCurricular c in Aplicacion.cursos)
            {
                nombresCursos.Add(c.nombre);
            }      
        }

        private void ActualizarPreRequisitosForm_Load(object sender, EventArgs e)
        {

        }
        

        public void InicializarCursosDisponiblesLB()
        {
            
            List<string> nombresCursos = new List<string>();
            foreach (CursoCurricular c in Aplicacion.cursos)
            {
                if (!nombresCursos.Contains(c.nombre) && !cursoActivo.cursosPreRequisito.Contains(c.nombre))
                {
                    nombresCursos.Add(c.nombre);
                }
            }
            CursosDisponiblesLB.DataSource = nombresCursos;
        }

        public void InicializarPreRequisitosLB()
        {
            List<string> nombresCursos = new List<string>();
            foreach(string c in cursoActivo.cursosPreRequisito)
            {
                nombresCursos.Add(c);
            }
            PreRequisitosLB.DataSource = nombresCursos;
        }


        private void CursosCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            InicializarCursosDisponiblesLB();
            InicializarPreRequisitosLB();
        }

        private void ActualizarPreRequisitosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

        private void AgregarCursoB_Click(object sender, EventArgs e)
        {
            ActualizarPreRequisitosEventArgs actualizarPreRequisitosEventArgs = new ActualizarPreRequisitosEventArgs();
            actualizarPreRequisitosEventArgs.curso = cursoActivo.nombre;
            actualizarPreRequisitosEventArgs.cambio = (string)CursosDisponiblesLB.SelectedItem;
            OnAgregarCurso(this, actualizarPreRequisitosEventArgs);
            InicializarCursosDisponiblesLB();
            InicializarPreRequisitosLB();
        }

        private void EliminarCursoB_Click(object sender, EventArgs e)
        {
            ActualizarPreRequisitosEventArgs actualizarPreRequisitosEventArgs = new ActualizarPreRequisitosEventArgs();
            actualizarPreRequisitosEventArgs.curso = cursoActivo.nombre;
            actualizarPreRequisitosEventArgs.cambio = (string)PreRequisitosLB.SelectedItem;
            OnEliminarCurso(this, actualizarPreRequisitosEventArgs);
            InicializarCursosDisponiblesLB();
            InicializarPreRequisitosLB();
        }

        private void GuardarRegresarB_Click(object sender, EventArgs e)
        {
            Aplicacion.SerializeAll();
            Close();
        }
    }
}
