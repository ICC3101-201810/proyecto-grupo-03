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
        public event EventHandler<ActualizarPreRequisitosEventArgs> OnAgregarCurso;
        public event EventHandler<ActualizarAvanceEventArgs> OnEliminarCurso;
        public event EventHandler OnRegresar;
        public ActualizarPreRequisitosForm()
        {
            InitializeComponent();
        }

        public void InicializarCursosCB()
        {
            List<string> nombresCursos = new List<string>();
            foreach(Curso c in Aplicacion.cursos)
            {
                nombresCursos.Add(c.nombre);
            }
        }

        private void ActualizarPreRequisitosForm_Load(object sender, EventArgs e)
        {

        }
    }
}
