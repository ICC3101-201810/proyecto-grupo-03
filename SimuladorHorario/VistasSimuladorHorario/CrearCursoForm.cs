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
    public partial class CrearCursoForm : Form
    {
        public CrearCursoForm()
        {
            InitializeComponent();
            this.EspecialidadCB.DataSource = Enum.GetValues(typeof(Especialidad));
            List<Evento> listaEventos = new List<Evento>();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CrearCursoButton_Click(object sender, EventArgs e)
        {
            string nrc = NRCUser.Text;
            string nombreCurso = NCursoUser.Text;
            string nombreProfesor = NProfeUser.Text;
            string apellidoProfesor = AProfeUser.Text;
            int creditos = Convert.ToInt32(CreditosUser.Text);
            Especialidad especialidad = (Especialidad)EspecialidadCB.SelectedItem;
            Gestor.CrearCursoCurricular(nrc, nombreCurso.ToUpper(), (apellidoProfesor.ToUpper() + "/" + nombreProfesor.ToUpper()), creditos, especialidad);
        }

        private void CrearCursoForm_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void EventAddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
