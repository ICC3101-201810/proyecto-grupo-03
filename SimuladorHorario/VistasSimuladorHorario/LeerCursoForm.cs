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
    public partial class LeerCursoForm : Form
    {
        public event EventHandler OnLeerCurso;
        public event EventHandler OnRegresar;

        public LeerCursoForm()
        {
            InitializeComponent();
            InicializarLeerCursoComboBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void InicializarLeerCursoComboBox()
        {
            List<string> listaCursos = new List<string>();

            foreach (CursoCurricular curso in Aplicacion.cursos)
            {
                listaCursos.Add(curso.nrc + ": " + curso.nombre);
            }
            LeerCursosComboBox.DataSource = listaCursos;
        }

        private void LeerCursoButton_Click(object sender, EventArgs e)
        {
            string nrcCursoALeer;
            string[] opcion = LeerCursosComboBox.SelectedItem.ToString().Split(':');
            nrcCursoALeer = opcion[0];

            Gestor.LeerCurso(nrcCursoALeer);
            return;
            /*
            if (OnLeerCurso != null)
            {
                OnLeerCurso(this, EventArgs.Empty);
            }
            this.Close();*/
        }

        private void LeerCursoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Aplicacion.SerializeAll();
            System.Environment.Exit(0);
        }

        private void LeerCursoForm_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }
        
        private void RegresarButton_Click(object sender, EventArgs e)
        {
            
            //OnRegresar(this, EventArgs.Empty);
            this.Hide();
            
            
        }
    }
}
