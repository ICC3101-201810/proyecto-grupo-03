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
    public partial class EliminarCursoForm : Form
    {
        public event EventHandler OnEliminarCurso;

        public EliminarCursoForm()
        {
            InitializeComponent();
            InicializarEliminarCursoComboBox();
        }

        public void InicializarEliminarCursoComboBox()
        {
            List<string> listaCursos = new List<string>();
            
            foreach (CursoCurricular curso in Aplicacion.cursos)
            {
                listaCursos.Add(curso.nrc + ": " + curso.nombre);
            }
            EliminarCursosComboBox.DataSource = listaCursos;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EliminarCursoButton_Click(object sender, EventArgs e)
        {
            string nrcCursoAEliminar;
            string[] opcion = EliminarCursosComboBox.SelectedItem.ToString().Split(':');
            nrcCursoAEliminar = opcion[0];

            Gestor.EliminarCurso(nrcCursoAEliminar);

            if (OnEliminarCurso != null)
            {
                OnEliminarCurso(this, EventArgs.Empty);
            }
            this.Close();
        }

        private void EliminarCursoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Aplicacion.SerializeAll();
            //System.Environment.Exit(0);
        }
    }
}
