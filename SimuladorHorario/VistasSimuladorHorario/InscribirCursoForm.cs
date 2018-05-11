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
    public partial class InscribirCursoForm : Form
    {
        public event EventHandler OnInscribir;

        public InscribirCursoForm()
        {
            InitializeComponent();
            InicializarCursoComboBox();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void InicializarCursoComboBox()
        {
            List<string> listaCursos = new List<string>();
            foreach(CursoCurricular curso in Aplicacion.cursos)
            {
                listaCursos.Add(curso.nombre + " : " + curso.profesor);
            }
            CursosComboBox.DataSource = listaCursos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnInscribir(this,EventArgs.Empty);
            this.Close();
        }
    }
}
