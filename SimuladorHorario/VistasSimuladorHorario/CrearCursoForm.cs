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
        public int contadorDeEventos = 0;
        public event EventHandler OnAgregarEvento;
        public event EventHandler OnRegresar;
        List<Evento> listaEventos = new List<Evento>();

        public CrearCursoForm()
        {
            InitializeComponent();
            this.EspecialidadCB.DataSource = Enum.GetValues(typeof(Especialidad));
            
        }

        public void AñadirEventos(List<Evento> eventos)
        {
            listaEventos.AddRange(eventos);

           
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
            int creditos = 0;
            try
            {
                creditos = Convert.ToInt32(CreditosUser.Text);
            }
            catch { MessageBox.Show("Creditos No Valido!"); return; }

            if (nrc == "" || nombreCurso == "" || nombreProfesor == "" || apellidoProfesor == "")
            {
                MessageBox.Show("Casillas Sin Rellenar");
                return;
            }

            Especialidad especialidad = (Especialidad)EspecialidadCB.SelectedItem;
            Gestor.CrearCursoCurricular(nrc, nombreCurso.ToUpper(), (apellidoProfesor.ToUpper() + "/" + nombreProfesor.ToUpper()), creditos, especialidad, listaEventos);
            OnRegresar(this, EventArgs.Empty);
            this.Hide();
        }

        private void CrearCursoForm_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void EventAddButton_Click(object sender, EventArgs e)
        {
            OnAgregarEvento(this, EventArgs.Empty);
        }

        private void CrearCursoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Aplicacion.SerializeAll();
        }

        private void RegresarButton_Click(object sender, EventArgs e)
        {
            OnRegresar(this, EventArgs.Empty);
            this.Hide();
        }

        private void EventosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
