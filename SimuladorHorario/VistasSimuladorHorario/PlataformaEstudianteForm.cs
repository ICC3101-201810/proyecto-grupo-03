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
    public partial class PlataformaEstudianteForm : Form
    {
        public PlataformaEstudianteForm()
        {
            InitializeComponent();
            InicializarHorario();
            MessageBox.Show("Bienvenido Usuario: "+Aplicacion.usuarioActual.nombre);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void PlataformaEstudianteForm_Load(object sender, EventArgs e)
        {

        }

        private void PlataformaEstudianteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Aplicacion.SerializeAll();
            System.Environment.Exit(0);
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void InicializarHorario()
        {
            List<string> listaHorariosString =  Enum.GetNames(typeof(BloquesHorarios)).ToList();
            int contadorHora = 8;
            foreach (string horario in listaHorariosString)
            {
                dataGridView1.Rows.Add($"{contadorHora}:30 - {contadorHora+1}:20", "", "", "", "", "", "", "");
                contadorHora++;
            }

            List<Evento> listaEventos = new List<Evento>();
            Estudiante estudianteActual = (Estudiante)Aplicacion.usuarioActual;
            foreach(Curso curso in estudianteActual.listaInscripcion)
            {
                CursoCurricular cursoCurricular = (CursoCurricular)curso;
                listaEventos.AddRange(cursoCurricular.eventosCurso);
            }

            foreach(Evento evento in listaEventos)
            {
                AgendaDataGrid.Rows.Add(evento.hora);
            }



        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
