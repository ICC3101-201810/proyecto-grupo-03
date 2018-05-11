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
        public event EventHandler<InscribirCursoEventArgs> OnInscribir;


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
            foreach (CursoCurricular curso in Aplicacion.cursos)
            {
                if (!listaCursos.Contains(curso.nombre))
                {
                    listaCursos.Add(curso.nombre);
                }
            }

            List<string> listaProfesores = new List<string>();


            List<List<CursoCurricular>> listaCursoAgrupados = new List<List<CursoCurricular>>();










            CursosComboBox.DataSource = listaCursos;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InscribirCursoEventArgs inscribirCursoArgs = new InscribirCursoEventArgs();
            inscribirCursoArgs.nombreCursoInscribir = CursosComboBox.SelectedItem.ToString();
            OnInscribir(this, inscribirCursoArgs);
        }

        private void InscribirCursoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Aplicacion.SerializeAll();
            //System.Environment.Exit(0);
        }
    }

    
}
